using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using Ingenieros_Commerce_Manager_v2._0.Entities;
using Google.Protobuf.WellKnownTypes;
using System.Windows.Documents;
using System.IO;
using System.Windows;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public class conexionsql
    {
        #region MySQLResources
        private readonly MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=proyecto; Uid=usuario; Pwd=user;");
        private MySqlCommand comandos = new MySqlCommand();
        public MySqlDataReader datos;
        protected MySqlDataAdapter adapter;
        #endregion

        #region DataTables
        DataTable DTProd = new DataTable();
        DataTable DTMatPrim = new DataTable();
        DataTable UserData = new DataTable();
        DataTable DTClientes = new DataTable();
        DataTable DTGastos = new DataTable();
        DataTable DTVentas = new DataTable();
        DataTable InfoVentas = new DataTable();
        #endregion

        #region Ventas
        public void RestarStock(int id,  string cantidad)
        {
            AbrirConexion();
            comandos.CommandText = "update `producto_venta` set Stock = Stock - '"+cantidad+"' where `ID.Prod` = '"+id+"' ;";
            comandos.ExecuteNonQuery();

        }
        public void SumarStock(int id, string cantidad)
        {
            AbrirConexion();
            comandos.CommandText = "update `producto_venta` set Stock = Stock + '" + cantidad + "' where `ID.Prod` = '" + id + "' ;";
            comandos.ExecuteNonQuery();

        }
        public DataTable GetVentas()
        {
            CerrarReader();
            AbrirConexion();
            comandos.CommandText = "SELECT `IdVenta`, `ID.CLI`, `Nombre` Cliente, TipoDocumento, CAST(DATE_FORMAT(Fecha, '%e/%c/%Y') as char) Fecha, Importe, IF(`Envio`=1, 'A domicilio', 'Venta en local') Envio FROM `venta`, `cliente` WHERE `venta`.`IDCliente` = `cliente`.`ID.CLI` and `venta`.`IDUsuario` = '" + Usuario.Id + "' ORDER BY IdVenta DESC;";
            EjecutarReader();
            DTVentas.Rows.Clear();
            DTVentas.Load(datos);
            return DTVentas;
        }
        public DataTable GetInfoVentas(int idventa)
        {
            CerrarReader();
            AbrirConexion();
            comandos.CommandText = "SELECT `Descripcion` Producto, `PrecioVenta` Precio, `Cantidad`, `SubTotal` FROM `detalleventa`, `producto_venta` WHERE `detalleventa`.`IdProd` = `producto_venta`.`ID.Prod` AND IdVenta = '"+idventa+"';";
            EjecutarReader();
            InfoVentas.Rows.Clear();
            InfoVentas.Load(datos);
            return InfoVentas;
        }
        public int RegistrarVenta(string TipoDocumento, string Fecha, float Importe, bool Envio, float Cambio, DataTable detalle)
        {
            AbrirConexion();
            CerrarReader();
            try
            {
                comandos.Parameters.AddWithValue("@IdUsuario", Usuario.Id);
                comandos.Parameters.AddWithValue("@TipoDocumento", TipoDocumento);
                if (Cliente.IDCLI > 0)
                {
                    comandos.Parameters.AddWithValue("@IdCliente", Cliente.IDCLI);
                    if (TipoDocumento.Contains("Crédito"))
                    {
                        comandos.CommandText = "UPDATE `cliente` SET `Saldo` = `Saldo` + '"+Importe+"' WHERE `ID.CLI` = '"+ Cliente.IDCLI + "';";
                        comandos.ExecuteNonQuery();
                    }
                }
                else
                {
                    comandos.Parameters.AddWithValue("@IdCliente", DBNull.Value);
                    if (TipoDocumento.Contains("Crédito"))
                    {
                        MessageBox.Show("Debe especificar el cliente para realizar ventas a crédito.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return 0;
                    }
                }
                comandos.Parameters.AddWithValue("@Importe", Importe);
                if (Envio == true)
                {
                    comandos.Parameters.AddWithValue("@Envio", 1);
                }
                else
                {
                    comandos.Parameters.AddWithValue("@Envio", 0);
                }
                comandos.Parameters.AddWithValue("@Cambio", Cambio);
                comandos.CommandText = "insert into venta(`IDUsuario`, `IDCliente`, `TipoDocumento`, `Fecha`, `Importe`, `Envio`, `Cambio`) values (@IdUsuario, @IdCliente, @TipoDocumento, STR_TO_DATE('" + Fecha + "', '%e/%c/%Y'), @Importe, @Envio, @Cambio);";
                comandos.ExecuteNonQuery();
                comandos.Parameters.Clear();
                comandos.CommandText = "SELECT LAST_INSERT_ID();";
                CerrarReader();
                EjecutarReader();
                datos.Read();
                int idventa = datos.GetInt32(0);
                CerrarReader();
                foreach (DataRow row in detalle.Rows)
                {
                    int idprod = Convert.ToInt32(row["IDProducto"]);
                    float precio = float.Parse(row["PrecioVenta"].ToString());
                    float Cantidad = float.Parse(row["Cantidad"].ToString());
                    float SubTotal = float.Parse(row["SubTotal"].ToString());
                    comandos.CommandText = "INSERT into `detalleventa` (`IdVenta`, `IdProd`, `PrecioVenta`, `Cantidad`, `SubTotal`) VALUES ('" + idventa + "', '" + idprod + "', '" + precio + "', '"+Cantidad+"', '"+SubTotal+"')";
                    comandos.ExecuteNonQuery();
                }
                CerrarConexion();
                return idventa;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
            }
        }

        #endregion

        #region Usuario
        public int GetUserID(string username)
        {
            AbrirConexion();
            comandos.CommandText = "SELECT `ID.Usuario` FROM `usuario` WHERE Username = '"+username+"';";
            EjecutarReader();
            datos.Read();
            Usuario.Id = datos.GetInt32("ID.Usuario");
            CerrarReader();
            return Usuario.Id;
        }
        public void SetUserData(int id)
        {
            AbrirConexion();
            CerrarReader();
            adapter = new MySqlDataAdapter("select `ID.Usuario`, `Username`, CAST(AES_DECRYPT(`Contraseña`, '"+Usuario.key+"') AS CHAR), `Denominacion`, `RUT`, `Direccion`, `Telefono`, `Foto` from usuario where `usuario`.`ID.Usuario` = '" + id + "';", conexion);
            adapter.Fill(UserData);
            Usuario.Username = UserData.Rows[0][1].ToString();
            Usuario.Password = UserData.Rows[0][2].ToString();
            Usuario.Denominacion = UserData.Rows[0][3].ToString();
            Usuario.RUT = UserData.Rows[0][4].ToString();
            Usuario.Direccion = UserData.Rows[0][5].ToString();
            Usuario.Telefono = UserData.Rows[0][6].ToString();
            if (UserData.Rows[0][7] != DBNull.Value)
            {
                Usuario.Foto = (UserData.Rows[0][7]) as byte[];
            }
            adapter.Dispose();
        }
        public void SetUserImg(byte[] img, int id)
        {
            AbrirConexion();
            string cadena = "UPDATE `usuario` SET Foto=@imagen WHERE `ID.Usuario`= '"+id.ToString()+"';";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@imagen", img);
            comando.ExecuteNonQuery();
            SetUserData(id);
        }
        public void UpdateUser(string user, string pwrd, string denom, string RUT, string dir, string tel, int id)
        {
            AbrirConexion();
            comandos.CommandText = "UPDATE `usuario` SET `Username` = '"+user+ "', `Contraseña` = AES_ENCRYPT(@Passwd, @key), `Denominacion` = '" + denom+"', `RUT` = '"+RUT+"', `Direccion` = '"+dir+"', `Telefono` = '"+tel+"' WHERE `usuario`.`ID.Usuario` = "+id.ToString()+";";
            comandos.Parameters.AddWithValue("@Passwd", pwrd);
            comandos.Parameters.AddWithValue("@key", Usuario.key);
            comandos.ExecuteNonQuery();
            SetUserData(id);
        }
        #endregion

        #region Gastos
        public DataTable GetGastos()
        {
            AbrirConexion();
            comandos.CommandText = "SELECT IdGasto, Valor, Concepto, Tipo, CAST(DATE_FORMAT(Fecha, '%e/%c/%Y') as char) Fecha from gasto where IdUsuario = '" + Usuario.Id+"';";
            EjecutarReader();
            DTGastos.Rows.Clear();
            DTGastos.Load(datos);
            return DTGastos;
        }
        public void InsertarGasto(string Valor, string Fecha, string Concepto, string Tipo)
        {
            AbrirConexion();
            comandos.CommandText = "INSERT INTO `gasto` (`IdGasto`, `IdUsuario`, `Valor`, `Tipo`, `Concepto`, `Fecha`) VALUES (NULL, '" + Usuario.Id + "', '" + Valor + "', '" + Tipo + "', '" + Concepto + "', STR_TO_DATE('" + Fecha + "', '%e/%c/%Y'));";
            comandos.ExecuteNonQuery();
        }
        public void EliminarGasto(int id)
        {
            AbrirConexion();
            comandos.CommandText = "DELETE FROM `gasto` WHERE `gasto`.`IdGasto` IN (" + id + ") ;";
            comandos.ExecuteNonQuery();

        }
        public void ActualizarGasto(string Valor, string Concepto, string Fecha, string Tipo, string id)
        {
            AbrirConexion();
            comandos.CommandText = "UPDATE `gasto` SET `Valor` = '" + Valor + "', `Concepto` = '" + Concepto + "', `Fecha` = STR_TO_DATE('" + Fecha + "', '%e/%c/%Y'), `Tipo` = '" + Tipo + "' WHERE `gasto`.`IdGasto` IN (" + id + ") ;";
            comandos.ExecuteNonQuery();
        }
        #endregion

        #region Clientes

        public DataTable GetClientes()
        {
            AbrirConexion();
            comandos.CommandText = "SELECT `ID.CLI`, `Nombre`, `Direccion`, `Telefono`, `Saldo` from cliente WHERE IdUsuario = '" + Usuario.Id + "';";
            EjecutarReader();
            DTClientes.Rows.Clear();
            DTClientes.Load(datos);
            return DTClientes;
        }
        public void SetCliente(int idcli)
        {
            AbrirConexion();
            comandos.CommandText = "SELECT `Nombre`, `Direccion`, `Telefono`, `Saldo` from cliente WHERE `ID.CLI`= '"+idcli+"' AND `IdUsuario` = '" + Usuario.Id + "';";
            EjecutarReader();
            DTClientes.Rows.Clear();
            DTClientes.Load(datos);
            Cliente.Nombre = DTClientes.Rows[0]["Nombre"].ToString();
            Cliente.Direccion = DTClientes.Rows[0]["Direccion"].ToString();
            Cliente.Telefono = DTClientes.Rows[0]["Telefono"].ToString();
            Cliente.Saldo = float.Parse(DTClientes.Rows[0]["Saldo"].ToString());
        }
        public void InsertarCliente(string Nombre, string Direccion, string Telefono, float Saldo)
        {
            AbrirConexion();
            comandos.CommandText = "INSERT INTO `cliente` (`ID.CLI`, `IdUsuario`, `Nombre`, `Direccion`, `Telefono`, `Saldo`) VALUES (NULL,'"+Usuario.Id+"', '" +Nombre+ "', '" +Direccion+ "', '" +Telefono+ "', '" +Saldo+ "');";
            comandos.ExecuteNonQuery();
        }
        public void EliminarCliente(int id)
        {
            AbrirConexion();
            comandos.CommandText = "DELETE FROM `cliente` WHERE `cliente`.`ID.CLI` IN (" + id + ") ;";
            comandos.ExecuteNonQuery();

        }
        public void ActualizarCliente(string Nombre, string Direccion, string Telefono, float Saldo, string id)
        {
            AbrirConexion();
            comandos.CommandText = "UPDATE `cliente` SET `Nombre` = '" + Nombre + "', `Direccion` = '" + Direccion + "', `Telefono` = '" + Telefono + "', `Saldo` = '" + Saldo + "' WHERE `cliente`.`ID.CLI` IN (" + id + ") ;";
            comandos.ExecuteNonQuery();
        }

        #endregion

        #region Inventario
        public DataTable MostrarDTProd()
        {
            AbrirConexion();
            comandos.CommandText = "select `ID.Prod`, `PrecioUnitario`, `Descripcion`, `Stock`, `CostoUnitario` from producto_venta WHERE `IdUsuario` = '" + Usuario.Id + "';";
            EjecutarReader();
            DTProd.Rows.Clear();
            DTProd.Load(datos);
            return DTProd;
        }
        public void SetProduct(int id)
        {
            AbrirConexion();
            comandos.CommandText = "select `ID.Prod`, `PrecioUnitario`, `Descripcion`, `Stock`, `CostoUnitario` from producto_venta where `ID.Prod` = " + id + ";";
            EjecutarReader();
            DataTable producto = new DataTable();
            producto.Load(datos);
            Producto.ClearProductData();
            if(producto.Rows.Count > 0)
            {
                Producto.IDPROD = int.Parse(producto.Rows[0][0].ToString());
                Producto.Descripcion = producto.Rows[0][2].ToString();
                Producto.PrecioUnitario = int.Parse(producto.Rows[0][1].ToString());
                Producto.Stock = int.Parse(producto.Rows[0][3].ToString());
                Producto.CostoUnitario = int.Parse(producto.Rows[0][4].ToString());
            }
            else
            {
                MessageBox.Show("No se encontraron datos.", "Error", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
        }
        public DataTable MostrarDTMatPrim()
        {
            AbrirConexion();
            comandos.CommandText = "select `ID.Mat`, `Costo`, `Descripcion`, `Stock` from materia_prima WHERE `IdUsuario` = '"+Usuario.Id+"';";
            EjecutarReader();
            DTMatPrim.Rows.Clear();
            DTMatPrim.Load(datos);
            return DTMatPrim;
        }
        public void InsertarProd(string stock, string descrip, string precio)
        {
            AbrirConexion();
            comandos.CommandText = "INSERT INTO `producto_venta` (`ID.Prod`, `IdUsuario`, `Stock`, `Descripcion`, `PrecioUnitario`) VALUES (NULL, '"+Usuario.Id+"', '"+Double.Parse(stock)+ "', '" +descrip+ "', '" + Double.Parse(precio) + "');";
            comandos.ExecuteNonQuery();
        }
        public void InsertarMatPrim(string stock, string descrip, string costo)
        {
            AbrirConexion();
            comandos.CommandText = "INSERT INTO `materia_prima` (`ID.Mat`, `IdUsuario`, `Costo`, `Descripcion`, `Stock`) VALUES (NULL, '"+Usuario.Id+"', '" + Double.Parse(costo) + "', '" + descrip + "', '" + Double.Parse(stock) + "');";
            comandos.ExecuteNonQuery();
        }
        public void UpdateMatPrim(string stock, string descrip, string costo, string id)
        {
            AbrirConexion();
            comandos.CommandText = "UPDATE `materia_prima` SET `Costo` = '"+double.Parse(costo)+"', `Descripcion` = '"+descrip+"', `Stock` = '"+double.Parse(stock)+"' WHERE `materia_prima`.`ID.Mat` IN ("+id+") ;";
            comandos.ExecuteNonQuery();
        }
        public void UpdateProd(string stock, string descrip, string precio, string id)
        {
            AbrirConexion();
            comandos.CommandText = "UPDATE `producto_venta` SET `PrecioUnitario` = '" + double.Parse(precio) + "', `Descripcion` = '" + descrip + "', `Stock` = '" + double.Parse(stock) + "' WHERE `producto_venta`.`ID.Prod` IN (" + id + ") ;";
            comandos.ExecuteNonQuery();
        }
        public void EliminarProd(string id)
        {
            AbrirConexion();
            comandos.CommandText = "DELETE FROM `producto_venta` WHERE `producto_venta`.`ID.Prod` IN (" + id + ") ;";
            comandos.ExecuteNonQuery();
        }
        public void EliminarMatPrim(string id)
        {
            AbrirConexion();
            comandos.CommandText = "DELETE FROM `materia_prima` WHERE `materia_prima`.`ID.Mat` IN ("+id+") ;";
            comandos.ExecuteNonQuery();

        }
        public void UsarMatPrim(int id, string fecha, float cantidad)
        {
            AbrirConexion();
            comandos.CommandText = "INSERT INTO elaboracion VALUES (NULL, '"+id+"', STR_TO_DATE('"+fecha+"', '%e/%c/%Y'), '"+cantidad+"');";
            comandos.ExecuteNonQuery();
            comandos.CommandText = "UPDATE `materia_prima` SET `Stock` = `Stock` - '"+cantidad+"' WHERE `ID.Mat` = '"+id+"' ";
            comandos.ExecuteNonQuery();
        }
        public int InsertarCostoProd(float cantidad, bool GenerarGasto, float valor)
        {
            AbrirConexion();
            comandos.CommandText = "UPDATE `producto_venta` SET `CostoUnitario` = @costo, `Stock` = `Stock` + @Cantidad WHERE `ID.Prod` = @idprod;";
            comandos.Parameters.Add("@costo", MySqlDbType.Float).Value = Producto.CostoUnitario;
            comandos.Parameters.Add("@idprod", MySqlDbType.Int32).Value = Producto.IDPROD;
            comandos.Parameters.Add("@Cantidad", MySqlDbType.Int32).Value = cantidad;
            int i = comandos.ExecuteNonQuery();
            comandos.Parameters.Clear();
            if (GenerarGasto)
            {
                comandos.CommandText = "insert into gasto (IdUsuario, Valor, Concepto, Fecha, Tipo) values (@IdUsuario, @Valor, 'Produccion de "+Producto.Descripcion+ "', @Fecha, 'Generado automáticamente');";
                comandos.Parameters.Add("@IdUsuario", MySqlDbType.Int32).Value = Usuario.Id;
                comandos.Parameters.Add("@Valor", MySqlDbType.Float).Value = valor;
                comandos.Parameters.Add("@Fecha", MySqlDbType.Date).Value = DateTime.Now.Date;
                i += comandos.ExecuteNonQuery();
            }
            return i;
        }
        #endregion

        #region Gestor de conexion
        public void AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
                comandos.Connection = conexion;
            }
        }
        public void setComandos(string consulta)
        {
            comandos.CommandText = consulta;
        }
        public void EjecutarReader()
        {
            CerrarReader();
            datos = comandos.ExecuteReader();
        }
        public void CerrarReader()
        {
            if (datos != null)
            {
                datos.Dispose();
                datos.Close();
            }
        }
        public void CerrarConexion()
        {
            if(conexion.State == ConnectionState.Open)
            {
                conexion.Dispose();
                conexion.Close();
            }
        }
        protected MySqlConnection GetMySqlConnection()
        {
            return conexion;
        }
        #endregion
    }
}
