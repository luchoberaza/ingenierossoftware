using Ingenieros_Commerce_Manager_v2._0.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public struct IngresosXFecha
    {
        public string Fecha { get; set; }
        public float Monto { get; set; }
    }
    public class ResumenData : conexionsql
    {

        private DateTime FechaInicio, FechaFin;
        private int NroDias;

        public int NumClientes { get; private set; }
        public int NumProductos { get; private set; }
        public int NumMatPrims { get; private set; }
        public List<KeyValuePair<string, float>> ProductosMasVendidos { get; private set; }
        public List<KeyValuePair<string, float>> ProductosBajoStock { get; private set; }
        public List<KeyValuePair<string, float>> GananciaXProducto { get; private set; }
        public List<IngresosXFecha> IngresosBrutos { get; private set; }
        public List<IngresosXFecha> GastosXFecha { get; private set; }
        public int NumVentas { get; private set; }
        public float TotalIngresos { get; private set; }
        public float TotalGanancias { get; private set; }
        public float TotalGastos { get; private set; }

        private void GetNroItems()
        {
            using (var conexion = GetMySqlConnection())
            {
                conexion.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conexion;
                    //Obtiene el total de clientes
                    cmd.CommandText = "SELECT COUNT(`ID.CLI`) FROM `cliente` WHERE `IdUsuario` = '" + Usuario.Id + "';";
                    NumClientes = int.Parse(cmd.ExecuteScalar().ToString());
                    //Obtiene el total de Productos 
                    cmd.CommandText = "SELECT COUNT(`ID.Prod`) FROM `producto_venta` WHERE `IdUsuario` = '" + Usuario.Id + "';";
                    NumProductos = int.Parse(cmd.ExecuteScalar().ToString());
                    //Obtiene el total de materias primas
                    cmd.CommandText = "SELECT COUNT(`ID.Mat`) FROM `materia_prima` WHERE `IdUsuario` = '" + Usuario.Id + "';";
                    NumMatPrims = int.Parse(cmd.ExecuteScalar().ToString());
                    //Obtiene el total de ventas
                    cmd.CommandText = "SELECT COUNT(`IdVenta`) FROM `venta` WHERE `IdUsuario` = '" + Usuario.Id + "' AND Fecha BETWEEN @fromDate AND @toDate;";
                    cmd.Parameters.Add("@fromDate", MySqlDbType.Date).Value = FechaInicio;
                    cmd.Parameters.Add("@toDate", MySqlDbType.Date).Value = FechaFin;
                    NumVentas = int.Parse(cmd.ExecuteScalar().ToString());
                }
            }
        }
        private void GetAnalisisVentas()
        {
            IngresosBrutos = new List<IngresosXFecha>();
            GastosXFecha = new List<IngresosXFecha>();
            TotalGanancias = 0;
            TotalIngresos = 0;
            TotalGastos = 0;
            using (var conexion = GetMySqlConnection())
            {
                conexion.Open();
                using (var cmd = new MySqlCommand())
                {
                    //Obtiene los ingresos
                    cmd.Connection = conexion;
                    cmd.CommandText = "SELECT Fecha, SUM(Importe) Total FROM `venta` WHERE `IdUsuario` = '" + Usuario.Id + "' AND Fecha BETWEEN @fromDate AND @toDate GROUP BY Fecha;";
                    cmd.Parameters.Add("@fromDate", MySqlDbType.Date).Value = FechaInicio;
                    cmd.Parameters.Add("@toDate", MySqlDbType.Date).Value = FechaFin;
                    var reader = cmd.ExecuteReader();
                    var ListaResultadosVentas = new List<KeyValuePair<DateTime, float>>();
                    while (reader.Read())
                    {
                        ListaResultadosVentas.Add(new KeyValuePair<DateTime, float>((DateTime)reader[0], float.Parse(reader[1].ToString())));
                        TotalIngresos += float.Parse(reader[1].ToString());
                    }
                    reader.Close();
                    reader.Dispose();
                    cmd.Parameters.Clear();

                    //Obtiene los gastos
                    cmd.Connection = conexion;
                    cmd.CommandText = "SELECT Fecha, SUM(Valor) Total FROM `gasto` WHERE `IdUsuario` = '" + Usuario.Id + "' AND Fecha BETWEEN @fromDate AND @toDate GROUP BY Fecha;";
                    cmd.Parameters.Add("@fromDate", MySqlDbType.Date).Value = FechaInicio;
                    cmd.Parameters.Add("@toDate", MySqlDbType.Date).Value = FechaFin;
                    reader = cmd.ExecuteReader();
                    var ListaResultadosGastos = new List<KeyValuePair<DateTime, float>>();
                    while (reader.Read())
                    {
                        ListaResultadosGastos.Add(new KeyValuePair<DateTime, float>((DateTime)reader[0], float.Parse(reader[1].ToString())));
                        TotalGastos += float.Parse(reader[1].ToString());
                    }
                    reader.Close();
                    reader.Dispose();
                    cmd.Parameters.Clear();

                    TotalGanancias = TotalIngresos - TotalGastos;
                    
                    if(NroDias <= 30)
                    {
                        foreach(var item in ListaResultadosVentas)
                        {
                            IngresosBrutos.Add(new IngresosXFecha()
                            {
                                Fecha = item.Key.ToString("dd MMM yyyy"),
                                Monto = item.Value
                            });

                        }
                        foreach (var item in ListaResultadosGastos)
                        {
                            GastosXFecha.Add(new IngresosXFecha()
                            {
                                Fecha = item.Key.ToString("dd MMM yyyy"),
                                Monto = item.Value
                            });

                        }

                    }
                    else if(NroDias <= 92)
                    {
                        IngresosBrutos = (from orderList in ListaResultadosVentas
                                          group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                              orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                          into order
                                          select new IngresosXFecha
                                          {
                                              Fecha = "Semana "+ order.Key.ToString(),
                                              Monto = order.Sum(amount => amount.Value)
                                          }).ToList();
                        GastosXFecha = (from orderList in ListaResultadosGastos
                                        group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                            orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                          into order
                                        select new IngresosXFecha
                                        {
                                            Fecha = "Semana " + order.Key.ToString(),
                                            Monto = order.Sum(amount => amount.Value)
                                        }).ToList();
                    }
                    else if(NroDias <= (365 * 2))
                    {
                        IngresosBrutos = (from orderList in ListaResultadosVentas
                                          group orderList by orderList.Key.ToString("MMM yyyy")
                                          into order
                                          select new IngresosXFecha
                                          {
                                              Fecha = order.Key,
                                              Monto = order.Sum(amount=> amount.Value)
                                          }).ToList();
                        GastosXFecha = (from orderList in ListaResultadosGastos
                                        group orderList by orderList.Key.ToString("MMM yyyy")
                                          into order
                                        select new IngresosXFecha
                                        {
                                            Fecha = order.Key,
                                            Monto = order.Sum(amount => amount.Value)
                                        }).ToList();
                    }
                    else
                    {
                        IngresosBrutos = (from orderList in ListaResultadosVentas
                                          group orderList by orderList.Key.ToString("yyyy")
                                          into order
                                          select new IngresosXFecha
                                          {
                                              Fecha = order.Key,
                                              Monto = order.Sum(amount => amount.Value)
                                          }).ToList();
                        GastosXFecha = (from orderList in ListaResultadosGastos
                                        group orderList by orderList.Key.ToString("yyyy")
                                          into order
                                        select new IngresosXFecha
                                        {
                                            Fecha = order.Key,
                                            Monto = order.Sum(amount => amount.Value)
                                        }).ToList();
                    }
                    
                }
            }
        }
        private void GetAnalisisProductos()
        {
            ProductosMasVendidos = new List<KeyValuePair<string, float>>();
            ProductosBajoStock = new List<KeyValuePair<string, float>>();
            GananciaXProducto = new List<KeyValuePair<string, float>>();
            using (var conexion = GetMySqlConnection())
            {
                conexion.Open();
                using (var cmd = new MySqlCommand())
                {
                    MySqlDataReader reader;
                    cmd.Connection = conexion;

                    cmd.CommandText = @"select p.Descripcion, sum(dv.Cantidad) Cantidad
                                        from `detalleventa` dv
                                        inner join `producto_venta` p on p.`ID.Prod` = dv.`IdProd`
                                        inner join `venta` v on v.`IdVenta` = dv.`IdVenta`
                                        where p.`IdUsuario` = '"+Usuario.Id+@"' AND
                                        v.Fecha between @fromDate and @toDate
                                        group by p.Descripcion 
                                        order by 2 desc
                                        LIMIT 5;";
                    cmd.Parameters.Add("@fromDate", MySqlDbType.Date).Value = FechaInicio;
                    cmd.Parameters.Add("@toDate", MySqlDbType.Date).Value = FechaFin;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductosMasVendidos.Add(new KeyValuePair<string, float>(reader[0].ToString(), float.Parse(reader[1].ToString())));
                    }
                    reader.Close();
                    reader.Dispose();

                    cmd.CommandText = "select Descripcion, Stock from producto_venta where Stock <= 5 and `IdUsuario` = '" + Usuario.Id + "';";
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductosBajoStock.Add(new KeyValuePair<string, float>(reader[0].ToString(), float.Parse(reader[1].ToString())));
                    }
                    reader.Close();
                    reader.Dispose();

                    cmd.CommandText = @"select p.Descripcion, (sum(dv.Subtotal)-(p.CostoUnitario*sum(dv.Cantidad)))
                                        from `detalleventa` dv
                                        inner join `producto_venta` p on p.`ID.Prod` = dv.`IdProd`
                                        inner join `venta` v on v.`IdVenta` = dv.`IdVenta`
                                        where p.`IdUsuario` = '1' AND
                                        v.Fecha between @fromDate and @toDate
                                        group by p.Descripcion 
                                        order by 2 desc;";
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        GananciaXProducto.Add(new KeyValuePair<string, float>(reader[0].ToString(), float.Parse(reader[1].ToString())));
                    }
                }
            }
        }

        public bool LoadData(DateTime FechaInicio, DateTime FechaFin)
        {
            FechaFin = new DateTime(FechaFin.Year, FechaFin.Month, FechaFin.Day, FechaFin.Hour, FechaFin.Minute, 59);
            if(FechaInicio != this.FechaInicio || FechaFin != this.FechaFin)
            {
                this.FechaInicio = FechaInicio;
                this.FechaFin = FechaFin;
                this.NroDias = (FechaFin - FechaInicio).Days;

                GetNroItems();
                GetAnalisisVentas();
                GetAnalisisProductos();
                Console.WriteLine("Datos correctamente actualizados.");
                return true;
            }
            else
            {
                Console.WriteLine("Datos no actualizados.");
                return false;
            }
        }

        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
}
