using Ingenieros_Commerce_Manager_v2._0.Entities;
using System;
using System.Windows.Forms;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class FormUsarMatPrim : Form
    {
        public FormUsarMatPrim()
        {
            InitializeComponent();
        }
        conexionsql sql = new conexionsql();
        Module module = new Module();

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

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            txbFecha.Texts = dtpFecha.Value.ToString("dd/MM/yyyy");
            txbFecha.Select();
        }

        private void FormUsarMatPrim_Load(object sender, EventArgs e)
        {
            txbFecha.Texts = DateTime.Now.ToString("dd/MM/yyyy");
            txbCantidad.Texts = "0";
            txbCantidad.Select();
            txbCosto.Texts = MateriaPrima.Costo.ToString();
            txbDescrip.Texts = MateriaPrima.Descripcion;
            txbStock.Texts = MateriaPrima.Stock.ToString();
            lblID.Text = MateriaPrima.Id.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txbFecha.Texts.Trim() == "" | txbCantidad.Texts.Trim() == "")
            {
                MessageBox.Show("Complete TODOS los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbCantidad.Texts.Trim() == "0" | float.Parse(txbCantidad.Texts) > MateriaPrima.Stock)
            {
                MessageBox.Show("Cantidad inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                sql.UsarMatPrim(MateriaPrima.Id, txbFecha.Texts, float.Parse(txbCantidad.Texts));
                MateriaPrima.ClearMatData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MateriaPrima.ClearMatData();
            this.Close();
        }
    }
}
