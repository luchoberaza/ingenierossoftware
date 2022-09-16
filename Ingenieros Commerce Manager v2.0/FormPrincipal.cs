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
        private void colorearBoton(Button color, Button gris, Button gris2, Button gris3, Button gris4)
        {
            color.ForeColor = Color.FromArgb(6, 22, 204);
            gris.ForeColor = Color.FromArgb(96, 98, 102);
            gris2.ForeColor = Color.FromArgb(96, 98, 102);
            gris3.ForeColor = Color.FromArgb(96, 98, 102);
            gris4.ForeColor = Color.FromArgb(96, 98, 102);
            if (color == btnVentas)
            {
                btnVentas.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.venta24blue;
                btnGastos.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.gasto24;
                btnPagos.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.pagos24;
                btnInventario.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.inevntario24;
                btnResumen.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.resumen24;
            }
            else if (color == btnGastos)
            {

                btnVentas.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.venta24;
                btnGastos.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.gasto24blue;
                btnPagos.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.pagos24;
                btnInventario.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.inevntario24;
                btnResumen.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.resumen24;
            }
            else if (color == btnPagos)
            {
                btnVentas.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.venta24;
                btnGastos.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.gasto24;
                btnPagos.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.pagos24blue;
                btnInventario.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.inevntario24;
                btnResumen.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.resumen24;
            }
            else if (color == btnInventario)
            {
                btnVentas.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.venta24;
                btnGastos.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.gasto24;
                btnPagos.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.pagos24;
                btnInventario.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.inevntario24blue;
                btnResumen.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.resumen24;
            }
            else if (color == btnResumen)
            {
                btnVentas.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.venta24;
                btnGastos.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.gasto24;
                btnPagos.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.pagos24;
                btnInventario.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.inevntario24;
                btnResumen.Image = Ingenieros_Commerce_Manager_v2._0.Properties.Resources.resumen24blue;
            }
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            colorearBoton(btnVentas, btnPagos, btnGastos, btnInventario, btnResumen);
            AbrirFormulario<FormVentas>();

        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            colorearBoton(btnGastos, btnPagos, btnVentas, btnInventario, btnResumen);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            colorearBoton(btnPagos, btnVentas, btnGastos, btnInventario, btnResumen);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            colorearBoton(btnInventario, btnPagos, btnGastos, btnVentas, btnResumen);
            AbrirFormulario<FormInventario>();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            colorearBoton(btnResumen, btnPagos, btnGastos, btnVentas, btnInventario);
        }
        #endregion
    }
}
