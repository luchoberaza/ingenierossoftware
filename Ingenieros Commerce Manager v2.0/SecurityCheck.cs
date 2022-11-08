using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingenieros_Commerce_Manager_v2._0.Entities;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public class SecurityCheck : conexionsql
    {
        public bool CheckPasswd(string passwd)
        {
            using(var conexion = GetMySqlConnection())
            {
                conexion.Open();
                using(var cmd = new MySqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "SELECT Contraseña from Usuario WHERE Contraseña = @Passwd AND `ID.Usuario` = @UserID;";
                    cmd.Parameters.Add("@Passwd", MySqlDbType.VarChar).Value = passwd;
                    cmd.Parameters.Add("@UserID", MySqlDbType.VarChar).Value = Usuario.Id.ToString();
                    var reader = cmd.ExecuteReader();
                    return reader.Read();
                }
            }
        }
    }
}
