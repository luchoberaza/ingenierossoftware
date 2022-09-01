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
        public MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=proyecto; Uid=root; Pwd=;");
        public MySqlCommand comandos = new MySqlCommand();
        public MySqlDataReader datos;

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
