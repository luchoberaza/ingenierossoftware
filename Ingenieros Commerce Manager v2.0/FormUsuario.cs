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
using Ingenieros_Commerce_Manager_v2._0.Entities;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta información sera incluida en la facturación generada por el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ImgSelect.ShowDialog();
            if(ImgSelect.ShowDialog() == DialogResult.OK)
            {
                byte[] imagen = File.ReadAllBytes(ImgSelect.FileName);

            }

        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

            lblUserID.Text = lblUserID.Text + " " + Usuario.Id;
            txbUsername.Texts = Usuario.Username;
            txbDenom.Texts = Usuario.Denominacion;
            txbRUT.Texts = Usuario.RUT;
            txbTel.Texts = Usuario.Telefono;
            txbDir.Texts = Usuario.Telefono;

        }
    }
}
