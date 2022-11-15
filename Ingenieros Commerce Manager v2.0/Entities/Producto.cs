namespace Ingenieros_Commerce_Manager_v2._0.Entities
{
    public class Producto
    {
        public static int IDPROD { get; set; }
        public static string Descripcion { get; set; }
        public static float Stock { get; set; }
        public static float PrecioUnitario { get; set; }
        public static float CostoUnitario { get; set; }

        public static void ClearProductData()
        {
            IDPROD = 0;
            Descripcion = null;
            Stock = -1;
            PrecioUnitario = -1;
            CostoUnitario = 0;
        }

    }
}
