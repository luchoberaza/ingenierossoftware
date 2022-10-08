using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieros_Commerce_Manager_v2._0.Entities
{
    public class Usuario
    {
        public static int Id { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Denominacion { get; set; }
        public static string Direccion { get; set; }
        public static string Telefono { get; set; }
        public static string RUT { get; set; }
        public static byte[] Foto { get; set; }

       
    }
}
