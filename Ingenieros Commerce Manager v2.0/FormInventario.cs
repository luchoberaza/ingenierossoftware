using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualStudio.Utilities.Internal;
using Ingenieros_Commerce_Manager_v2._0.Entities;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class FormInventario : Form
    {
        //Instancia de clase
        conexionsql sql = new conexionsql();
        //Variables
        private string idprod = null, idmat = null;
        private bool editar = false;
        public FormInventario()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarProductos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewColumn column in dgvProductos.Columns)
            {
                cmbBusqueda.Items.Add(column.HeaderText);
            }
            foreach (DataGridViewColumn column in dgvMatPrim.Columns)
            {
                if(column.HeaderText != "Descripcion" && column.HeaderText != "Stock")
                {
                    cmbBusqueda.Items.Add(column.HeaderText);
                }
            }
            cmbBusqueda.Texts = "Descripcion";
            txbStock.Texts = "0";
        }
        private void MostrarProductos()
        {
            dgvProductos.DataSource = sql.MostrarDTProd();
            dgvMatPrim.DataSource = sql.MostrarDTMatPrim();
            dgvProductos.Refresh();
            dgvMatPrim.Refresh();
        }
        
        private void RemovePlaceHolders()
        {
            txbDescrip.RemovePlaceholder();
            txbPrecio.RemovePlaceholder();
            txbStock.RemovePlaceholder();
        }
        private void ClearTextBoxs()
        {
            txbStock.Texts = "";
            txbPrecio.Texts = "";
            txbDescrip.Texts = "";
            dgvMatPrim.ClearSelection();
            dgvProductos.ClearSelection();
            idprod = null;
            idmat = null;
        }
        private void dgvMatPrim_Click(object sender, EventArgs e)
        {

            if (dgvMatPrim.SelectedRows.Count > 0)
            {
                dgvProductos.ClearSelection();
                if (idmat == null)
                {
                    idmat = dgvMatPrim.CurrentRow.Cells["ID.Mat"].Value.ToString();

                }
                else if (!(idmat.Contains(dgvMatPrim.CurrentRow.Cells["ID.Mat"].Value.ToString())))
                {
                    idmat = idmat + ", " + dgvMatPrim.CurrentRow.Cells["ID.Mat"].Value.ToString();
                }

            }
            cmbTipo.Texts = "Materia Prima";
        }
        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (txbPrecio.Texts.Trim() != "" && txbStock.Texts.Trim() != "" && txbDescrip.Texts.Trim() != "" && cmbTipo.Texts.Trim() != "")
            {
                if (cmbTipo.Texts == "Producto en Venta")
                {
                    try
                    {
                        if (editar == true)
                        {
                            sql.UpdateProd(txbStock.Texts, txbDescrip.Texts, txbPrecio.Texts, idprod);
                            editar = false;
                        }
                        else
                        {
                            sql.InsertarProd(txbStock.Texts, txbDescrip.Texts, txbPrecio.Texts);
                        }
                        MostrarProductos();
                        MessageBox.Show("Datos ingresados correctamente", "Acción realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxs();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cmbTipo.Texts == "Materia Prima")
                {
                    try
                    {
                        if (editar == true)
                        {
                            sql.UpdateMatPrim(txbStock.Texts, txbDescrip.Texts, txbPrecio.Texts, idmat);
                            editar = false;
                        }
                        else
                        {
                            sql.InsertarMatPrim(txbStock.Texts, txbDescrip.Texts, txbPrecio.Texts);
                        }
                        MostrarProductos();
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
                    MessageBox.Show("Ingrese un tipo válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMatPrim.SelectedRows.Count > 0)
            {
                RemovePlaceHolders();
                txbDescrip.Texts = dgvMatPrim.CurrentRow.Cells["Descripcion"].Value.ToString();
                txbStock.Texts = dgvMatPrim.CurrentRow.Cells["Stock"].Value.ToString();
                txbPrecio.Texts = dgvMatPrim.CurrentRow.Cells["Costo"].Value.ToString();
                cmbTipo.Texts = "Materia Prima";
                editar = true;

            }
            else if (dgvProductos.SelectedRows.Count > 0)
            {
                RemovePlaceHolders();
                txbPrecio.Texts = dgvProductos.CurrentRow.Cells["PrecioUnitario"].Value.ToString();
                txbDescrip.Texts = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txbStock.Texts = dgvProductos.CurrentRow.Cells["Stock"].Value.ToString();
                cmbTipo.Texts = "Producto en Venta";
                editar = true;

            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (dgvMatPrim.SelectedRows.Count > 0)
            {
                var respuesta = MessageBox.Show("¿Desea eliminar los elementos seleccionados? Esta acción no puede revertirse", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {

                    try
                    {
                        sql.EliminarMatPrim(idmat);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else if (dgvProductos.SelectedRows.Count > 0)
            {
                var respuesta = MessageBox.Show("¿Desea eliminar los elementos seleccionados? Esta acción no puede revertirse", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        sql.EliminarProd(idprod);
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
            MostrarProductos();
            ClearTextBoxs();
        }

        private void btnDeseleccionar_Click(object sender, EventArgs e)
        {
            dgvProductos.ClearSelection();
            dgvMatPrim.ClearSelection();
            idmat = null;
            idprod = null;
            editar = false;
            ClearTextBoxs();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbBuscar.Texts = "";
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                row.Visible = true;
            }
            foreach (DataGridViewRow row in dgvMatPrim.Rows)
            {
                row.Visible = true;
            }
            cmbBusqueda.Texts = "";
        }

        private void txbBuscar__TextChanged(object sender, EventArgs e)
        {
            BusquedaCompleta();
        }
        private void Buscar(DataGridView dgv, string Filter)
        {
            foreach (DataGridViewRow row in dgv.Rows)
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
        private void BusquedaCompleta()
        {
            CurrencyManager manager = (CurrencyManager)dgvProductos.BindingContext[dgvProductos.DataSource];
            CurrencyManager manager1 = (CurrencyManager)dgvMatPrim.BindingContext[dgvMatPrim.DataSource];
            manager.SuspendBinding();
            manager1.SuspendBinding();
            string Filter = cmbBusqueda.Texts;
            if (dgvProductos.Rows.Count > 0 | dgvMatPrim.Rows.Count > 0)
            {
                if (Filter.IsNullOrWhiteSpace() == true)
                {
                    MessageBox.Show("Seleccione un criterio de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Filter == "ID.Prod" | Filter == "PrecioUnitario")
                    {
                        Buscar(dgvProductos, Filter);
                        foreach (DataGridViewRow row in dgvMatPrim.Rows)
                        {
                            row.Visible = false;
                        }
                    }
                    else if (Filter == "ID.Mat" | Filter == "Costo")
                    {
                        Buscar(dgvMatPrim, Filter);
                        foreach (DataGridViewRow row in dgvProductos.Rows)
                        {
                            row.Visible = false;
                        }
                    }
                    else
                    {
                        Buscar(dgvProductos, Filter);
                        Buscar(dgvMatPrim, Filter);
                    }
                }
            }
            manager.ResumeBinding();
            manager1.ResumeBinding();
        }

        private void cmbBusqueda_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            BusquedaCompleta();
        }

        private void btnUsar_Click(object sender, EventArgs e)
        {
            MateriaPrima.Descripcion = dgvMatPrim.CurrentRow.Cells["Descripcion"].Value.ToString();
            MateriaPrima.Stock = float.Parse(dgvMatPrim.CurrentRow.Cells["Stock"].Value.ToString());
            MateriaPrima.Costo = float.Parse(dgvMatPrim.CurrentRow.Cells["Costo"].Value.ToString());
            MateriaPrima.Id = int.Parse(dgvMatPrim.CurrentRow.Cells["ID.Mat"].Value.ToString());
            FormUsarMatPrim form = new FormUsarMatPrim();
            form.ShowDialog();
            MostrarProductos();
        }

        private void dgvMatPrim_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvMatPrim.SelectedRows.Count == 1)
            {
                btnUsar.Visible = true;
            }
            else
            {
                btnUsar.Visible = false;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            txbStock.Texts = (float.Parse(txbStock.Texts) + 1).ToString();
            txbStock.Select();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            txbStock.Texts = (float.Parse(txbStock.Texts) - 1).ToString();
            txbStock.Select();
        }

        private void dgvProductos_Click(object sender, EventArgs e)
        {
            if(dgvProductos.SelectedRows.Count > 0)
            {
                dgvMatPrim.ClearSelection();
                if(idprod == null)
                {
                    idprod = dgvProductos.CurrentRow.Cells["ID.Prod"].Value.ToString();
                }
                else if (!(idprod.Contains(dgvProductos.CurrentRow.Cells["ID.Prod"].Value.ToString())))
                {
                    idprod =idprod+", "+ dgvProductos.CurrentRow.Cells["ID.Prod"].Value.ToString();

                }
            }
            cmbTipo.Texts = "Producto en Venta";
        }
    }
}
