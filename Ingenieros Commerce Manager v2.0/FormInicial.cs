using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using Ingenieros_Commerce_Manager_v2._0.Entities;
using System.IO;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        //Instancia de clase
        conexionsql conexionsql = new conexionsql();
        SecurityCheck check = new SecurityCheck();

        #region Controles y movimiento de ventana
        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            conexionsql.CerrarConexion();
        }
        private void BotonMinMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                RedondeoForm.CornerRadius = 0;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                RedondeoForm.CornerRadius = 30;

            }
        }
        private void BotonHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m) //Metodo para redimensionar
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e) //Dibujar rectangulo inferior
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e) //Interactuar con el rectangulo
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        #endregion

        #region Estetica
        private void lblRegistrarse_MouseHover(object sender, EventArgs e) //Efecto estetico
        {
            lblRegistrarse.Cursor = Cursors.Hand;
            lblRegistrarse.ForeColor = Color.Purple;
        }

        private void lblRegistrarse_MouseLeave(object sender, EventArgs e) //Efecto estetico
        {
            lblRegistrarse.ForeColor = Color.DarkBlue;
        }

        private void btnPWDChar_Click(object sender, EventArgs e) //Muestra o esconde los caracteres de contrasena
        {
            if (txbPasswd.PasswordChar == true && txbConfirm.PasswordChar == true)
            {
                txbPasswd.PasswordChar = false;
                txbConfirm.PasswordChar = false;
                btnPWDChar.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.hidepwd;
            }
            else
            {
                txbPasswd.PasswordChar = true;
                txbConfirm.PasswordChar = true;
                btnPWDChar.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.showpwd;
            }
        }

        private void lblVolver_MouseHover(object sender, EventArgs e) //Efecto estetico
        {
            lblVolver.Cursor = Cursors.Hand;
            lblVolver.ForeColor = Color.Purple;
        }
        private void lblVolver_MouseLeave(object sender, EventArgs e) //Efecto estetico
        {
            lblVolver.ForeColor = Color.DarkBlue;
        }
        #endregion


        #region Botones y formulario de login/registro

        private void btnLogin_Click(object sender, EventArgs e) //Conecta con la base de datos
        {
            if (txbPasswd.Texts.Length == 0 | txbUsuario.Texts.Length == 0)
            {
                MessageBox.Show("Campos de texto vacíos.", "Error",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (check.LogWEncryptPasswd(txbUsuario.Texts, txbPasswd.Texts))
                    {
                        Usuario.Id = conexionsql.GetUserID(txbUsuario.Texts);
                        conexionsql.SetUserData(Usuario.Id);
                        Module.formInicio = this;
                        FormPrincipal formPrincipal = new FormPrincipal();
                        if (btnRecordar.Checked)
                        {
                            TextWriter archivo = new StreamWriter("UserInfo.txt");
                            archivo.WriteLine(txbUsuario.Texts);
                            archivo.WriteLine(txbPasswd.Texts);
                            archivo.Close();
                        }
                        else
                        {
                            if (File.Exists("UserInfo.txt"))
                            {
                                File.Delete("UserInfo.txt");
                            }
                        }
                        formPrincipal.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nError al conectar, intente de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        } 
        private void lblRegistrarse_Click(object sender, EventArgs e) //Muestra la interfaz de registro
        {
            txbConfirm.Visible = true;
            btnRegistrarse.Visible = true;
            btnLogin.Visible = false;
            lblRegistrarse.Visible= false;
            lblVolver.Visible = true;
        }
        private void btnRegistrarse_Click(object sender, EventArgs e) //Se registra en la base de datos
        {
            try
            {
                
                if (txbPasswd.Texts == txbConfirm.Texts)
                {
                    if(check.RegisterWEncrypt(txbUsuario.Texts, txbPasswd.Texts) > 0)
                    {
                        MessageBox.Show("Usted fue registrado con éxito!", "Usuario registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbConfirm.Visible = false;
                        btnRegistrarse.Visible = false;
                        btnLogin.Visible = true;
                        lblRegistrarse.Visible = true;
                        lblVolver.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar, intente de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Las contraseñas no son iguales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Duplicate entry"))
                {
                    MessageBox.Show("El usuario ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lblVolver_Click(object sender, EventArgs e)//Vuelve a la interfaz de inicio de sesion
        {
            lblVolver.Visible = false;
            txbConfirm.Visible = false;
            btnRegistrarse.Visible = false;
            btnLogin.Visible = true;
            lblRegistrarse.Visible = true;

        }

        #endregion


        private void FormInicial_Load(object sender, EventArgs e)
        {
            Usuario.ClearData();
            if(File.Exists("UserInfo.txt"))
            {
                TextReader leer = new StreamReader("UserInfo.txt");
                txbUsuario.RemovePlaceholder();
                txbPasswd.RemovePlaceholder();
                txbUsuario.Texts = leer.ReadLine();
                txbPasswd.Texts = leer.ReadLine();
                btnRecordar.Checked = true;
                leer.Close();
            }
        }
    }
}
