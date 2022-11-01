﻿using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.Remoting.Messaging;
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
        //Variables 
        int pago;


        private void FormVentas_Load(object sender, EventArgs e)
        {
            txbFecha.Texts = DateTime.Now.ToString("dd/MM/yyyy");
            txbCantidad.Texts = "0";
            txbIDProd.Texts = "0";
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            txbCantidad.Texts = (float.Parse(txbCantidad.Texts) + 1).ToString();
            txbCantidad.Select();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            txbCantidad.Texts = (float.Parse(txbCantidad.Texts) - 1).ToString();
            txbCantidad.Select();
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
            int precio;
            bool prodexiste = false; 
            if(txbIDProd.Texts.Trim() == "" | txbProd.Texts.Trim() == "" | txbCantidad.Texts.Trim() == "" | txbPrecio.Texts.Trim() == "")
            {
                MessageBox.Show("Seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbIDProd.Select();
                return;
            }
            if (float.Parse(txbCantidad.Texts) > float.Parse(txbStock.Texts))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbCantidad.Select();
                return;
            }
            if (!int.TryParse(txbPrecio.Texts, out precio))
            {
                MessageBox.Show("Formato de precio incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecio.Select();
                return;
            }
            if (int.Parse(txbIDProd.Texts) == 0)
            {
                MessageBox.Show("Seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbIDProd.Select();
                return;
            }
            foreach(DataGridViewRow row in dgvVenta.Rows)
            {
                if (row.Cells["IDProducto"].Value.ToString() == txbIDProd.Texts)
                {
                    prodexiste = true;
                    break;
                }
            }
            if (!prodexiste)
            {
                dgvVenta.Rows.Add(
                    new object[] 
                    {
                        txbIDProd.Texts,
                        txbProd.Texts,
                        txbCantidad.Texts,
                        precio.ToString(),
                        (float.Parse(txbCantidad.Texts)*precio).ToString()
                    });
                sql.RestarStock(int.Parse(txbIDProd.Texts), float.Parse(txbCantidad.Texts));
            }
            else
            {
                MessageBox.Show("El producto ya ha sido seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbIDProd.Select();
            }
            CalcularTotal();
            ClearProducts();
            txbIDProd.Texts = "0";
            txbIDProd.Select();
        }

        private void CalcularTotal()
        {
            if(dgvVenta.Rows.Count > 0)
            {
                float total = 0;
                foreach(DataGridViewRow row in dgvVenta.Rows)
                {
                    total = total + float.Parse(row.Cells["SubTotal"].Value.ToString());
                }
                txbTotal.Texts = total.ToString("0.00");
            }
        }
        private void ClearProducts()
        {
            txbIDProd.Texts = "";
            txbProd.Texts = "";
            txbPrecio.Texts = "";
            txbStock.Texts = "";
            txbCantidad.Texts = "0";
        }

        private void dgvVenta_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if(e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.trash24.Width;
                var h = Properties.Resources.trash24.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.trash24, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVenta.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    sql.SumarStock
                        (
                        int.Parse(dgvVenta.Rows[index].Cells["IDProducto"].Value.ToString()),
                        float.Parse(dgvVenta.Rows[index].Cells["Cantidad"].Value.ToString())
                        );
                    dgvVenta.Rows.RemoveAt(index);
                    CalcularTotal();
                }
            }
        }
        private void CalcularCambio()
        {
            if(txbPaga.Texts.Length == 0)
            {
                return;
            }
            if (!int.TryParse(txbPaga.Texts, out pago))
            {
                MessageBox.Show("Formato incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txbTotal.Texts.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            txbCambio.Texts = (pago - float.Parse(txbTotal.Texts)).ToString();
        }

        private void txbPaga__TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void txbTotal__TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

    }
}
