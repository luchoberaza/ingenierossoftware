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
using Microsoft.VisualStudio.Utilities.Internal;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class FormBuscarCliente : Form
    {
        public FormBuscarCliente()
        {
            InitializeComponent();
        }
        //Instancia de clase
        conexionsql sql = new conexionsql();

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                dgvCliente.DataSource = sql.GetClientes();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach(DataGridViewColumn column in dgvCliente.Columns)
            {
                cmbBusqueda.Items.Add(column.HeaderText);
            }
            cmbBusqueda.TabIndex = 0;
        }
        public void SetCliente()
        {
            Cliente.IDCLI = int.Parse(dgvCliente.CurrentRow.Cells["ID.CLI"].Value.ToString());
            Cliente.Saldo = float.Parse(dgvCliente.CurrentRow.Cells["Saldo"].Value.ToString());
            Cliente.Telefono = dgvCliente.CurrentRow.Cells["Telefono"].Value.ToString();
            Cliente.Direccion = dgvCliente.CurrentRow.Cells["Direccion"].Value.ToString();
            Cliente.Nombre = dgvCliente.CurrentRow.Cells["Nombre"].Value.ToString();
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                SetCliente();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(dgvCliente.SelectedRows.Count > 0)
            {
                SetCliente();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cliente.ClearClientData();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CurrencyManager manager = (CurrencyManager)dgvCliente.BindingContext[dgvCliente.DataSource];
            manager.SuspendBinding();
            string Filter = cmbBusqueda.Texts;
            if(dgvCliente.Rows.Count > 0)
            {
                if (Filter.IsNullOrWhiteSpace() == true)
                {
                    MessageBox.Show("Seleccione un criterio de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (DataGridViewRow row in dgvCliente.Rows)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCliente.Rows)
            {
                row.Visible = true;
            }
            cmbBusqueda.Texts = "";
            txbBuscar.Texts = "";
        }
    }
}
