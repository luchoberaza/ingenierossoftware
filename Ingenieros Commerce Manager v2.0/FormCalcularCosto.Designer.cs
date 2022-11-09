namespace Ingenieros_Commerce_Manager_v2._0
{
    partial class FormCalcularCosto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalcularCosto));
            this.gboxItem = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCostoActual = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txbStock = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txbPrecio = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.lblMatPrim = new System.Windows.Forms.Label();
            this.txbDescrip = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new CustomControls.RJControls.RJButton();
            this.btnUp = new CustomControls.RJControls.RJButton();
            this.btnDown = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCostoProduccion = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txbCantidad = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.lblCostoCalculado = new System.Windows.Forms.Label();
            this.btnCancel = new CustomControls.RJControls.RJButton();
            this.btnAceptar = new CustomControls.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerar = new CustomControls.RJControls.RJToggleButton();
            this.gboxItem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxItem
            // 
            this.gboxItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxItem.Controls.Add(this.label2);
            this.gboxItem.Controls.Add(this.txbCostoActual);
            this.gboxItem.Controls.Add(this.lblID);
            this.gboxItem.Controls.Add(this.lblCod);
            this.gboxItem.Controls.Add(this.lblStock);
            this.gboxItem.Controls.Add(this.txbStock);
            this.gboxItem.Controls.Add(this.lblCosto);
            this.gboxItem.Controls.Add(this.txbPrecio);
            this.gboxItem.Controls.Add(this.lblMatPrim);
            this.gboxItem.Controls.Add(this.txbDescrip);
            this.gboxItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxItem.Location = new System.Drawing.Point(3, 12);
            this.gboxItem.Name = "gboxItem";
            this.gboxItem.Size = new System.Drawing.Size(325, 225);
            this.gboxItem.TabIndex = 1;
            this.gboxItem.TabStop = false;
            this.gboxItem.Text = "Item seleccionado";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Costo unitario actual:";
            // 
            // txbCostoActual
            // 
            this.txbCostoActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCostoActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbCostoActual.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbCostoActual.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txbCostoActual.BorderRadius = 0;
            this.txbCostoActual.BorderSize = 2;
            this.txbCostoActual.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCostoActual.Location = new System.Drawing.Point(17, 176);
            this.txbCostoActual.Maxlength = 32767;
            this.txbCostoActual.Multiline = false;
            this.txbCostoActual.Name = "txbCostoActual";
            this.txbCostoActual.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbCostoActual.PasswordChar = false;
            this.txbCostoActual.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbCostoActual.PlaceholderText = "";
            this.txbCostoActual.ReadOnly = true;
            this.txbCostoActual.Size = new System.Drawing.Size(292, 37);
            this.txbCostoActual.TabIndex = 23;
            this.txbCostoActual.Texts = "";
            this.txbCostoActual.UnderlinedStyle = false;
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblID.Location = new System.Drawing.Point(91, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 28);
            this.lblID.TabIndex = 21;
            // 
            // lblCod
            // 
            this.lblCod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(27, 30);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(57, 22);
            this.lblCod.TabIndex = 20;
            this.lblCod.Text = "Código:";
            // 
            // lblStock
            // 
            this.lblStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(175, 113);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(45, 22);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock:";
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
            this.txbStock.Location = new System.Drawing.Point(166, 125);
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
            // lblCosto
            // 
            this.lblCosto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(27, 113);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(49, 22);
            this.lblCosto.TabIndex = 1;
            this.lblCosto.Text = "Precio:";
            // 
            // txbPrecio
            // 
            this.txbPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbPrecio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbPrecio.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txbPrecio.BorderRadius = 0;
            this.txbPrecio.BorderSize = 2;
            this.txbPrecio.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecio.Location = new System.Drawing.Point(17, 125);
            this.txbPrecio.Maxlength = 32767;
            this.txbPrecio.Multiline = false;
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbPrecio.PasswordChar = false;
            this.txbPrecio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPrecio.PlaceholderText = "";
            this.txbPrecio.ReadOnly = true;
            this.txbPrecio.Size = new System.Drawing.Size(143, 37);
            this.txbPrecio.TabIndex = 18;
            this.txbPrecio.Texts = "";
            this.txbPrecio.UnderlinedStyle = false;
            // 
            // lblMatPrim
            // 
            this.lblMatPrim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMatPrim.AutoSize = true;
            this.lblMatPrim.Location = new System.Drawing.Point(27, 60);
            this.lblMatPrim.Name = "lblMatPrim";
            this.lblMatPrim.Size = new System.Drawing.Size(82, 22);
            this.lblMatPrim.TabIndex = 0;
            this.lblMatPrim.Text = "Descripción:";
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
            this.txbDescrip.Location = new System.Drawing.Point(17, 73);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbCostoProduccion);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.txbCantidad);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(334, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 225);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calcular costo unitario";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnCalcular.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnCalcular.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCalcular.BorderRadius = 15;
            this.btnCalcular.BorderSize = 0;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(11, 176);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(246, 37);
            this.btnCalcular.TabIndex = 30;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextColor = System.Drawing.Color.White;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
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
            this.btnUp.Location = new System.Drawing.Point(220, 44);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(37, 38);
            this.btnUp.TabIndex = 29;
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
            this.btnDown.Location = new System.Drawing.Point(177, 44);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(37, 38);
            this.btnDown.TabIndex = 28;
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDown.TextColor = System.Drawing.Color.White;
            this.btnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Costo de la producción:";
            // 
            // txbCostoProduccion
            // 
            this.txbCostoProduccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCostoProduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbCostoProduccion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbCostoProduccion.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txbCostoProduccion.BorderRadius = 0;
            this.txbCostoProduccion.BorderSize = 2;
            this.txbCostoProduccion.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCostoProduccion.Location = new System.Drawing.Point(11, 95);
            this.txbCostoProduccion.Maxlength = 32767;
            this.txbCostoProduccion.Multiline = false;
            this.txbCostoProduccion.Name = "txbCostoProduccion";
            this.txbCostoProduccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbCostoProduccion.PasswordChar = false;
            this.txbCostoProduccion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbCostoProduccion.PlaceholderText = "";
            this.txbCostoProduccion.ReadOnly = false;
            this.txbCostoProduccion.Size = new System.Drawing.Size(246, 37);
            this.txbCostoProduccion.TabIndex = 23;
            this.txbCostoProduccion.Texts = "";
            this.txbCostoProduccion.UnderlinedStyle = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(18, 32);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(134, 22);
            this.lblCantidad.TabIndex = 20;
            this.lblCantidad.Text = "Cantidad producida:";
            // 
            // txbCantidad
            // 
            this.txbCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbCantidad.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbCantidad.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txbCantidad.BorderRadius = 0;
            this.txbCantidad.BorderSize = 2;
            this.txbCantidad.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad.Location = new System.Drawing.Point(11, 44);
            this.txbCantidad.Maxlength = 32767;
            this.txbCantidad.Multiline = false;
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbCantidad.PasswordChar = false;
            this.txbCantidad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbCantidad.PlaceholderText = "";
            this.txbCantidad.ReadOnly = false;
            this.txbCantidad.Size = new System.Drawing.Size(159, 37);
            this.txbCantidad.TabIndex = 21;
            this.txbCantidad.Texts = "";
            this.txbCantidad.UnderlinedStyle = false;
            // 
            // lblCostoCalculado
            // 
            this.lblCostoCalculado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostoCalculado.AutoSize = true;
            this.lblCostoCalculado.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoCalculado.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCostoCalculado.Location = new System.Drawing.Point(12, 256);
            this.lblCostoCalculado.Name = "lblCostoCalculado";
            this.lblCostoCalculado.Size = new System.Drawing.Size(111, 22);
            this.lblCostoCalculado.TabIndex = 23;
            this.lblCostoCalculado.Text = "Costo calculado:";
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
            this.btnCancel.Location = new System.Drawing.Point(317, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 28);
            this.btnCancel.TabIndex = 44;
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
            this.btnAceptar.Location = new System.Drawing.Point(461, 256);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(138, 28);
            this.btnAceptar.TabIndex = 43;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(10, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Generar gasto asociado:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.AutoSize = true;
            this.btnGenerar.Location = new System.Drawing.Point(212, 140);
            this.btnGenerar.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.OffBackColor = System.Drawing.Color.Gray;
            this.btnGenerar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnGenerar.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGenerar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerar.Size = new System.Drawing.Size(45, 22);
            this.btnGenerar.TabIndex = 32;
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // FormCalcularCosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(603, 296);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblCostoCalculado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalcularCosto";
            this.Load += new System.EventHandler(this.FormCalcularCosto_Load);
            this.gboxItem.ResumeLayout(false);
            this.gboxItem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxItem;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblStock;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbStock;
        private System.Windows.Forms.Label lblCosto;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbPrecio;
        private System.Windows.Forms.Label lblMatPrim;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbDescrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbCostoProduccion;
        private System.Windows.Forms.Label lblCantidad;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbCantidad;
        private CustomControls.RJControls.RJButton btnUp;
        private CustomControls.RJControls.RJButton btnDown;
        private System.Windows.Forms.Label label2;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbCostoActual;
        private CustomControls.RJControls.RJButton btnCalcular;
        private System.Windows.Forms.Label lblCostoCalculado;
        private CustomControls.RJControls.RJButton btnCancel;
        private CustomControls.RJControls.RJButton btnAceptar;
        private CustomControls.RJControls.RJToggleButton btnGenerar;
        private System.Windows.Forms.Label label3;
    }
}