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
            dgvClientes.DataSource = sql.GetClientes();
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

    }
}
