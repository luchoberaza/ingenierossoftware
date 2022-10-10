using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Ingenieros_Commerce_Manager_v2._0.Entities;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }
        //Instancia de clase
        conexionsql sql = new conexionsql();



        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta información sera incluida en la facturación generada por el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ImgSelect.ShowDialog();
            if(ImgSelect.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromFile(ImgSelect.FileName);
                    ImgUser.Image = image;
                    byte[] img = File.ReadAllBytes(ImgSelect.FileName);
                    sql.SetUserImg(img, Usuario.Id);
                    MessageBox.Show("Logo modificado correctamente.", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void UpdateForm()
        {
            lblUserID.Text = lblUserID.Text + " " + Usuario.Id;
            txbUsername.Texts = Usuario.Username;
            txbDenom.Texts = Usuario.Denominacion;
            txbRUT.Texts = Usuario.RUT;
            txbTel.Texts = Usuario.Telefono;
            txbDir.Texts = Usuario.Direccion;
            if (Usuario.Foto != null)
            {
                ImgUser.Image = Image.FromStream(Usuario.ByteToImage(Usuario.Foto));
            }

        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
