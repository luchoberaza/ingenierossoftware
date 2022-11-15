using Ingenieros_Commerce_Manager_v2._0.Entities;
using Microsoft.VisualStudio.Utilities.Internal;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class FormBuscarProd : Form
    {
        public FormBuscarProd()
        {
            InitializeComponent();
        }
        //Instancia de clase
        conexionsql sql = new conexionsql();

        private void SetProducto()
        {
            Producto.IDPROD = int.Parse(dgvProducto.CurrentRow.Cells["IDProd"].Value.ToString());
            Producto.Descripcion = dgvProducto.CurrentRow.Cells["Descripcion"].Value.ToString();
            Producto.PrecioUnitario = float.Parse(dgvProducto.CurrentRow.Cells["PrecioUnitario"].Value.ToString());
            Producto.Stock = float.Parse(dgvProducto.CurrentRow.Cells["Stock"].Value.ToString());
        }
        private void FormBuscarProd_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable Productos = new DataTable();
                Productos = sql.MostrarDTProd();
                foreach (DataRow row in Productos.Rows)
                {
                    dgvProducto.Rows.Add(new object[]
                    {row["ID.Prod"],
                    row["Descripcion"],
                    row["Stock"],
                    row["PrecioUnitario"]
                    });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataGridViewColumn column in dgvProducto.Columns)
            {
                cmbBusqueda.Items.Add(column.HeaderText);
            }
            cmbBusqueda.Texts = "Descripcion";
        }

        private void dgvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                SetProducto();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                SetProducto();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Producto.ClearProductData();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbBuscar.Texts = "";
            foreach (DataGridViewRow row in dgvProducto.Rows)
            {
                row.Visible = true;
            }
            cmbBusqueda.Texts = "";
        }

        private void txbBuscar__TextChanged(object sender, EventArgs e)
        {
            CurrencyManager manager = (CurrencyManager)dgvProducto.BindingContext[dgvProducto.DataSource];
            manager.SuspendBinding();
            string Filter = cmbBusqueda.Texts;
            if (dgvProducto.Rows.Count > 0)
            {
                if (Filter.IsNullOrWhiteSpace() == true)
                {
                    MessageBox.Show("Seleccione un criterio de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (DataGridViewRow row in dgvProducto.Rows)
                    {
                        if (row.Cells[Filter].Value.ToString().Trim().ToLower().Contains(txbBuscar.Texts.Trim().ToLower()))
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
            manager.ResumeBinding();
        }
    }
}
