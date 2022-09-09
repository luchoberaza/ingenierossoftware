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

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class FormInventario : Form
    {
        //Instancia de clase
        conexionsql sql = new conexionsql();
        //Variables
        private string id = null;
        private bool editar = false;
        public FormInventario()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }
        private void MostrarProductos()
        {
            dgvProductos.DataSource = sql.MostrarDTProd();
            dgvMatPrim.DataSource = sql.MostrarDTMatPrim();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
                if (txbPrecio.Texts.Trim() != "" && txbStock.Texts.Trim() != "" && txbDescrip.Texts.Trim() != "" && cmbTipo.Texts.Trim() != "")
                {
                    if (cmbTipo.Texts == "Producto en Venta")
                    {
                        try
                        {
                            if (editar == true)
                            {
                                sql.UpdateProd(txbStock.Texts, txbDescrip.Texts, txbPrecio.Texts, id);
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
                            if(editar == true)
                            {
                                sql.UpdateMatPrim(txbStock.Texts, txbDescrip.Texts, txbPrecio.Texts, id);
                                editar=false;
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
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMatPrim.SelectedRows.Count > 0)
            {
                RemovePlaceHolders();
                txbDescrip.Texts = dgvMatPrim.CurrentRow.Cells["Descripcion"].Value.ToString();
                txbStock.Texts = dgvMatPrim.CurrentRow.Cells["Stock"].Value.ToString();
                txbPrecio.Texts = dgvMatPrim.CurrentRow.Cells["Costo"].Value.ToString();
                cmbTipo.Texts = "Materia Prima";
                id = dgvMatPrim.CurrentRow.Cells["ID.Mat"].Value.ToString();
                editar = true;

            } else if (dgvProductos.SelectedRows.Count > 0)
            {
                RemovePlaceHolders();
                txbPrecio.Texts = dgvProductos.CurrentRow.Cells["PrecioUnitario"].Value.ToString();
                txbDescrip.Texts = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txbStock.Texts = dgvProductos.CurrentRow.Cells["Stock"].Value.ToString();
                cmbTipo.Texts = "Producto en Venta";
                id=dgvProductos.CurrentRow.Cells["ID.Prod"].Value.ToString();
                editar = true;

            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            cmbTipo.Texts = "";
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMatPrim.SelectedRows.Count > 0)
            {
                id = dgvMatPrim.CurrentRow.Cells["ID.Mat"].Value.ToString();
                var respuesta = MessageBox.Show("¿Desea eliminar los elementos seleccionados? Esta acción no puede revertirse", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {

                    try
                    {
                        sql.EliminarMatPrim(id);
                        MostrarProductos();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (dgvProductos.SelectedRows.Count > 0)
            {
                id = dgvProductos.CurrentRow.Cells["ID.Prod"].Value.ToString();
                var respuesta = MessageBox.Show("¿Desea eliminar los elementos seleccionados? Esta acción no puede revertirse", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        sql.EliminarProd(id);
                        MostrarProductos();

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
        }
    }
}
