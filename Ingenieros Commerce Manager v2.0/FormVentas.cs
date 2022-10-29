using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
