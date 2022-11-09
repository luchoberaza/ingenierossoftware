using Ingenieros_Commerce_Manager_v2._0.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class FormCalcularCosto : Form
    {
        public FormCalcularCosto()
        {
            InitializeComponent();
        }
        //Instancia de clase
        conexionsql sql = new conexionsql();

        float costonuevo;

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txbCantidad.Texts, out float num))
            {
                MessageBox.Show("Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCantidad.Texts = "0";
                txbCantidad.Select();
                return;
            }
            txbCantidad.Texts = (num + 1).ToString();
            txbCantidad.Select();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txbCantidad.Texts, out float num))
            {
                MessageBox.Show("Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCantidad.Texts = "0";
                txbCantidad.Select();
                return;
            }
            txbCantidad.Texts = (num - 1).ToString();
            txbCantidad.Select();
        }

        private void FormCalcularCosto_Load(object sender, EventArgs e)
        {
            lblID.Text = Producto.IDPROD.ToString();
            txbDescrip.Texts = Producto.Descripcion;
            txbStock.Texts = Producto.Stock.ToString();
            txbPrecio.Texts = Producto.PrecioUnitario.ToString();
            txbCostoActual.Texts = Producto.CostoUnitario.ToString();
            txbCantidad.Select();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto.CostoUnitario = costonuevo;
            try
            {
                if (sql.InsertarCostoProd(float.Parse(txbCantidad.Texts), btnGenerar.Checked, float.Parse(txbCostoProduccion.Texts)) > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                }
            }
            catch
            {
                this.DialogResult = DialogResult.Abort;
            }
            this.Close();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Producto.ClearProductData();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txbCantidad.Texts, out float cantidad) | !float.TryParse(txbCostoProduccion.Texts, out float costo))
            {
                MessageBox.Show("Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                costonuevo = costo / cantidad;
                lblCostoCalculado.Text = "Costo calculado:" + costonuevo;
            }
        }
    }
}
