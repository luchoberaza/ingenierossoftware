using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieros_Commerce_Manager_v2._0.Entities
{
    public class Producto
    {
        public static int IDPROD { get; set; }
        public static string Descripcion { get; set; }
        public static int Stock { get; set; }
        public static int PrecioUnitario { get; set; }

        public static void ClearProductData()
        {
            IDPROD = -1;
            Descripcion = null;
            Stock = -1;
            PrecioUnitario = -1;
        }

    }
}
