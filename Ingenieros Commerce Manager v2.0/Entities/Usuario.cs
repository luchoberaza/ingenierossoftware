using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

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


        public static MemoryStream ByteToImage(byte[] img)
        {
            MemoryStream ms = new MemoryStream();
            if (img != null)
            {
                ms = new MemoryStream(img);
            }
            return ms;
        }
        public static byte[] ImageToByte(Image img)
        {
            MemoryStream ms = new MemoryStream();
            if (img.RawFormat == ImageFormat.Jpeg)
            {
                img.Save(ms, ImageFormat.Jpeg);
            }
            else if (img.RawFormat == ImageFormat.Png)
            {
                img.Save(ms, ImageFormat.Png);
            }
            else if (img.RawFormat == ImageFormat.Bmp)
            {
                img.Save(ms, ImageFormat.Bmp);
            }
            return ms.ToArray();
        }
        public static void ClearData()
        {
            Id = 0;
            Username = null;
            Password = null;
            Direccion = null;
            Denominacion = null;
            Telefono = null;
            RUT = null;
            Foto = null;
        }

    }
}
