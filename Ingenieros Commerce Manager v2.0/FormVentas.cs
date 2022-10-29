using System;
using System.Windows.Forms;
using Ingenieros_Commerce_Manager_v2._0.Entities;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }
        //Instancia de clase
        conexionsql sql = new conexionsql();

        private void FormVentas_Load(object sender, EventArgs e)
        {
            txbFecha.Texts = DateTime.Now.ToString("dd/MM/yyyy");
            txbCantidad.Texts = "0";
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            txbCantidad.Texts = (int.Parse(txbCantidad.Texts) + 1).ToString();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            txbCantidad.Texts = (int.Parse(txbCantidad.Texts) - 1).ToString();

        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            FormBuscarCliente cliente = new FormBuscarCliente();
            cliente.ShowDialog();
            txbNombre.Texts = Cliente.Nombre;
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            FormBuscarProd prod = new FormBuscarProd();
            prod.ShowDialog();
            FillProductInfo();

        }
        private void FillProductInfo()
        {
            txbIDProd.Texts = Producto.IDPROD.ToString();
            txbProd.Texts = Producto.Descripcion;
            txbPrecio.Texts = Producto.PrecioUnitario.ToString();
            txbStock.Texts = Producto.Stock.ToString();
            txbCantidad.Select();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            try
            {
                sql.SetProduct(int.Parse(txbIDProd.Texts));
                FillProductInfo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
