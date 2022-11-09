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
                    cmd.CommandText = "SELECT Contraseña from Usuario WHERE AES_DECRYPT(Contraseña, @key) = @Passwd AND `ID.Usuario` = @UserID;";
                    cmd.Parameters.Add("@Passwd", MySqlDbType.VarChar).Value = passwd;
                    cmd.Parameters.Add("@UserID", MySqlDbType.VarChar).Value = Usuario.Id.ToString();
                    cmd.Parameters.AddWithValue("@key", Usuario.key);
                    var reader = cmd.ExecuteReader();
                    return reader.Read();
                }
            }
        }


        public bool LogWEncryptPasswd(string username, string passwd)
        {
            using(var conexion = GetMySqlConnection())
            {
                conexion.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "SELECT Username, Contraseña FROM usuario WHERE BINARY Username = @Username AND AES_DECRYPT(Contraseña, @key) = @Passwd ; ";
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Passwd", passwd);
                    cmd.Parameters.AddWithValue("@key", Usuario.key);
                    var reader = cmd.ExecuteReader();
                    return reader.Read();
                }
            }
            
        }
        public int RegisterWEncrypt(string username, string passwd)
        {
            using (var conexion = GetMySqlConnection())
            {
                conexion.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "INSERT INTO usuario (Username, Contraseña) VALUES (@Username, AES_ENCRYPT(@Passwd, @key));";
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Passwd", passwd);
                    cmd.Parameters.AddWithValue("@key", Usuario.key);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
