using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ingenieros_Commerce_Manager.CustomControls;
using Ingenieros_Commerce_Manager_v2._0.Controls;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public class Module
    {
        public static Form formInicio { get; set; }
        public static Form formContenedor { get; set; }

        public void BtnUpDown(CustomTextBox txb, string operation)
        {
            float num;
            if(!float.TryParse(txb.Texts, out num))
            {
                MessageBox.Show("Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txb.Texts = "0";
                txb.Select();
                return;
            }
            if (operation != "-" | operation != "+")
            {
                return;
            }
            else if(operation == "+")
            {
                txb.Texts = (float.Parse(txb.Texts) + 1).ToString();
                txb.Select();
            }else if(operation == "-")
            {
                txb.Texts = (float.Parse(txb.Texts) - 1).ToString();
                txb.Select();

            }

        }
    }
}
