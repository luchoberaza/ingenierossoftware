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

namespace Ingenieros_Commerce_Manager_v2._0
{
    public class conexionsql
    {
        #region MySQLResources
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=proyecto; Uid=usuario; Pwd=user;");
        MySqlCommand comandos = new MySqlCommand();
        public MySqlDataReader datos;
        protected MySqlDataAdapter adapter;
        #endregion

        #region DataTables
        DataTable DTProd = new DataTable();
        DataTable DTMatPrim = new DataTable();
        DataTable UserData = new DataTable();
        #endregion

        #region Usuario
        public int GetUserID(string username)
        {
            AbrirConexion();
            comandos.CommandText = "SELECT `ID.Usuario` FROM `usuario` WHERE Username = '"+username+"';";
            EjecutarReader();
            datos.Read();
            Usuario.Id = datos.GetInt32("ID.Usuario");
            return Usuario.Id;
        }
        public void SetUserData(int id)
        {
            AbrirConexion();
            CerrarReader();
            adapter = new MySqlDataAdapter("select * from usuario where `usuario`.`ID.Usuario` = '" + id + "';", conexion);
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
            comandos.CommandText = "UPDATE `usuario` SET `Username` = '"+user+"', `Contraseña` = '"+pwrd+"', `Denominacion` = '"+denom+"', `RUT` = '"+RUT+"', `Direccion` = '"+dir+"', `Telefono` = '"+tel+"' WHERE `usuario`.`ID.Usuario` = "+id.ToString()+";";
            comandos.ExecuteNonQuery();
            SetUserData(id);
        }
        #endregion

        #region Clientes
        #endregion

        #region Inventario
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
                datos.Close();
            }
        }
        public void CerrarConexion()
        {
            if(conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        #endregion
    }
}
