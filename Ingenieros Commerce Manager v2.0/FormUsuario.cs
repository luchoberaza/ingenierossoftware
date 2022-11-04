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
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        //Instancia de clase
        conexionsql sql = new conexionsql();
        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta información sera incluida en la facturación generada por el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void UpdateForm()
        {
            txbUsername.Texts = Usuario.Username;
            txbDenom.Texts = Usuario.Denominacion;
            txbRUT.Texts = Usuario.RUT;
            txbTel.Texts = Usuario.Telefono;
            txbDir.Texts = Usuario.Direccion;
            if (Usuario.Foto != null)
            {
                ImgUser.Image = Image.FromStream(Usuario.ByteToImage(Usuario.Foto));
            }
            else
            {
                ImgUser.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.galeria;
            }
            txbClaveActual.Texts = "";
            txbClaveNueva.Texts = "";

        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            sql.SetUserData(Usuario.Id);
            UpdateForm();
            lblUserID.Text = lblUserID.Text + " " + Usuario.Id;
        }

        private void tbtnCambioClave_CheckedChanged(object sender, EventArgs e)
        {
            if (tbtnCambioClave.Checked == true)
            {
                label6.Visible = true;
                txbClaveNueva.Visible = true;
            }
            else if (tbtnCambioClave.Checked == false)
            {
                label6.Visible = false;
                txbClaveNueva.Visible = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Usuario.ClearData();
            UpdateForm();
            sql.CerrarConexion();
            Module.formInicio.Show();
            Module.formContenedor.Dispose();
            this.Dispose();

        }

        private void btnPWDChar_Click(object sender, EventArgs e)
        {
            if(txbClaveActual.PasswordChar == true && txbClaveNueva.PasswordChar == true)
            {
                txbClaveActual.PasswordChar = false;
                txbClaveNueva.PasswordChar = false;
                btnPWDChar.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.hidepwd;
            }
            else
            {
                txbClaveActual.PasswordChar = true;
                txbClaveNueva.PasswordChar = true;
                btnPWDChar.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.showpwd;
            }
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if (txbClaveActual.Texts.Length == 0)
            {
                MessageBox.Show("Ingrese su contraseña para validar los cambios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txbClaveActual.Texts != Usuario.Password)
                {
                    MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        if (tbtnCambioClave.Checked == true && txbClaveNueva.Texts.Trim() != "")
                        {
                            sql.UpdateUser(
                                txbUsername.Texts,
                                txbClaveNueva.Texts,
                                txbDenom.Texts,
                                txbRUT.Texts,
                                txbDir.Texts,
                                txbTel.Texts,
                                Usuario.Id
                                );
                            sql.SetUserData(Usuario.Id);
                            MessageBox.Show("Datos actualizados correctamente.", "Acción realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateForm();
                        }
                        else if (tbtnCambioClave.Checked == false)
                        {
                            sql.UpdateUser(
                                txbUsername.Texts,
                                Usuario.Password,
                                txbDenom.Texts,
                                txbRUT.Texts,
                                txbDir.Texts,
                                txbTel.Texts,
                                Usuario.Id
                                );
                            sql.SetUserData(Usuario.Id);
                            MessageBox.Show("Datos actualizados correctamente.", "Acción realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateForm();
                        }
                        else if (txbClaveNueva.Texts.Trim() == "")
                        {
                            MessageBox.Show("Complete los campos de contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (ImgSelect.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] img = File.ReadAllBytes(ImgSelect.FileName);
                    sql.SetUserImg(img, Usuario.Id);
                    ImgUser.Image = Image.FromStream(Usuario.ByteToImage(img));
                    Usuario.Foto = img;
                    MessageBox.Show("Logo modificado correctamente.", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
