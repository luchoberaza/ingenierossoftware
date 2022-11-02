using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieros_Commerce_Manager_v2._0.Entities
{
    public class MateriaPrima
    {
        public static int Id { get; set; }
        public static string Descripcion { get; set; }
        public static float Stock { get; set; }
        public static float Costo { get; set; }

        public static void ClearMatData()
        {
            Id = 0;
            Descripcion = null;
            Stock = 0;
            Costo = 0;
        }

    }
}
