namespace Ingenieros_Commerce_Manager_v2._0
{
    partial class FormVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gboxInfoVenta = new System.Windows.Forms.GroupBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gboxInfoCliente = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gboxInfoProductos = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblIDProd = new System.Windows.Forms.Label();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPaga = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.btnCrearVenta = new CustomControls.RJControls.RJButton();
            this.txbCambio = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbPaga = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbTotal = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.btnUp = new CustomControls.RJControls.RJButton();
            this.btnDown = new CustomControls.RJControls.RJButton();
            this.txbCantidad = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbStock = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbPrecio = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.txbProd = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.btnAgregar = new CustomControls.RJControls.RJButton();
            this.txbIDProd = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.btnBuscarCli = new CustomControls.RJControls.RJButton();
            this.txbNombre = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.cmbTipoDoc = new CustomControls.RJControls.RJComboBox();
            this.txbFecha = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.gboxInfoVenta.SuspendLayout();
            this.gboxInfoCliente.SuspendLayout();
            this.gboxInfoProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxInfoVenta
            // 
            this.gboxInfoVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxInfoVenta.Controls.Add(this.lblDocumento);
            this.gboxInfoVenta.Controls.Add(this.lblFecha);
            this.gboxInfoVenta.Controls.Add(this.cmbTipoDoc);
            this.gboxInfoVenta.Controls.Add(this.txbFecha);
            this.gboxInfoVenta.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxInfoVenta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxInfoVenta.Location = new System.Drawing.Point(12, 12);
            this.gboxInfoVenta.Name = "gboxInfoVenta";
            this.gboxInfoVenta.Size = new System.Drawing.Size(379, 143);
            this.gboxInfoVenta.TabIndex = 0;
            this.gboxInfoVenta.TabStop = false;
            this.gboxInfoVenta.Text = "Información de Venta";
            // 
            // lblDocumento
            // 
            this.lblDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDocumento.Location = new System.Drawing.Point(33, 81);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(129, 22);
            this.lblDocumento.TabIndex = 12;
            this.lblDocumento.Text = "Tipo de Documento:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFecha.Location = new System.Drawing.Point(33, 23);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 22);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha:";
            // 
            // gboxInfoCliente
            // 
            this.gboxInfoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxInfoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxInfoCliente.Controls.Add(this.lblNombre);
            this.gboxInfoCliente.Controls.Add(this.btnBuscarCli);
            this.gboxInfoCliente.Controls.Add(this.txbNombre);
            this.gboxInfoCliente.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxInfoCliente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxInfoCliente.Location = new System.Drawing.Point(397, 12);
            this.gboxInfoCliente.Name = "gboxInfoCliente";
            this.gboxInfoCliente.Size = new System.Drawing.Size(361, 143);
            this.gboxInfoCliente.TabIndex = 1;
            this.gboxInfoCliente.TabStop = false;
            this.gboxInfoCliente.Text = "Información del Cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNombre.Location = new System.Drawing.Point(117, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(119, 22);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // gboxInfoProductos
            // 
            this.gboxInfoProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxInfoProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxInfoProductos.Controls.Add(this.btnUp);
            this.gboxInfoProductos.Controls.Add(this.btnDown);
            this.gboxInfoProductos.Controls.Add(this.lblCantidad);
            this.gboxInfoProductos.Controls.Add(this.txbCantidad);
            this.gboxInfoProductos.Controls.Add(this.lblStock);
            this.gboxInfoProductos.Controls.Add(this.txbStock);
            this.gboxInfoProductos.Controls.Add(this.lblPrecio);
            this.gboxInfoProductos.Controls.Add(this.txbPrecio);
            this.gboxInfoProductos.Controls.Add(this.lblProd);
            this.gboxInfoProductos.Controls.Add(this.rjButton1);
            this.gboxInfoProductos.Controls.Add(this.txbProd);
            this.gboxInfoProductos.Controls.Add(this.lblIDProd);
            this.gboxInfoProductos.Controls.Add(this.btnAgregar);
            this.gboxInfoProductos.Controls.Add(this.txbIDProd);
            this.gboxInfoProductos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxInfoProductos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxInfoProductos.Location = new System.Drawing.Point(12, 156);
            this.gboxInfoProductos.Name = "gboxInfoProductos";
            this.gboxInfoProductos.Size = new System.Drawing.Size(746, 143);
            this.gboxInfoProductos.TabIndex = 1;
            this.gboxInfoProductos.TabStop = false;
            this.gboxInfoProductos.Text = "Productos";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCantidad.Location = new System.Drawing.Point(498, 26);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(69, 22);
            this.lblCantidad.TabIndex = 21;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblStock
            // 
            this.lblStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblStock.Location = new System.Drawing.Point(354, 80);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(45, 22);
            this.lblStock.TabIndex = 19;
            this.lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPrecio.Location = new System.Drawing.Point(211, 80);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 22);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblProd
            // 
            this.lblProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProd.Location = new System.Drawing.Point(211, 21);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(67, 22);
            this.lblProd.TabIndex = 13;
            this.lblProd.Text = "Producto:";
            // 
            // lblIDProd
            // 
            this.lblIDProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIDProd.AutoSize = true;
            this.lblIDProd.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProd.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIDProd.Location = new System.Drawing.Point(33, 22);
            this.lblIDProd.Name = "lblIDProd";
            this.lblIDProd.Size = new System.Drawing.Size(81, 22);
            this.lblIDProd.TabIndex = 15;
            this.lblIDProd.Text = "ID Producto:";
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.AllowUserToDeleteRows = false;
            this.dgvVenta.AllowUserToOrderColumns = true;
            this.dgvVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.dgvVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVenta.ColumnHeadersHeight = 25;
            this.dgvVenta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVenta.EnableHeadersVisualStyles = false;
            this.dgvVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            this.dgvVenta.Location = new System.Drawing.Point(12, 302);
            this.dgvVenta.Margin = new System.Windows.Forms.Padding(0);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVenta.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.dgvVenta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVenta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ShowCellErrors = false;
            this.dgvVenta.Size = new System.Drawing.Size(523, 299);
            this.dgvVenta.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTotal.Location = new System.Drawing.Point(554, 306);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(91, 22);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total a Pagar:";
            // 
            // lblPaga
            // 
            this.lblPaga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaga.AutoSize = true;
            this.lblPaga.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaga.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPaga.Location = new System.Drawing.Point(554, 404);
            this.lblPaga.Name = "lblPaga";
            this.lblPaga.Size = new System.Drawing.Size(70, 22);
            this.lblPaga.TabIndex = 7;
            this.lblPaga.Text = "Paga con:";
            // 
            // lblCambio
            // 
            this.lblCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCambio.Location = new System.Drawing.Point(554, 467);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(61, 22);
            this.lblCambio.TabIndex = 8;
            this.lblCambio.Text = "Cambio:";
            // 
            // btnCrearVenta
            // 
            this.btnCrearVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnCrearVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnCrearVenta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCrearVenta.BorderRadius = 15;
            this.btnCrearVenta.BorderSize = 0;
            this.btnCrearVenta.FlatAppearance.BorderSize = 0;
            this.btnCrearVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearVenta.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearVenta.ForeColor = System.Drawing.Color.White;
            this.btnCrearVenta.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.shopping_cart_check;
            this.btnCrearVenta.Location = new System.Drawing.Point(548, 543);
            this.btnCrearVenta.Name = "btnCrearVenta";
            this.btnCrearVenta.Size = new System.Drawing.Size(201, 55);
            this.btnCrearVenta.TabIndex = 9;
            this.btnCrearVenta.Text = "Crear Venta";
            this.btnCrearVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearVenta.TextColor = System.Drawing.Color.White;
            this.btnCrearVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearVenta.UseVisualStyleBackColor = false;
            // 
            // txbCambio
            // 
            this.txbCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbCambio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbCambio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbCambio.BorderRadius = 0;
            this.txbCambio.BorderSize = 2;
            this.txbCambio.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCambio.Location = new System.Drawing.Point(548, 479);
            this.txbCambio.Maxlength = 32767;
            this.txbCambio.Multiline = false;
            this.txbCambio.Name = "txbCambio";
            this.txbCambio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbCambio.PasswordChar = false;
            this.txbCambio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbCambio.PlaceholderText = "";
            this.txbCambio.ReadOnly = true;
            this.txbCambio.Size = new System.Drawing.Size(201, 37);
            this.txbCambio.TabIndex = 5;
            this.txbCambio.Texts = "";
            this.txbCambio.UnderlinedStyle = false;
            // 
            // txbPaga
            // 
            this.txbPaga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPaga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbPaga.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbPaga.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbPaga.BorderRadius = 0;
            this.txbPaga.BorderSize = 2;
            this.txbPaga.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPaga.Location = new System.Drawing.Point(548, 417);
            this.txbPaga.Maxlength = 32767;
            this.txbPaga.Multiline = false;
            this.txbPaga.Name = "txbPaga";
            this.txbPaga.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbPaga.PasswordChar = false;
            this.txbPaga.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPaga.PlaceholderText = "";
            this.txbPaga.ReadOnly = false;
            this.txbPaga.Size = new System.Drawing.Size(201, 37);
            this.txbPaga.TabIndex = 4;
            this.txbPaga.Texts = "";
            this.txbPaga.UnderlinedStyle = false;
            // 
            // txbTotal
            // 
            this.txbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbTotal.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbTotal.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbTotal.BorderRadius = 0;
            this.txbTotal.BorderSize = 2;
            this.txbTotal.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.Location = new System.Drawing.Point(548, 320);
            this.txbTotal.Maxlength = 32767;
            this.txbTotal.Multiline = false;
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbTotal.PasswordChar = false;
            this.txbTotal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbTotal.PlaceholderText = "";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(201, 37);
            this.txbTotal.TabIndex = 3;
            this.txbTotal.Texts = "";
            this.txbTotal.UnderlinedStyle = false;
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnUp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnUp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUp.BorderRadius = 15;
            this.btnUp.BorderSize = 0;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.plus_24;
            this.btnUp.Location = new System.Drawing.Point(543, 83);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(45, 41);
            this.btnUp.TabIndex = 23;
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUp.TextColor = System.Drawing.Color.White;
            this.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnDown.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnDown.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDown.BorderRadius = 15;
            this.btnDown.BorderSize = 0;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.minus24;
            this.btnDown.Location = new System.Drawing.Point(492, 83);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(45, 41);
            this.btnDown.TabIndex = 15;
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDown.TextColor = System.Drawing.Color.White;
            this.btnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // txbCantidad
            // 
            this.txbCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbCantidad.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbCantidad.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbCantidad.BorderRadius = 0;
            this.txbCantidad.BorderSize = 2;
            this.txbCantidad.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad.Location = new System.Drawing.Point(492, 40);
            this.txbCantidad.Maxlength = 32767;
            this.txbCantidad.Multiline = false;
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbCantidad.PasswordChar = false;
            this.txbCantidad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbCantidad.PlaceholderText = "";
            this.txbCantidad.ReadOnly = false;
            this.txbCantidad.Size = new System.Drawing.Size(96, 37);
            this.txbCantidad.TabIndex = 22;
            this.txbCantidad.Texts = "";
            this.txbCantidad.UnderlinedStyle = false;
            // 
            // txbStock
            // 
            this.txbStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbStock.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbStock.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbStock.BorderRadius = 0;
            this.txbStock.BorderSize = 2;
            this.txbStock.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStock.Location = new System.Drawing.Point(344, 94);
            this.txbStock.Maxlength = 32767;
            this.txbStock.Multiline = false;
            this.txbStock.Name = "txbStock";
            this.txbStock.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbStock.PasswordChar = false;
            this.txbStock.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbStock.PlaceholderText = "";
            this.txbStock.ReadOnly = true;
            this.txbStock.Size = new System.Drawing.Size(110, 37);
            this.txbStock.TabIndex = 20;
            this.txbStock.Texts = "";
            this.txbStock.UnderlinedStyle = false;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbPrecio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbPrecio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbPrecio.BorderRadius = 0;
            this.txbPrecio.BorderSize = 2;
            this.txbPrecio.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecio.Location = new System.Drawing.Point(201, 94);
            this.txbPrecio.Maxlength = 32767;
            this.txbPrecio.Multiline = false;
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbPrecio.PasswordChar = false;
            this.txbPrecio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPrecio.PlaceholderText = "";
            this.txbPrecio.ReadOnly = true;
            this.txbPrecio.Size = new System.Drawing.Size(137, 37);
            this.txbPrecio.TabIndex = 18;
            this.txbPrecio.Texts = "";
            this.txbPrecio.UnderlinedStyle = false;
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.search;
            this.rjButton1.Location = new System.Drawing.Point(23, 79);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 55);
            this.rjButton1.TabIndex = 15;
            this.rjButton1.Text = "Buscar";
            this.rjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // txbProd
            // 
            this.txbProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbProd.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbProd.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbProd.BorderRadius = 0;
            this.txbProd.BorderSize = 2;
            this.txbProd.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProd.Location = new System.Drawing.Point(201, 36);
            this.txbProd.Maxlength = 32767;
            this.txbProd.Multiline = false;
            this.txbProd.Name = "txbProd";
            this.txbProd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbProd.PasswordChar = false;
            this.txbProd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbProd.PlaceholderText = "";
            this.txbProd.ReadOnly = true;
            this.txbProd.Size = new System.Drawing.Size(253, 37);
            this.txbProd.TabIndex = 14;
            this.txbProd.Texts = "";
            this.txbProd.UnderlinedStyle = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 15;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.plus;
            this.btnAgregar.Location = new System.Drawing.Point(617, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 93);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txbIDProd
            // 
            this.txbIDProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbIDProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbIDProd.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbIDProd.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbIDProd.BorderRadius = 0;
            this.txbIDProd.BorderSize = 2;
            this.txbIDProd.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDProd.Location = new System.Drawing.Point(23, 36);
            this.txbIDProd.Maxlength = 32767;
            this.txbIDProd.Multiline = false;
            this.txbIDProd.Name = "txbIDProd";
            this.txbIDProd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbIDProd.PasswordChar = false;
            this.txbIDProd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbIDProd.PlaceholderText = "";
            this.txbIDProd.ReadOnly = false;
            this.txbIDProd.Size = new System.Drawing.Size(150, 37);
            this.txbIDProd.TabIndex = 16;
            this.txbIDProd.Texts = "";
            this.txbIDProd.UnderlinedStyle = false;
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnBuscarCli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnBuscarCli.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarCli.BorderRadius = 15;
            this.btnBuscarCli.BorderSize = 0;
            this.btnBuscarCli.FlatAppearance.BorderSize = 0;
            this.btnBuscarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCli.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCli.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCli.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.search;
            this.btnBuscarCli.Location = new System.Drawing.Point(18, 41);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(70, 70);
            this.btnBuscarCli.TabIndex = 11;
            this.btnBuscarCli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarCli.TextColor = System.Drawing.Color.White;
            this.btnBuscarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscarCli.UseVisualStyleBackColor = false;
            this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscarCli_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbNombre.BorderRadius = 0;
            this.txbNombre.BorderSize = 2;
            this.txbNombre.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(107, 59);
            this.txbNombre.Maxlength = 32767;
            this.txbNombre.Multiline = false;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbNombre.PasswordChar = false;
            this.txbNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbNombre.PlaceholderText = "";
            this.txbNombre.ReadOnly = false;
            this.txbNombre.Size = new System.Drawing.Size(234, 37);
            this.txbNombre.TabIndex = 14;
            this.txbNombre.Texts = "";
            this.txbNombre.UnderlinedStyle = false;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTipoDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.cmbTipoDoc.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTipoDoc.BorderSize = 2;
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDoc.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipoDoc.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTipoDoc.Items.AddRange(new object[] {
            "eFactura Contado",
            "eFactura Crédito",
            "eTicket Contado",
            "eTicket Crédito"});
            this.cmbTipoDoc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTipoDoc.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTipoDoc.Location = new System.Drawing.Point(23, 94);
            this.cmbTipoDoc.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Padding = new System.Windows.Forms.Padding(2);
            this.cmbTipoDoc.Size = new System.Drawing.Size(331, 38);
            this.cmbTipoDoc.TabIndex = 11;
            this.cmbTipoDoc.Texts = "";
            // 
            // txbFecha
            // 
            this.txbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbFecha.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbFecha.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbFecha.BorderRadius = 0;
            this.txbFecha.BorderSize = 2;
            this.txbFecha.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFecha.Location = new System.Drawing.Point(23, 37);
            this.txbFecha.Maxlength = 32767;
            this.txbFecha.Multiline = false;
            this.txbFecha.Name = "txbFecha";
            this.txbFecha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbFecha.PasswordChar = false;
            this.txbFecha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbFecha.PlaceholderText = "";
            this.txbFecha.ReadOnly = true;
            this.txbFecha.Size = new System.Drawing.Size(331, 37);
            this.txbFecha.TabIndex = 10;
            this.txbFecha.Texts = "";
            this.txbFecha.UnderlinedStyle = false;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(770, 610);
            this.Controls.Add(this.btnCrearVenta);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lblPaga);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txbCambio);
            this.Controls.Add(this.txbPaga);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.gboxInfoProductos);
            this.Controls.Add(this.gboxInfoCliente);
            this.Controls.Add(this.gboxInfoVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.gboxInfoVenta.ResumeLayout(false);
            this.gboxInfoVenta.PerformLayout();
            this.gboxInfoCliente.ResumeLayout(false);
            this.gboxInfoCliente.PerformLayout();
            this.gboxInfoProductos.ResumeLayout(false);
            this.gboxInfoProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxInfoVenta;
        private System.Windows.Forms.GroupBox gboxInfoCliente;
        private System.Windows.Forms.GroupBox gboxInfoProductos;
        private System.Windows.Forms.DataGridView dgvVenta;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbTotal;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbPaga;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbCambio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPaga;
        private System.Windows.Forms.Label lblCambio;
        private CustomControls.RJControls.RJButton btnCrearVenta;
        private CustomControls.RJControls.RJButton btnAgregar;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbFecha;
        private CustomControls.RJControls.RJComboBox cmbTipoDoc;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblFecha;
        private CustomControls.RJControls.RJButton btnBuscarCli;
        private System.Windows.Forms.Label lblNombre;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbNombre;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label lblIDProd;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbIDProd;
        private System.Windows.Forms.Label lblStock;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbStock;
        private System.Windows.Forms.Label lblPrecio;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbPrecio;
        private System.Windows.Forms.Label lblProd;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbProd;
        private System.Windows.Forms.Label lblCantidad;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbCantidad;
        private CustomControls.RJControls.RJButton btnDown;
        private CustomControls.RJControls.RJButton btnUp;
    }
}