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
        //Conexion SQL
        conexionsql sql = new conexionsql();
        //Variables;
        bool editar;
        string id;
        //Método borrar textboxs
        public void ClearTextBoxs()
        {
            txbValorGastos.Texts = "";
            txbFechaGastos.Texts = "";
            txbConceptoGastos.Texts = "";
        }
        private void FormGastos_Load(object sender, EventArgs e)
        {
            txbValorGastos.Texts = DateTime.Now.ToString("dd/MM/yyyy");
            dgvGastos.DataSource = sql.GetGastos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresoGastos_Click(object sender, EventArgs e)
        {
            if (txbValorGastos.Texts.Trim() != "" && txbFechaGastos.Texts.Trim() != "" && txbConceptoGastos.Texts.Trim() != "")
            {

                try
                {
                    if (editar == true)
                    {
                        sql.ActualizarGasto(txbValorGastos.Texts, txbFechaGastos.Texts, txbConceptoGastos.Texts, id);
                        editar = false;
                    }
                    else
                    {
                        sql.InsertarGasto(txbValorGastos.Texts, txbFechaGastos.Texts, txbConceptoGastos.Texts);
                    }
                    dgvGastos.DataSource = sql.GetClientes();
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
    }
}
