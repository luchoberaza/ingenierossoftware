using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieros_Commerce_Manager_v2._0.Entities
{
    public class Cliente
    {
        public static int IDCLI { get; set; }
        public static string Nombre { get; set; }
        public static string Direccion { get; set; }
        public static string Telefono { get; set; }
        public static float Saldo { get; set; }

        public static void ClearClientData()
        {
            IDCLI = 0;
            Nombre = null;
            Direccion = null;
            Telefono = null;
            Saldo = 0;
        }
    }
}
