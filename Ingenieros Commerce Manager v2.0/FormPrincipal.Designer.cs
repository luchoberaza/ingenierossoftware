namespace Ingenieros_Commerce_Manager_v2._0
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.BotonHide = new System.Windows.Forms.PictureBox();
            this.BotonMinMax = new System.Windows.Forms.PictureBox();
            this.BotonCerrar = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.sideBarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelGastos = new System.Windows.Forms.Panel();
            this.btnGastos = new System.Windows.Forms.Button();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.btnPagos = new System.Windows.Forms.Button();
            this.panelInventario = new System.Windows.Forms.Panel();
            this.btnInventario = new System.Windows.Forms.Button();
            this.panelResumen = new System.Windows.Forms.Panel();
            this.btnResumen = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.RedondeoForm = new Ingenieros_Commerce_Manager_v2._0.Components.EllipseComponent();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Titulo)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.sideBarPanel.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelVentas.SuspendLayout();
            this.panelGastos.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.panelInventario.SuspendLayout();
            this.panelResumen.SuspendLayout();
            this.panelUsuario.SuspendLayout();
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
            // panelPrincipal
            // 
            this.panelPrincipal.AllowDrop = true;
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
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.sideBarPanel);
            this.panelContenedor.Controls.Add(this.panelPrincipal);
            this.panelContenedor.Controls.Add(this.panelHeader);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1000, 650);
            this.panelContenedor.TabIndex = 3;
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.sideBarPanel.Controls.Add(this.panelMenu);
            this.sideBarPanel.Controls.Add(this.panelVentas);
            this.sideBarPanel.Controls.Add(this.panelGastos);
            this.sideBarPanel.Controls.Add(this.panelClientes);
            this.sideBarPanel.Controls.Add(this.panelInventario);
            this.sideBarPanel.Controls.Add(this.panelResumen);
            this.sideBarPanel.Controls.Add(this.panelUsuario);
            this.sideBarPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.sideBarPanel.Location = new System.Drawing.Point(0, 40);
            this.sideBarPanel.MaximumSize = new System.Drawing.Size(230, 0);
            this.sideBarPanel.MinimumSize = new System.Drawing.Size(71, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(230, 610);
            this.sideBarPanel.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 72);
            this.panelMenu.TabIndex = 20;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnMenu.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.icons8_menu_24;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(-10, -10);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(250, 92);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "   menú";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelVentas
            // 
            this.panelVentas.Controls.Add(this.btnVentas);
            this.panelVentas.Location = new System.Drawing.Point(0, 72);
            this.panelVentas.Margin = new System.Windows.Forms.Padding(0);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(230, 72);
            this.panelVentas.TabIndex = 14;
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
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(-10, -10);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(250, 92);
            this.btnVentas.TabIndex = 8;
            this.btnVentas.Text = "   ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelGastos
            // 
            this.panelGastos.Controls.Add(this.btnGastos);
            this.panelGastos.Location = new System.Drawing.Point(0, 144);
            this.panelGastos.Margin = new System.Windows.Forms.Padding(0);
            this.panelGastos.Name = "panelGastos";
            this.panelGastos.Size = new System.Drawing.Size(230, 72);
            this.panelGastos.TabIndex = 15;
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
            this.btnGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastos.Location = new System.Drawing.Point(-10, -10);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnGastos.Size = new System.Drawing.Size(250, 92);
            this.btnGastos.TabIndex = 11;
            this.btnGastos.Text = "   gastos";
            this.btnGastos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGastos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGastos.UseVisualStyleBackColor = false;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // panelClientes
            // 
            this.panelClientes.Controls.Add(this.btnPagos);
            this.panelClientes.Location = new System.Drawing.Point(0, 216);
            this.panelClientes.Margin = new System.Windows.Forms.Padding(0);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(230, 72);
            this.panelClientes.TabIndex = 16;
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
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(-10, -10);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPagos.Size = new System.Drawing.Size(250, 92);
            this.btnPagos.TabIndex = 9;
            this.btnPagos.Text = "   clientes";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // panelInventario
            // 
            this.panelInventario.Controls.Add(this.btnInventario);
            this.panelInventario.Location = new System.Drawing.Point(0, 288);
            this.panelInventario.Margin = new System.Windows.Forms.Padding(0);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Size = new System.Drawing.Size(230, 72);
            this.panelInventario.TabIndex = 17;
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
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(-10, -10);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(250, 92);
            this.btnInventario.TabIndex = 10;
            this.btnInventario.Text = "   inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // panelResumen
            // 
            this.panelResumen.Controls.Add(this.btnResumen);
            this.panelResumen.Location = new System.Drawing.Point(0, 360);
            this.panelResumen.Margin = new System.Windows.Forms.Padding(0);
            this.panelResumen.Name = "panelResumen";
            this.panelResumen.Size = new System.Drawing.Size(230, 72);
            this.panelResumen.TabIndex = 18;
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
            this.btnResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResumen.Location = new System.Drawing.Point(-10, -10);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnResumen.Size = new System.Drawing.Size(250, 92);
            this.btnResumen.TabIndex = 12;
            this.btnResumen.Text = "   resumen";
            this.btnResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResumen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResumen.UseVisualStyleBackColor = false;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.btnUsuario);
            this.panelUsuario.Location = new System.Drawing.Point(0, 432);
            this.panelUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(230, 72);
            this.panelUsuario.TabIndex = 19;
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
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(-10, -10);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUsuario.Size = new System.Drawing.Size(250, 92);
            this.btnUsuario.TabIndex = 13;
            this.btnUsuario.Text = "   usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 1;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // RedondeoForm
            // 
            this.RedondeoForm.CornerRadius = 30;
            this.RedondeoForm.TargetControl = this;
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingenieros Commerce Manager";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotonHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Titulo)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.sideBarPanel.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelVentas.ResumeLayout(false);
            this.panelGastos.ResumeLayout(false);
            this.panelClientes.ResumeLayout(false);
            this.panelInventario.ResumeLayout(false);
            this.panelResumen.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.EllipseComponent RedondeoForm;
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
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panelResumen;
        private System.Windows.Forms.Panel panelInventario;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Panel panelGastos;
        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.FlowLayoutPanel sideBarPanel;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}

