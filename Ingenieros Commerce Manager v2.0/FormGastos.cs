using Microsoft.VisualStudio.Utilities.Internal;
using System;
using System.Windows.Forms;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class FormGastos : Form
    {
        public FormGastos()
        {
            InitializeComponent();
        }
        //Instancia de clase
        Module module = new Module();
        //Conexion SQL
        conexionsql sql = new conexionsql();
        //Variables;
        bool editar;
        string id;
        //Método borrar textboxs
        public void ClearTextBoxs()
        {
            txbValorGastos.Texts = "";
            txbConceptoGastos.Texts = "";
            txbFechaGastos.Texts = "";
        }
        private void FormGastos_Load(object sender, EventArgs e)
        {
            txbFechaGastos.Texts = DateTime.Now.ToString("dd/MM/yyyy");
            try
            {
                dgvGastos.DataSource = sql.GetGastos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewColumn column in dgvGastos.Columns)
            {
                cmbBusqueda.Items.Add(column.HeaderText);
            }
            cmbBusqueda.Texts = "Concepto";
        }

        private void btnIngresoGastos_Click(object sender, EventArgs e)
        {
            if (txbValorGastos.Texts.Trim() != "" && txbFechaGastos.Texts.Trim() != "" && txbConceptoGastos.Texts.Trim() != "")
            {

                try
                {
                    if (editar == true)
                    {
                        sql.ActualizarGasto(txbValorGastos.Texts, txbFechaGastos.Texts, txbConceptoGastos.Texts, cmbTipo.Texts, id);
                        editar = false;
                    }
                    else
                    {
                        sql.InsertarGasto(txbValorGastos.Texts, txbFechaGastos.Texts, txbConceptoGastos.Texts, cmbTipo.Texts);
                    }
                    dgvGastos.DataSource = sql.GetGastos();
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

        private void btnEditarGastos_Click(object sender, EventArgs e)
        {
            if (dgvGastos.SelectedRows.Count > 0)
            {

                txbConceptoGastos.Texts = dgvGastos.CurrentRow.Cells["Concepto"].Value.ToString();
                txbFechaGastos.Texts = dgvGastos.CurrentRow.Cells["Fecha"].Value.ToString();
                txbValorGastos.Texts = dgvGastos.CurrentRow.Cells["Valor"].Value.ToString();
                cmbTipo.Texts = dgvGastos.CurrentRow.Cells["Tipo"].Value.ToString();
                editar = true;

            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarGastos_Click(object sender, EventArgs e)
        {
            if (dgvGastos.SelectedRows.Count > 0)
            {
                var respuesta = MessageBox.Show("¿Desea eliminar los elementos seleccionados? Esta acción no puede revertirse", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {

                    try
                    {
                        sql.EliminarGasto(int.Parse(id));

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
            dgvGastos.DataSource = sql.GetGastos();
            ClearTextBoxs();
        }

        private void dgvGastos_Click(object sender, EventArgs e)
        {
            if (dgvGastos.SelectedRows.Count > 0)
            {
                if (id == null)
                {
                    id = dgvGastos.CurrentRow.Cells["IdGasto"].Value.ToString();

                }
                else if (!(id.Contains(dgvGastos.CurrentRow.Cells["IdGasto"].Value.ToString())))
                {
                    id = id + ", " + dgvGastos.CurrentRow.Cells["IdGasto"].Value.ToString();
                }

            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            txbFechaGastos.Texts = dtpFecha.Value.ToString("dd/MM/yyyy");
            txbFechaGastos.Select();
        }

        private void btnDeseleccionar_Click(object sender, EventArgs e)
        {
            dgvGastos.ClearSelection();
            id = null;
            ClearTextBoxs();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbBuscar.Texts = "";
            foreach (DataGridViewRow row in dgvGastos.Rows)
            {
                row.Visible = true;
            }
            cmbBusqueda.Texts = "";
        }

        private void txbBuscar__TextChanged(object sender, EventArgs e)
        {
            CurrencyManager manager = (CurrencyManager)dgvGastos.BindingContext[dgvGastos.DataSource];
            manager.SuspendBinding();
            string Filter = cmbBusqueda.Texts;
            if (dgvGastos.Rows.Count > 0)
            {
                if (Filter.IsNullOrWhiteSpace() == true)
                {
                    MessageBox.Show("Seleccione un criterio de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (DataGridViewRow row in dgvGastos.Rows)
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

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txbValorGastos.Texts, out float num))
            {
                MessageBox.Show("Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbValorGastos.Texts = "0";
                txbValorGastos.Select();
                return;
            }
            txbValorGastos.Texts = (num - 1).ToString();
            txbValorGastos.Select();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txbValorGastos.Texts, out float num))
            {
                MessageBox.Show("Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbValorGastos.Texts = "0";
                txbValorGastos.Select();
                return;
            }
            txbValorGastos.Texts = (num + 1).ToString();
            txbValorGastos.Select();

        }
    }
}
