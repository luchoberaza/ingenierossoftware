namespace Ingenieros_Commerce_Manager_v2._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.BotonHide = new System.Windows.Forms.PictureBox();
            this.BotonMinMax = new System.Windows.Forms.PictureBox();
            this.BotonCerrar = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.RedondeoForm = new Ingenieros_Commerce_Manager_v2._0.Components.EllipseComponent();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Titulo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            this.panelHeader.Controls.Add(this.BotonHide);
            this.panelHeader.Controls.Add(this.BotonMinMax);
            this.panelHeader.Controls.Add(this.BotonCerrar);
            this.panelHeader.Controls.Add(this.Titulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 40);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // BotonHide
            // 
            this.BotonHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonHide.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.Hide;
            this.BotonHide.Location = new System.Drawing.Point(894, 23);
            this.BotonHide.Name = "BotonHide";
            this.BotonHide.Size = new System.Drawing.Size(25, 10);
            this.BotonHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonHide.TabIndex = 3;
            this.BotonHide.TabStop = false;
            this.BotonHide.Click += new System.EventHandler(this.BotonHide_Click);
            // 
            // BotonMinMax
            // 
            this.BotonMinMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMinMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonMinMax.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.Minimize_Maximize;
            this.BotonMinMax.Location = new System.Drawing.Point(926, 8);
            this.BotonMinMax.Name = "BotonMinMax";
            this.BotonMinMax.Size = new System.Drawing.Size(25, 25);
            this.BotonMinMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonMinMax.TabIndex = 2;
            this.BotonMinMax.TabStop = false;
            this.BotonMinMax.Click += new System.EventHandler(this.BotonMinMax_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCerrar.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.Cerrar;
            this.BotonCerrar.Location = new System.Drawing.Point(961, 8);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(25, 25);
            this.BotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonCerrar.TabIndex = 1;
            this.BotonCerrar.TabStop = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // Titulo
            // 
            this.Titulo.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.T_itulo;
            this.Titulo.Location = new System.Drawing.Point(8, 2);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(370, 37);
            this.Titulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Titulo.TabIndex = 0;
            this.Titulo.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.panelMenu.Controls.Add(this.btnUsuario);
            this.panelMenu.Controls.Add(this.btnPagos);
            this.panelMenu.Controls.Add(this.btnResumen);
            this.panelMenu.Controls.Add(this.btnGastos);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 610);
            this.panelMenu.TabIndex = 1;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnUsuario.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.usuario24;
            this.btnUsuario.Location = new System.Drawing.Point(0, 366);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(230, 72);
            this.btnUsuario.TabIndex = 13;
            this.btnUsuario.Text = "usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.btnPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnPagos.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.pagos24;
            this.btnPagos.Location = new System.Drawing.Point(0, 144);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(230, 72);
            this.btnPagos.TabIndex = 9;
            this.btnPagos.Text = "clientes";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnResumen
            // 
            this.btnResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.btnResumen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResumen.FlatAppearance.BorderSize = 0;
            this.btnResumen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumen.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnResumen.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.resumen24;
            this.btnResumen.Location = new System.Drawing.Point(0, 288);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(230, 72);
            this.btnResumen.TabIndex = 12;
            this.btnResumen.Text = "resumen";
            this.btnResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResumen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResumen.UseVisualStyleBackColor = false;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.btnGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGastos.FlatAppearance.BorderSize = 0;
            this.btnGastos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastos.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnGastos.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.gasto24;
            this.btnGastos.Location = new System.Drawing.Point(0, 72);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(230, 72);
            this.btnGastos.TabIndex = 11;
            this.btnGastos.Text = "gastos";
            this.btnGastos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGastos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGastos.UseVisualStyleBackColor = false;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnInventario.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.inevntario24;
            this.btnInventario.Location = new System.Drawing.Point(0, 216);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(230, 72);
            this.btnInventario.TabIndex = 10;
            this.btnInventario.Text = "inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnVentas.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.venta24;
            this.btnVentas.Location = new System.Drawing.Point(0, 0);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(230, 72);
            this.btnVentas.TabIndex = 8;
            this.btnVentas.Text = "ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.panelPrincipal.Location = new System.Drawing.Point(230, 40);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(770, 610);
            this.panelPrincipal.TabIndex = 2;
            // 
            // RedondeoForm
            // 
            this.RedondeoForm.CornerRadius = 30;
            this.RedondeoForm.TargetControl = this;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelPrincipal);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelHeader);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1000, 650);
            this.panelContenedor.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotonHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Titulo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.EllipseComponent RedondeoForm;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox Titulo;
        private System.Windows.Forms.PictureBox BotonCerrar;
        private System.Windows.Forms.PictureBox BotonMinMax;
        private System.Windows.Forms.PictureBox BotonHide;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnUsuario;
    }
}

