namespace Ingenieros_Commerce_Manager_v2._0
{
    partial class FormGastos
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
            this.lblValorGastos = new System.Windows.Forms.Label();
            this.lblFechaGastos = new System.Windows.Forms.Label();
            this.lblConceptoGasto = new System.Windows.Forms.Label();
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.gboxIngresar = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new CustomControls.RJControls.RJButton();
            this.btnUp = new CustomControls.RJControls.RJButton();
            this.btnDown = new CustomControls.RJControls.RJButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new CustomControls.RJControls.RJComboBox();
            this.txbValorGastos = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.btnDeseleccionar = new CustomControls.RJControls.RJButton();
            this.txbFechaGastos = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.btnEditarGastos = new CustomControls.RJControls.RJButton();
            this.txbConceptoGastos = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.btnEliminarGastos = new CustomControls.RJControls.RJButton();
            this.btnIngresoGastos = new CustomControls.RJControls.RJButton();
            this.gboxBuscar = new System.Windows.Forms.GroupBox();
            this.btnClear = new CustomControls.RJControls.RJButton();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.cmbBusqueda = new CustomControls.RJControls.RJComboBox();
            this.txbBuscar = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.gboxIngresar.SuspendLayout();
            this.gboxBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValorGastos
            // 
            this.lblValorGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorGastos.AutoSize = true;
            this.lblValorGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblValorGastos.Location = new System.Drawing.Point(25, 32);
            this.lblValorGastos.Name = "lblValorGastos";
            this.lblValorGastos.Size = new System.Drawing.Size(52, 26);
            this.lblValorGastos.TabIndex = 3;
            this.lblValorGastos.Text = "Valor";
            // 
            // lblFechaGastos
            // 
            this.lblFechaGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaGastos.AutoSize = true;
            this.lblFechaGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblFechaGastos.Location = new System.Drawing.Point(25, 284);
            this.lblFechaGastos.Name = "lblFechaGastos";
            this.lblFechaGastos.Size = new System.Drawing.Size(58, 26);
            this.lblFechaGastos.TabIndex = 5;
            this.lblFechaGastos.Text = "Fecha";
            // 
            // lblConceptoGasto
            // 
            this.lblConceptoGasto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConceptoGasto.AutoSize = true;
            this.lblConceptoGasto.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConceptoGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblConceptoGasto.Location = new System.Drawing.Point(25, 94);
            this.lblConceptoGasto.Name = "lblConceptoGasto";
            this.lblConceptoGasto.Size = new System.Drawing.Size(87, 26);
            this.lblConceptoGasto.TabIndex = 7;
            this.lblConceptoGasto.Text = "Concepto";
            // 
            // dgvGastos
            // 
            this.dgvGastos.AllowUserToAddRows = false;
            this.dgvGastos.AllowUserToDeleteRows = false;
            this.dgvGastos.AllowUserToOrderColumns = true;
            this.dgvGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGastos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.dgvGastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGastos.ColumnHeadersHeight = 25;
            this.dgvGastos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGastos.EnableHeadersVisualStyles = false;
            this.dgvGastos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            this.dgvGastos.Location = new System.Drawing.Point(12, 117);
            this.dgvGastos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.ReadOnly = true;
            this.dgvGastos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGastos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGastos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.dgvGastos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGastos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGastos.ShowCellErrors = false;
            this.dgvGastos.Size = new System.Drawing.Size(621, 619);
            this.dgvGastos.TabIndex = 20;
            this.dgvGastos.Click += new System.EventHandler(this.dgvGastos_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.CalendarForeColor = System.Drawing.SystemColors.ControlDark;
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.dtpFecha.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.dtpFecha.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(19, 346);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(332, 30);
            this.dtpFecha.TabIndex = 21;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // gboxIngresar
            // 
            this.gboxIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxIngresar.Controls.Add(this.btnRefresh);
            this.gboxIngresar.Controls.Add(this.btnUp);
            this.gboxIngresar.Controls.Add(this.btnDown);
            this.gboxIngresar.Controls.Add(this.lblTipo);
            this.gboxIngresar.Controls.Add(this.cmbTipo);
            this.gboxIngresar.Controls.Add(this.lblValorGastos);
            this.gboxIngresar.Controls.Add(this.lblFechaGastos);
            this.gboxIngresar.Controls.Add(this.lblConceptoGasto);
            this.gboxIngresar.Controls.Add(this.txbValorGastos);
            this.gboxIngresar.Controls.Add(this.btnDeseleccionar);
            this.gboxIngresar.Controls.Add(this.dtpFecha);
            this.gboxIngresar.Controls.Add(this.txbFechaGastos);
            this.gboxIngresar.Controls.Add(this.btnEditarGastos);
            this.gboxIngresar.Controls.Add(this.txbConceptoGastos);
            this.gboxIngresar.Controls.Add(this.btnEliminarGastos);
            this.gboxIngresar.Controls.Add(this.btnIngresoGastos);
            this.gboxIngresar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxIngresar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxIngresar.Location = new System.Drawing.Point(641, 10);
            this.gboxIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxIngresar.Name = "gboxIngresar";
            this.gboxIngresar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxIngresar.Size = new System.Drawing.Size(369, 726);
            this.gboxIngresar.TabIndex = 44;
            this.gboxIngresar.TabStop = false;
            this.gboxIngresar.Text = "Ingresar gastos";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRefresh.BorderRadius = 15;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(19, 614);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(333, 46);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnUp.Location = new System.Drawing.Point(303, 47);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(49, 46);
            this.btnUp.TabIndex = 31;
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUp.TextColor = System.Drawing.Color.White;
            this.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnDown.Location = new System.Drawing.Point(245, 47);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(49, 46);
            this.btnDown.TabIndex = 30;
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDown.TextColor = System.Drawing.Color.White;
            this.btnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblTipo.Location = new System.Drawing.Point(25, 223);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(44, 26);
            this.lblTipo.TabIndex = 24;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.cmbTipo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTipo.BorderSize = 2;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTipo.Items.AddRange(new object[] {
            "Gastos fijos",
            "Compra de insumos",
            "Compra de materia prima",
            "Otros"});
            this.cmbTipo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTipo.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTipo.Location = new System.Drawing.Point(19, 238);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipo.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipo.Size = new System.Drawing.Size(333, 43);
            this.cmbTipo.TabIndex = 23;
            this.cmbTipo.Texts = "";
            // 
            // txbValorGastos
            // 
            this.txbValorGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbValorGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbValorGastos.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbValorGastos.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbValorGastos.BorderRadius = 0;
            this.txbValorGastos.BorderSize = 2;
            this.txbValorGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorGastos.Location = new System.Drawing.Point(19, 47);
            this.txbValorGastos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbValorGastos.Maxlength = 32767;
            this.txbValorGastos.Multiline = false;
            this.txbValorGastos.Name = "txbValorGastos";
            this.txbValorGastos.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txbValorGastos.PasswordChar = false;
            this.txbValorGastos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbValorGastos.PlaceholderText = "";
            this.txbValorGastos.ReadOnly = false;
            this.txbValorGastos.Size = new System.Drawing.Size(220, 41);
            this.txbValorGastos.TabIndex = 2;
            this.txbValorGastos.Texts = "";
            this.txbValorGastos.UnderlinedStyle = false;
            // 
            // btnDeseleccionar
            // 
            this.btnDeseleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeseleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnDeseleccionar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnDeseleccionar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeseleccionar.BorderRadius = 15;
            this.btnDeseleccionar.BorderSize = 0;
            this.btnDeseleccionar.FlatAppearance.BorderSize = 0;
            this.btnDeseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeseleccionar.ForeColor = System.Drawing.Color.White;
            this.btnDeseleccionar.Location = new System.Drawing.Point(19, 667);
            this.btnDeseleccionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeseleccionar.Name = "btnDeseleccionar";
            this.btnDeseleccionar.Size = new System.Drawing.Size(333, 46);
            this.btnDeseleccionar.TabIndex = 22;
            this.btnDeseleccionar.Text = "Deseleccionar";
            this.btnDeseleccionar.TextColor = System.Drawing.Color.White;
            this.btnDeseleccionar.UseVisualStyleBackColor = false;
            this.btnDeseleccionar.Click += new System.EventHandler(this.btnDeseleccionar_Click);
            // 
            // txbFechaGastos
            // 
            this.txbFechaGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFechaGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbFechaGastos.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbFechaGastos.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbFechaGastos.BorderRadius = 0;
            this.txbFechaGastos.BorderSize = 2;
            this.txbFechaGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFechaGastos.Location = new System.Drawing.Point(19, 298);
            this.txbFechaGastos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbFechaGastos.Maxlength = 32767;
            this.txbFechaGastos.Multiline = false;
            this.txbFechaGastos.Name = "txbFechaGastos";
            this.txbFechaGastos.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txbFechaGastos.PasswordChar = false;
            this.txbFechaGastos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbFechaGastos.PlaceholderText = "";
            this.txbFechaGastos.ReadOnly = false;
            this.txbFechaGastos.Size = new System.Drawing.Size(333, 41);
            this.txbFechaGastos.TabIndex = 4;
            this.txbFechaGastos.Texts = "";
            this.txbFechaGastos.UnderlinedStyle = false;
            // 
            // btnEditarGastos
            // 
            this.btnEditarGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnEditarGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnEditarGastos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditarGastos.BorderRadius = 15;
            this.btnEditarGastos.BorderSize = 0;
            this.btnEditarGastos.FlatAppearance.BorderSize = 0;
            this.btnEditarGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarGastos.ForeColor = System.Drawing.Color.White;
            this.btnEditarGastos.Location = new System.Drawing.Point(19, 489);
            this.btnEditarGastos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarGastos.Name = "btnEditarGastos";
            this.btnEditarGastos.Size = new System.Drawing.Size(333, 46);
            this.btnEditarGastos.TabIndex = 19;
            this.btnEditarGastos.Text = "Editar";
            this.btnEditarGastos.TextColor = System.Drawing.Color.White;
            this.btnEditarGastos.UseVisualStyleBackColor = false;
            this.btnEditarGastos.Click += new System.EventHandler(this.btnEditarGastos_Click);
            // 
            // txbConceptoGastos
            // 
            this.txbConceptoGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbConceptoGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbConceptoGastos.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbConceptoGastos.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbConceptoGastos.BorderRadius = 0;
            this.txbConceptoGastos.BorderSize = 2;
            this.txbConceptoGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConceptoGastos.Location = new System.Drawing.Point(19, 107);
            this.txbConceptoGastos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbConceptoGastos.Maxlength = 32767;
            this.txbConceptoGastos.Multiline = true;
            this.txbConceptoGastos.Name = "txbConceptoGastos";
            this.txbConceptoGastos.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txbConceptoGastos.PasswordChar = false;
            this.txbConceptoGastos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbConceptoGastos.PlaceholderText = "";
            this.txbConceptoGastos.ReadOnly = false;
            this.txbConceptoGastos.Size = new System.Drawing.Size(333, 114);
            this.txbConceptoGastos.TabIndex = 6;
            this.txbConceptoGastos.Texts = "";
            this.txbConceptoGastos.UnderlinedStyle = false;
            // 
            // btnEliminarGastos
            // 
            this.btnEliminarGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnEliminarGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnEliminarGastos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarGastos.BorderRadius = 15;
            this.btnEliminarGastos.BorderSize = 0;
            this.btnEliminarGastos.FlatAppearance.BorderSize = 0;
            this.btnEliminarGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGastos.ForeColor = System.Drawing.Color.White;
            this.btnEliminarGastos.Location = new System.Drawing.Point(19, 436);
            this.btnEliminarGastos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarGastos.Name = "btnEliminarGastos";
            this.btnEliminarGastos.Size = new System.Drawing.Size(333, 46);
            this.btnEliminarGastos.TabIndex = 18;
            this.btnEliminarGastos.Text = "Eliminar";
            this.btnEliminarGastos.TextColor = System.Drawing.Color.White;
            this.btnEliminarGastos.UseVisualStyleBackColor = false;
            this.btnEliminarGastos.Click += new System.EventHandler(this.btnEliminarGastos_Click);
            // 
            // btnIngresoGastos
            // 
            this.btnIngresoGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresoGastos.AutoSize = true;
            this.btnIngresoGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnIngresoGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnIngresoGastos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnIngresoGastos.BorderRadius = 15;
            this.btnIngresoGastos.BorderSize = 0;
            this.btnIngresoGastos.FlatAppearance.BorderSize = 0;
            this.btnIngresoGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresoGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoGastos.ForeColor = System.Drawing.Color.White;
            this.btnIngresoGastos.Location = new System.Drawing.Point(19, 383);
            this.btnIngresoGastos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIngresoGastos.Name = "btnIngresoGastos";
            this.btnIngresoGastos.Size = new System.Drawing.Size(333, 46);
            this.btnIngresoGastos.TabIndex = 17;
            this.btnIngresoGastos.Text = "Ingresar";
            this.btnIngresoGastos.TextColor = System.Drawing.Color.White;
            this.btnIngresoGastos.UseVisualStyleBackColor = false;
            this.btnIngresoGastos.Click += new System.EventHandler(this.btnIngresoGastos_Click);
            // 
            // gboxBuscar
            // 
            this.gboxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxBuscar.Controls.Add(this.btnClear);
            this.gboxBuscar.Controls.Add(this.lblBusqueda);
            this.gboxBuscar.Controls.Add(this.cmbBusqueda);
            this.gboxBuscar.Controls.Add(this.txbBuscar);
            this.gboxBuscar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxBuscar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxBuscar.Location = new System.Drawing.Point(12, 10);
            this.gboxBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxBuscar.Name = "gboxBuscar";
            this.gboxBuscar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxBuscar.Size = new System.Drawing.Size(621, 103);
            this.gboxBuscar.TabIndex = 45;
            this.gboxBuscar.TabStop = false;
            this.gboxBuscar.Text = "Buscar gastos";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.BorderRadius = 12;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.clean24;
            this.btnClear.Location = new System.Drawing.Point(547, 37);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 46);
            this.btnClear.TabIndex = 18;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBusqueda.Location = new System.Drawing.Point(37, 21);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(97, 26);
            this.lblBusqueda.TabIndex = 12;
            this.lblBusqueda.Text = "Buscar por:";
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.cmbBusqueda.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbBusqueda.BorderSize = 2;
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusqueda.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBusqueda.ForeColor = System.Drawing.Color.DimGray;
            this.cmbBusqueda.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbBusqueda.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbBusqueda.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbBusqueda.Location = new System.Drawing.Point(24, 37);
            this.cmbBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBusqueda.MinimumSize = new System.Drawing.Size(267, 37);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBusqueda.Size = new System.Drawing.Size(267, 47);
            this.cmbBusqueda.TabIndex = 11;
            this.cmbBusqueda.Texts = "";
            // 
            // txbBuscar
            // 
            this.txbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbBuscar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbBuscar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbBuscar.BorderRadius = 0;
            this.txbBuscar.BorderSize = 2;
            this.txbBuscar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscar.Location = new System.Drawing.Point(299, 37);
            this.txbBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbBuscar.Maxlength = 32767;
            this.txbBuscar.Multiline = false;
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txbBuscar.PasswordChar = false;
            this.txbBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbBuscar.PlaceholderText = "";
            this.txbBuscar.ReadOnly = false;
            this.txbBuscar.Size = new System.Drawing.Size(240, 45);
            this.txbBuscar.TabIndex = 16;
            this.txbBuscar.Texts = "";
            this.txbBuscar.UnderlinedStyle = false;
            this.txbBuscar._TextChanged += new System.EventHandler(this.txbBuscar__TextChanged);
            // 
            // FormGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1027, 751);
            this.Controls.Add(this.gboxBuscar);
            this.Controls.Add(this.gboxIngresar);
            this.Controls.Add(this.dgvGastos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGastos";
            this.Text = "Gastos";
            this.Load += new System.EventHandler(this.FormGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.gboxIngresar.ResumeLayout(false);
            this.gboxIngresar.PerformLayout();
            this.gboxBuscar.ResumeLayout(false);
            this.gboxBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbValorGastos;
        private System.Windows.Forms.Label lblValorGastos;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbFechaGastos;
        private System.Windows.Forms.Label lblFechaGastos;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbConceptoGastos;
        private System.Windows.Forms.Label lblConceptoGasto;
        private CustomControls.RJControls.RJButton btnIngresoGastos;
        private CustomControls.RJControls.RJButton btnEliminarGastos;
        private CustomControls.RJControls.RJButton btnEditarGastos;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private CustomControls.RJControls.RJButton btnDeseleccionar;
        private System.Windows.Forms.GroupBox gboxIngresar;
        private System.Windows.Forms.GroupBox gboxBuscar;
        private CustomControls.RJControls.RJButton btnClear;
        private System.Windows.Forms.Label lblBusqueda;
        private CustomControls.RJControls.RJComboBox cmbBusqueda;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbBuscar;
        private System.Windows.Forms.Label lblTipo;
        private CustomControls.RJControls.RJComboBox cmbTipo;
        private CustomControls.RJControls.RJButton btnUp;
        private CustomControls.RJControls.RJButton btnDown;
        private CustomControls.RJControls.RJButton btnRefresh;
    }
}