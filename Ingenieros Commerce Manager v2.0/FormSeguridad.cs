using System;
using System.Windows.Forms;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class FormSeguridad : Form
    {
        public FormSeguridad()
        {
            InitializeComponent();
        }
        SecurityCheck check = new SecurityCheck();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (check.CheckPasswd(txbContra.Texts))
            {
                this.DialogResult = DialogResult.OK;
                txbContra.Texts = "";
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnPWDChar_Click(object sender, EventArgs e)
        {
            if (txbContra.PasswordChar == true)
            {
                txbContra.PasswordChar = false;
                btnPWDChar.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.hidepwd;
            }
            else
            {
                txbContra.PasswordChar = true;
                btnPWDChar.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.showpwd;
            }
        }
    }
}
