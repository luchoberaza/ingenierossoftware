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

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        //Instancia de clase
        conexionsql conexionsql = new conexionsql();


        #region Controles y movimiento de ventana
        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        //Metodo para abrir formularios dentro del panel
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario = panelPrincipal.Controls.OfType<MiForm>().FirstOrDefault(); //Busca el formulario
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(formulario);
                panelPrincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        #region Menu lateral
        private void btnVentas_Click(object sender, EventArgs e)
        {
            #region Coloreado de fuente
            btnVentas.ForeColor = Color.FromArgb(6, 22, 204);
            btnGastos.ForeColor = Color.FromArgb(130, 136, 152);
            btnPagos.ForeColor = Color.FromArgb(130, 136, 152);
            btnInventario.ForeColor = Color.FromArgb(130, 136, 152);
            btnResumen.ForeColor = Color.FromArgb(130, 136, 152);
            #endregion
            AbrirFormulario<FormVentas>();

        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            #region Coloreado de fuente
            btnGastos.ForeColor = Color.FromArgb(6, 22, 204);
            btnVentas.ForeColor = Color.FromArgb(130, 136, 152);
            btnPagos.ForeColor = Color.FromArgb(130, 136, 152);
            btnInventario.ForeColor = Color.FromArgb(130, 136, 152);
            btnResumen.ForeColor = Color.FromArgb(130, 136, 152);
            #endregion
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            #region Coloreado de fuente
            btnPagos.ForeColor = Color.FromArgb(6, 22, 204);
            btnGastos.ForeColor = Color.FromArgb(130, 136, 152);
            btnVentas.ForeColor = Color.FromArgb(130, 136, 152);
            btnInventario.ForeColor = Color.FromArgb(130, 136, 152);
            btnResumen.ForeColor = Color.FromArgb(130, 136, 152);
            #endregion
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            #region Coloreado de fuente
            btnInventario.ForeColor = Color.FromArgb(6, 22, 204);
            btnGastos.ForeColor = Color.FromArgb(130, 136, 152);
            btnPagos.ForeColor = Color.FromArgb(130, 136, 152);
            btnVentas.ForeColor = Color.FromArgb(130, 136, 152);
            btnResumen.ForeColor = Color.FromArgb(130, 136, 152);
            #endregion
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            #region Coloreado de fuente
            btnResumen.ForeColor = Color.FromArgb(6, 22, 204);
            btnGastos.ForeColor = Color.FromArgb(130, 136, 152);
            btnPagos.ForeColor = Color.FromArgb(130, 136, 152);
            btnInventario.ForeColor = Color.FromArgb(130, 136, 152);
            btnVentas.ForeColor = Color.FromArgb(130, 136, 152);
            #endregion

        }
        #endregion
    }
}
