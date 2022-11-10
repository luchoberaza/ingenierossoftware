using System;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using Ingenieros_Commerce_Manager_v2._0.Entities;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        //Instancia de clase
        conexionsql sql = new conexionsql();
        Module module = new Module();
        //Variables 
        int pago;


        private void FormVentas_Load(object sender, EventArgs e)
        {
            txbFecha.Texts = DateTime.Now.ToString("dd/MM/yyyy");
            txbCantidad.Texts = "0";
            txbIDProd.Texts = "0";
            txbCambio.Texts = "0";
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txbCantidad.Texts, out float num))
            {
                MessageBox.Show("Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCantidad.Texts = "0";
                txbCantidad.Select();
                return;
            }
            txbCantidad.Texts = (num + 1).ToString();
            txbCantidad.Select();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txbCantidad.Texts, out float num))
            {
                MessageBox.Show("Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCantidad.Texts = "0";
                txbCantidad.Select();
                return;
            }
            txbCantidad.Texts = (num - 1).ToString();
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
            try
            {
                int precio;
                bool prodexiste = false;
                if (txbIDProd.Texts.Trim() == "" | txbProd.Texts.Trim() == "" | txbCantidad.Texts.Trim() == "" | txbPrecio.Texts.Trim() == "")
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
                foreach (DataGridViewRow row in dgvVenta.Rows)
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
                    sql.RestarStock(int.Parse(txbIDProd.Texts), txbCantidad.Texts.Replace(',', '.'));
                }
                else
                {
                    MessageBox.Show("El producto ya ha sido seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txbIDProd.Select();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            CalcularTotal();
            ClearProducts();
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
            txbIDProd.Texts = "0";
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

                e.Graphics.DrawImage(Properties.Resources.trash24, new System.Drawing.Rectangle(x, y, w, h));
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
                    try
                    {
                        sql.SumarStock
                          (
                          int.Parse(dgvVenta.Rows[index].Cells["IDProducto"].Value.ToString()),
                          dgvVenta.Rows[index].Cells["Cantidad"].Value.ToString().Replace(',', '.')
                          );
                    }
                    catch(Exception ex) 
                    { 
                        MessageBox.Show(ex.Message, "Error al conectar+", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    dgvVenta.Rows.RemoveAt(index);
                    CalcularTotal();
                }
            }
        }
        private void CalcularCambio()
        {
            if(txbPaga.Texts.Length == 0)
            {
                txbCambio.Texts = "0";
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
            if(pago < float.Parse(txbTotal.Texts))
            {
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

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            sql.CerrarReader();
            if(dgvVenta.Rows.Count < 1)
            {
                MessageBox.Show("Ingrese productos en la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            DataTable detalle = new DataTable();
            detalle.Columns.Add("IDProducto", typeof(int));
            detalle.Columns.Add("PrecioVenta", typeof(float));
            detalle.Columns.Add("Cantidad", typeof(float));
            detalle.Columns.Add("SubTotal", typeof(float));

            foreach(DataGridViewRow row in dgvVenta.Rows)
            {
                detalle.Rows.Add(new object[]
                {
                    row.Cells["IDProducto"].Value.ToString(),
                    row.Cells["PrecioUnitario"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }
            bool envio = false;
            if (rbtnDomicilio.Checked == true && rbtnLocal.Checked == false)
            {
                envio = true;
            }
            else if(rbtnLocal.Checked == true && rbtnDomicilio.Checked == true)
            {
                envio= false;
            }
            float cambio;
            if (float.TryParse(txbCambio.Texts, out cambio))
            {
                txbCambio.Text = "0";
            }
            else
            {
                cambio= 0;
            }
            int idventa = sql.RegistrarVenta(cmbTipoDoc.Texts, txbFecha.Texts, float.Parse(txbTotal.Texts), envio, cambio, detalle);
            if (idventa != 0)
            {
                var respuesta = MessageBox.Show("Venta Nº:'"+idventa+"' generada \n ¿Desea generar el documento?", "Acción completada", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(respuesta == DialogResult.Yes)
                {
                    SaveFileDialog dialog = new SaveFileDialog();

                    dialog.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
                    dialog.AddExtension = true;
                    dialog.DefaultExt = "pdf";
                    dialog.RestoreDirectory = true;

                    string txthtml = Properties.Resources.Plantilla.ToString();

                    txthtml = txthtml.Replace("@DENOMINACION", Usuario.Denominacion);
                    txthtml = txthtml.Replace("@DIRECCION", Usuario.Direccion);
                    txthtml = txthtml.Replace("@TELEFONO", Usuario.Telefono);
                    txthtml = txthtml.Replace("@RUT", Usuario.RUT);
                    txthtml = txthtml.Replace("@TIPODOCUMENTO", cmbTipoDoc.Texts);
                    txthtml = txthtml.Replace("@IDVENTA", idventa.ToString("000000"));
                    txthtml = txthtml.Replace("@FECHA", txbFecha.Texts);
                    txthtml = txthtml.Replace("@TOTAL", txbTotal.Texts);
                    txthtml = txthtml.Replace("@CLIENTE", txbNombre.Texts);
                    txthtml = txthtml.Replace("@DIRCLI", Cliente.Direccion);

                    string filas = string.Empty;
                    foreach (DataGridViewRow row in dgvVenta.Rows)
                    {
                        sql.SetProduct(int.Parse(row.Cells["IDProducto"].Value.ToString()));
                        filas += "<tr>";
                        filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                        filas += "<td>" + Producto.Descripcion + "</td>";
                        filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                        filas += "</tr>";
                    }
                    txthtml = txthtml.Replace("@FILAS", filas);

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                        {
                            Document pdf = new Document(PageSize.A4, 25, 25, 25, 25);
                            PdfWriter writer = PdfWriter.GetInstance(pdf, fs);
                            pdf.Open();
                            pdf.Add(new Phrase(""));

                            System.Drawing.Image img = System.Drawing.Image.FromStream(Usuario.ByteToImage(Usuario.Foto));
                            var format = img.RawFormat;
                            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(img, format);
                            image.ScaleToFit(80, 80);
                            image.Alignment = iTextSharp.text.Image.UNDERLYING;
                            image.SetAbsolutePosition(pdf.LeftMargin, pdf.Top - 80);
                            pdf.Add(image);

                            using (StringReader sr = new StringReader(txthtml))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdf, sr);
                            }
                            pdf.Close();
                            fs.Close();
                        }
                        System.Diagnostics.Process.Start(dialog.FileName);
                    }
                }
                dgvVenta.Rows.Clear();
                txbNombre.Texts = "";
                CalcularTotal();
                ClearProducts();
                txbPaga.Text = "";
                txbCambio.Texts = "";
            }

        }
    }
}
