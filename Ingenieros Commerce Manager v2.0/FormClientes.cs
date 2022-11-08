using Microsoft.VisualStudio.Utilities.Internal;
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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        //Instancia de clase
        conexionsql sql = new conexionsql();
        //Variables;
        bool editar;
        string id;
        public void ClearTextBoxs()
        {
            customTextBoxNombre.Texts = "";
            customTextBoxDireccion.Texts = "";
            customTextBoxTelefono.Texts = "";
            customTextBoxSaldo.Texts = "";
        }
        private void FormClientes_Load(object sender, EventArgs e)
        {
            try
            {
                dgvClientes.DataSource = sql.GetClientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewColumn column in dgvClientes.Columns)
            {
                cmbBusqueda.Items.Add(column.HeaderText);
            }
            cmbBusqueda.Texts = "Nombre";
        }

        private void rjButtonIngresar_Click(object sender, EventArgs e)
        {
            if (customTextBoxNombre.Texts.Trim() != "" && customTextBoxDireccion.Texts.Trim() != "" && customTextBoxTelefono.Texts.Trim() != "" && customTextBoxSaldo.Texts.Trim() != "")
            {
               
                    try
                    {
                        if (editar == true)
                        {
                            sql.ActualizarCliente(customTextBoxNombre.Texts, customTextBoxDireccion.Texts, customTextBoxTelefono.Texts, float.Parse(customTextBoxSaldo.Texts), id);
                            editar = false;
                        }
                        else
                        {
                            sql.InsertarCliente(customTextBoxNombre.Texts, customTextBoxDireccion.Texts, customTextBoxTelefono.Texts, float.Parse(customTextBoxSaldo.Texts));
                        }
                        dgvClientes.DataSource = sql.GetClientes();
                        MessageBox.Show("Datos ingresados correctamente", "Acción realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxs();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvClientes_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                if (id == null)
                {
                    id = dgvClientes.CurrentRow.Cells["ID.CLI"].Value.ToString();

                }
                else if (!(id.Contains(dgvClientes.CurrentRow.Cells["ID.CLI"].Value.ToString())))
                {
                    id = id + ", " + dgvClientes.CurrentRow.Cells["ID.CLI"].Value.ToString();
                }

            }
        }

        private void rjButtonEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {

                customTextBoxNombre.Texts = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                customTextBoxDireccion.Texts = dgvClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                customTextBoxTelefono.Texts = dgvClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                customTextBoxSaldo.Texts = dgvClientes.CurrentRow.Cells["Saldo"].Value.ToString();
                editar = true;

            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjButtonEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                var respuesta = MessageBox.Show("¿Desea eliminar los elementos seleccionados? Esta acción no puede revertirse", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {

                    try
                    {
                        sql.EliminarCliente(int.Parse(id));

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvClientes.DataSource = sql.GetClientes();
            ClearTextBoxs();

        }

        private void btnDeseleccionar_Click(object sender, EventArgs e)
        {
            dgvClientes.ClearSelection();
            ClearTextBoxs();
            id = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbBuscar.Texts = "";
            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                row.Visible = true;
            }
            cmbBusqueda.Texts = "";
        }

        private void txbBuscar__TextChanged(object sender, EventArgs e)
        {
            CurrencyManager manager = (CurrencyManager)dgvClientes.BindingContext[dgvClientes.DataSource];
            manager.SuspendBinding();
            string Filter = cmbBusqueda.Texts;
            if (dgvClientes.Rows.Count > 0)
            {
                if (Filter.IsNullOrWhiteSpace() == true)
                {
                    MessageBox.Show("Seleccione un criterio de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (DataGridViewRow row in dgvClientes.Rows)
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                dgvClientes.DataSource = sql.GetClientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
