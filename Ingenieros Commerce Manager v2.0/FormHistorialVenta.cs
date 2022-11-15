using Ingenieros_Commerce_Manager_v2._0.Entities;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Microsoft.VisualStudio.Utilities.Internal;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class FormHistorialVenta : Form
    {
        public FormHistorialVenta()
        {
            InitializeComponent();
        }
        //Instancia de clase
        conexionsql sql = new conexionsql();
        DataTable DTVentas = new DataTable();
        DataTable InfoVentas = new DataTable();

        private void FormHistorialVenta_Load(object sender, EventArgs e)
        {
            DTVentas = sql.GetVentas();
            dgvVentas.Rows.Clear();
            foreach (DataRow dr in DTVentas.Rows)
            {
                dgvVentas.Rows.Add(new object[]
                {
                    dr["IdVenta"],
                    dr["Cliente"],
                    dr["TipoDocumento"],
                    dr["Fecha"],
                    dr["Importe"],
                    dr["Envio"]
                });
            }
            foreach (DataGridViewColumn column in dgvVentas.Columns)
            {
                if (column.HeaderText != "Facturación")
                    cmbBusqueda.Items.Add(column.Name);
            }
            cmbBusqueda.Texts = "IdVentas";
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.Columns[e.ColumnIndex].Name == "Facturacion")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    SaveFileDialog dialog = new SaveFileDialog();

                    dialog.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
                    dialog.AddExtension = true;
                    dialog.DefaultExt = "pdf";
                    dialog.RestoreDirectory = true;

                    if (!DTVentas.Rows[index]["ID.CLI"].ToString().IsNullOrWhiteSpace())
                    {
                        sql.SetCliente(int.Parse(DTVentas.Rows[index]["ID.CLI"].ToString()));
                    }
                    string txthtml = Properties.Resources.Plantilla.ToString();
                    txthtml = txthtml.Replace("@DENOMINACION", Usuario.Denominacion);
                    txthtml = txthtml.Replace("@DIRECCION", Usuario.Direccion);
                    txthtml = txthtml.Replace("@TELEFONO", Usuario.Telefono);
                    txthtml = txthtml.Replace("@RUT", Usuario.RUT);
                    txthtml = txthtml.Replace("@TIPODOCUMENTO", dgvVentas.Rows[index].Cells["TipoDocumento"].Value.ToString());
                    txthtml = txthtml.Replace("@IDVENTA", int.Parse(dgvVentas.Rows[index].Cells["IdVentas"].Value.ToString()).ToString("000000"));
                    txthtml = txthtml.Replace("@FECHA", dgvVentas.Rows[index].Cells["Fecha"].Value.ToString());
                    txthtml = txthtml.Replace("@TOTAL", dgvVentas.Rows[index].Cells["Importe"].Value.ToString());
                    txthtml = txthtml.Replace("@CLIENTE", dgvVentas.Rows[index].Cells["Cliente"].Value.ToString());
                    txthtml = txthtml.Replace("@DIRCLI", Entities.Cliente.Direccion);

                    string filas = string.Empty;
                    InfoVentas = sql.GetInfoVentas(int.Parse(dgvVentas.Rows[index].Cells["IdVentas"].Value.ToString()));
                    foreach (DataRow row in InfoVentas.Rows)
                    {
                        filas += "<tr>";
                        filas += "<td>" + row["Cantidad"].ToString() + "</td>";
                        filas += "<td>" + row["Producto"].ToString() + "</td>";
                        filas += "<td>" + row["Precio"].ToString() + "</td>";
                        filas += "<td>" + row["SubTotal"].ToString() + "</td>";
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

                            if (Usuario.Foto != null)
                            {
                                System.Drawing.Image img = System.Drawing.Image.FromStream(Usuario.ByteToImage(Usuario.Foto));
                                var format = img.RawFormat;
                                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(img, format);
                                image.ScaleToFit(80, 80);
                                image.Alignment = iTextSharp.text.Image.UNDERLYING;
                                image.SetAbsolutePosition(pdf.LeftMargin, pdf.Top - 80);
                                pdf.Add(image);
                            }

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
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbBuscar.Texts = "";
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                row.Visible = true;
            }
            cmbBusqueda.Texts = "";
        }

        private void txbBuscar__TextChanged(object sender, EventArgs e)
        {
            string Filter = cmbBusqueda.Texts;
            if (dgvVentas.Rows.Count > 0)
            {
                if (Filter.IsNullOrWhiteSpace() == true)
                {
                    MessageBox.Show("Seleccione un criterio de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (DataGridViewRow row in dgvVentas.Rows)
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
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DTVentas = sql.GetVentas();
            dgvVentas.Rows.Clear();
            foreach (DataRow dr in DTVentas.Rows)
            {
                dgvVentas.Rows.Add(new object[]
                {
                    dr["IdVenta"],
                    dr["Cliente"],
                    dr["TipoDocumento"],
                    dr["Fecha"],
                    dr["Importe"],
                    dr["Envio"]
                });
            }
        }
    }
}
