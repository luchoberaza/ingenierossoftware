namespace Ingenieros_Commerce_Manager_v2._0
{
    partial class FormUsarMatPrim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsarMatPrim));
            this.gboxItem = new System.Windows.Forms.GroupBox();
            this.lblMatPrim = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gboxDetalles = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFechaGastos = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new CustomControls.RJControls.RJButton();
            this.btnAceptar = new CustomControls.RJControls.RJButton();
            this.txbFecha = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.btnUp = new CustomControls.RJControls.RJButton();
            this.btnDown = new CustomControls.RJControls.RJButton();
            this.txbCantidad = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbStock = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbCosto = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbDescrip = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.gboxItem.SuspendLayout();
            this.gboxDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxItem
            // 
            this.gboxItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxItem.Controls.Add(this.lblID);
            this.gboxItem.Controls.Add(this.lblCod);
            this.gboxItem.Controls.Add(this.lblStock);
            this.gboxItem.Controls.Add(this.txbStock);
            this.gboxItem.Controls.Add(this.lblCosto);
            this.gboxItem.Controls.Add(this.txbCosto);
            this.gboxItem.Controls.Add(this.lblMatPrim);
            this.gboxItem.Controls.Add(this.txbDescrip);
            this.gboxItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxItem.Location = new System.Drawing.Point(6, 9);
            this.gboxItem.Name = "gboxItem";
            this.gboxItem.Size = new System.Drawing.Size(325, 244);
            this.gboxItem.TabIndex = 0;
            this.gboxItem.TabStop = false;
            this.gboxItem.Text = "Item seleccionado";
            // 
            // lblMatPrim
            // 
            this.lblMatPrim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMatPrim.AutoSize = true;
            this.lblMatPrim.Location = new System.Drawing.Point(27, 83);
            this.lblMatPrim.Name = "lblMatPrim";
            this.lblMatPrim.Size = new System.Drawing.Size(82, 22);
            this.lblMatPrim.TabIndex = 0;
            this.lblMatPrim.Text = "Descripción:";
            // 
            // lblCosto
            // 
            this.lblCosto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(27, 136);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(48, 22);
            this.lblCosto.TabIndex = 1;
            this.lblCosto.Text = "Costo:";
            // 
            // lblStock
            // 
            this.lblStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(175, 136);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(45, 22);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock:";
            // 
            // lblCod
            // 
            this.lblCod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(27, 37);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(57, 22);
            this.lblCod.TabIndex = 20;
            this.lblCod.Text = "Código:";
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblID.Location = new System.Drawing.Point(91, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 28);
            this.lblID.TabIndex = 21;
            // 
            // gboxDetalles
            // 
            this.gboxDetalles.Controls.Add(this.lblFechaGastos);
            this.gboxDetalles.Controls.Add(this.dtpFecha);
            this.gboxDetalles.Controls.Add(this.txbFecha);
            this.gboxDetalles.Controls.Add(this.btnUp);
            this.gboxDetalles.Controls.Add(this.btnDown);
            this.gboxDetalles.Controls.Add(this.lblCantidad);
            this.gboxDetalles.Controls.Add(this.txbCantidad);
            this.gboxDetalles.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDetalles.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxDetalles.Location = new System.Drawing.Point(336, 9);
            this.gboxDetalles.Name = "gboxDetalles";
            this.gboxDetalles.Size = new System.Drawing.Size(244, 243);
            this.gboxDetalles.TabIndex = 1;
            this.gboxDetalles.TabStop = false;
            this.gboxDetalles.Text = "Detalles";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCantidad.Location = new System.Drawing.Point(21, 54);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(69, 22);
            this.lblCantidad.TabIndex = 25;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblFechaGastos
            // 
            this.lblFechaGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaGastos.AutoSize = true;
            this.lblFechaGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblFechaGastos.Location = new System.Drawing.Point(20, 112);
            this.lblFechaGastos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaGastos.Name = "lblFechaGastos";
            this.lblFechaGastos.Size = new System.Drawing.Size(46, 22);
            this.lblFechaGastos.TabIndex = 29;
            this.lblFechaGastos.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.CalendarForeColor = System.Drawing.SystemColors.ControlDark;
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.dtpFecha.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.dtpFecha.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(15, 162);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(216, 25);
            this.dtpFecha.TabIndex = 30;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(298, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 28);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnAceptar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAceptar.BorderRadius = 10;
            this.btnAceptar.BorderSize = 0;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(442, 258);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(138, 28);
            this.btnAceptar.TabIndex = 41;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.txbFecha.Location = new System.Drawing.Point(15, 123);
            this.txbFecha.Margin = new System.Windows.Forms.Padding(2);
            this.txbFecha.Maxlength = 32767;
            this.txbFecha.Multiline = false;
            this.txbFecha.Name = "txbFecha";
            this.txbFecha.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txbFecha.PasswordChar = false;
            this.txbFecha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbFecha.PlaceholderText = "";
            this.txbFecha.ReadOnly = false;
            this.txbFecha.Size = new System.Drawing.Size(216, 35);
            this.txbFecha.TabIndex = 28;
            this.txbFecha.Texts = "";
            this.txbFecha.UnderlinedStyle = false;
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
            this.btnUp.Location = new System.Drawing.Point(194, 68);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(37, 37);
            this.btnUp.TabIndex = 27;
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
            this.btnDown.Location = new System.Drawing.Point(151, 68);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(37, 37);
            this.btnDown.TabIndex = 24;
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
            this.txbCantidad.Location = new System.Drawing.Point(15, 68);
            this.txbCantidad.Maxlength = 32767;
            this.txbCantidad.Multiline = false;
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbCantidad.PasswordChar = false;
            this.txbCantidad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbCantidad.PlaceholderText = "";
            this.txbCantidad.ReadOnly = false;
            this.txbCantidad.Size = new System.Drawing.Size(130, 37);
            this.txbCantidad.TabIndex = 26;
            this.txbCantidad.Texts = "";
            this.txbCantidad.UnderlinedStyle = false;
            // 
            // txbStock
            // 
            this.txbStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbStock.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbStock.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txbStock.BorderRadius = 0;
            this.txbStock.BorderSize = 2;
            this.txbStock.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStock.Location = new System.Drawing.Point(166, 148);
            this.txbStock.Maxlength = 32767;
            this.txbStock.Multiline = false;
            this.txbStock.Name = "txbStock";
            this.txbStock.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbStock.PasswordChar = false;
            this.txbStock.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbStock.PlaceholderText = "";
            this.txbStock.ReadOnly = true;
            this.txbStock.Size = new System.Drawing.Size(143, 37);
            this.txbStock.TabIndex = 19;
            this.txbStock.Texts = "";
            this.txbStock.UnderlinedStyle = false;
            // 
            // txbCosto
            // 
            this.txbCosto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbCosto.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbCosto.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txbCosto.BorderRadius = 0;
            this.txbCosto.BorderSize = 2;
            this.txbCosto.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCosto.Location = new System.Drawing.Point(17, 148);
            this.txbCosto.Maxlength = 32767;
            this.txbCosto.Multiline = false;
            this.txbCosto.Name = "txbCosto";
            this.txbCosto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbCosto.PasswordChar = false;
            this.txbCosto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbCosto.PlaceholderText = "";
            this.txbCosto.ReadOnly = true;
            this.txbCosto.Size = new System.Drawing.Size(143, 37);
            this.txbCosto.TabIndex = 18;
            this.txbCosto.Texts = "";
            this.txbCosto.UnderlinedStyle = false;
            // 
            // txbDescrip
            // 
            this.txbDescrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbDescrip.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbDescrip.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txbDescrip.BorderRadius = 0;
            this.txbDescrip.BorderSize = 2;
            this.txbDescrip.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescrip.Location = new System.Drawing.Point(17, 96);
            this.txbDescrip.Maxlength = 32767;
            this.txbDescrip.Multiline = false;
            this.txbDescrip.Name = "txbDescrip";
            this.txbDescrip.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbDescrip.PasswordChar = false;
            this.txbDescrip.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbDescrip.PlaceholderText = "";
            this.txbDescrip.ReadOnly = true;
            this.txbDescrip.Size = new System.Drawing.Size(292, 37);
            this.txbDescrip.TabIndex = 17;
            this.txbDescrip.Texts = "";
            this.txbDescrip.UnderlinedStyle = false;
            // 
            // FormUsarMatPrim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(586, 298);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gboxDetalles);
            this.Controls.Add(this.gboxItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsarMatPrim";
            this.Text = "Utilizar materia prima";
            this.Load += new System.EventHandler(this.FormUsarMatPrim_Load);
            this.gboxItem.ResumeLayout(false);
            this.gboxItem.PerformLayout();
            this.gboxDetalles.ResumeLayout(false);
            this.gboxDetalles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxItem;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblMatPrim;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbDescrip;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCod;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbStock;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbCosto;
        private System.Windows.Forms.GroupBox gboxDetalles;
        private CustomControls.RJControls.RJButton btnUp;
        private CustomControls.RJControls.RJButton btnDown;
        private System.Windows.Forms.Label lblCantidad;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbCantidad;
        private System.Windows.Forms.Label lblFechaGastos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbFecha;
        private CustomControls.RJControls.RJButton btnCancel;
        private CustomControls.RJControls.RJButton btnAceptar;
    }
}