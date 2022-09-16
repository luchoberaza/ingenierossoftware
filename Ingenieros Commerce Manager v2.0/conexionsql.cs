using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public class conexionsql
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=proyecto; Uid=usuario; Pwd=user;");
        MySqlCommand comandos = new MySqlCommand();
        public MySqlDataReader datos;
        DataTable DTProd = new DataTable();
        DataTable DTMatPrim = new DataTable();

        public DataTable MostrarDTProd()
        {
            AbrirConexion();
            comandos.CommandText = "select * from producto_venta";
            EjecutarReader();
            DTProd.Rows.Clear();
            DTProd.Load(datos);
            return DTProd;
        }
        public DataTable MostrarDTMatPrim()
        {
            AbrirConexion();
            comandos.CommandText = "select * from materia_prima";
            EjecutarReader();
            DTMatPrim.Rows.Clear();
            DTMatPrim.Load(datos);
            return DTMatPrim;
        }
        public void InsertarProd(string stock, string descrip, string precio)
        {
            AbrirConexion();
            comandos.CommandText = "INSERT INTO `producto_venta` (`ID.Prod`, `Stock`, `Descripcion`, `PrecioUnitario`) VALUES (NULL, '"+Double.Parse(stock)+ "', '" +descrip+ "', '" + Double.Parse(precio) + "');";
            comandos.ExecuteNonQuery();
        }
        public void InsertarMatPrim(string stock, string descrip, string costo)
        {
            AbrirConexion();
            comandos.CommandText = "INSERT INTO `materia_prima` (`ID.Mat`, `Costo`, `Descripcion`, `Stock`) VALUES (NULL, '" + Double.Parse(stock) + "', '" + descrip + "', '" + Double.Parse(costo) + "');";
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
            if (datos != null)
            {
                datos.Close();
            }
            datos = comandos.ExecuteReader();
        }
        public void CerrarConexion()
        {
            if(conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
