namespace Ingenieros_Commerce_Manager_v2._0
{
    partial class FormInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTipo = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dgvMatPrim = new System.Windows.Forms.DataGridView();
            this.lblProds = new System.Windows.Forms.Label();
            this.lblMatPrim = new System.Windows.Forms.Label();
            this.panelDGVs = new System.Windows.Forms.TableLayoutPanel();
            this.cmbTipo = new CustomControls.RJControls.RJComboBox();
            this.txbDescrip = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbStock = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbPrecio = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.btnIngreso = new CustomControls.RJControls.RJButton();
            this.btnElimina = new CustomControls.RJControls.RJButton();
            this.btnDeseleccionar = new CustomControls.RJControls.RJButton();
            this.btnEdit = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatPrim)).BeginInit();
            this.panelDGVs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTipo.Location = new System.Drawing.Point(519, 231);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 22);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeight = 25;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            this.dgvProductos.Location = new System.Drawing.Point(0, 29);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ShowCellErrors = false;
            this.dgvProductos.Size = new System.Drawing.Size(480, 265);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.Click += new System.EventHandler(this.dgvProductos_Click);
            // 
            // dgvMatPrim
            // 
            this.dgvMatPrim.AllowUserToAddRows = false;
            this.dgvMatPrim.AllowUserToDeleteRows = false;
            this.dgvMatPrim.AllowUserToOrderColumns = true;
            this.dgvMatPrim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatPrim.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatPrim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.dgvMatPrim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMatPrim.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMatPrim.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatPrim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMatPrim.ColumnHeadersHeight = 25;
            this.dgvMatPrim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatPrim.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMatPrim.EnableHeadersVisualStyles = false;
            this.dgvMatPrim.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            this.dgvMatPrim.Location = new System.Drawing.Point(0, 323);
            this.dgvMatPrim.Margin = new System.Windows.Forms.Padding(0);
            this.dgvMatPrim.Name = "dgvMatPrim";
            this.dgvMatPrim.ReadOnly = true;
            this.dgvMatPrim.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatPrim.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.dgvMatPrim.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMatPrim.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatPrim.ShowCellErrors = false;
            this.dgvMatPrim.Size = new System.Drawing.Size(480, 267);
            this.dgvMatPrim.TabIndex = 9;
            this.dgvMatPrim.Click += new System.EventHandler(this.dgvMatPrim_Click);
            // 
            // lblProds
            // 
            this.lblProds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProds.AutoSize = true;
            this.lblProds.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProds.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProds.Location = new System.Drawing.Point(10, 0);
            this.lblProds.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblProds.Name = "lblProds";
            this.lblProds.Size = new System.Drawing.Size(470, 29);
            this.lblProds.TabIndex = 11;
            this.lblProds.Text = "Productos de Venta";
            // 
            // lblMatPrim
            // 
            this.lblMatPrim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMatPrim.AutoSize = true;
            this.lblMatPrim.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatPrim.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMatPrim.Location = new System.Drawing.Point(10, 294);
            this.lblMatPrim.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblMatPrim.Name = "lblMatPrim";
            this.lblMatPrim.Size = new System.Drawing.Size(470, 29);
            this.lblMatPrim.TabIndex = 10;
            this.lblMatPrim.Text = "Materias Primas";
            // 
            // panelDGVs
            // 
            this.panelDGVs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDGVs.ColumnCount = 1;
            this.panelDGVs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDGVs.Controls.Add(this.dgvProductos, 0, 1);
            this.panelDGVs.Controls.Add(this.lblMatPrim, 0, 2);
            this.panelDGVs.Controls.Add(this.dgvMatPrim, 0, 3);
            this.panelDGVs.Controls.Add(this.lblProds, 0, 0);
            this.panelDGVs.Location = new System.Drawing.Point(10, 10);
            this.panelDGVs.Margin = new System.Windows.Forms.Padding(0);
            this.panelDGVs.Name = "panelDGVs";
            this.panelDGVs.RowCount = 4;
            this.panelDGVs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.panelDGVs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.panelDGVs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.panelDGVs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.panelDGVs.Size = new System.Drawing.Size(480, 590);
            this.panelDGVs.TabIndex = 12;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.cmbTipo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTipo.BorderSize = 2;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTipo.Items.AddRange(new object[] {
            "Materia Prima",
            "Producto en Venta"});
            this.cmbTipo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTipo.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTipo.Location = new System.Drawing.Point(505, 241);
            this.cmbTipo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Padding = new System.Windows.Forms.Padding(2);
            this.cmbTipo.Size = new System.Drawing.Size(250, 34);
            this.cmbTipo.TabIndex = 4;
            this.cmbTipo.Texts = "";
            // 
            // txbDescrip
            // 
            this.txbDescrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbDescrip.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbDescrip.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbDescrip.BorderRadius = 0;
            this.txbDescrip.BorderSize = 2;
            this.txbDescrip.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescrip.Location = new System.Drawing.Point(505, 113);
            this.txbDescrip.Maxlength = 32767;
            this.txbDescrip.Multiline = true;
            this.txbDescrip.Name = "txbDescrip";
            this.txbDescrip.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbDescrip.PasswordChar = false;
            this.txbDescrip.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbDescrip.PlaceholderText = "Descripción";
            this.txbDescrip.ReadOnly = false;
            this.txbDescrip.Size = new System.Drawing.Size(250, 118);
            this.txbDescrip.TabIndex = 3;
            this.txbDescrip.Texts = "";
            this.txbDescrip.UnderlinedStyle = false;
            // 
            // txbStock
            // 
            this.txbStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbStock.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbStock.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbStock.BorderRadius = 0;
            this.txbStock.BorderSize = 2;
            this.txbStock.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStock.Location = new System.Drawing.Point(505, 70);
            this.txbStock.Maxlength = 32767;
            this.txbStock.Multiline = false;
            this.txbStock.Name = "txbStock";
            this.txbStock.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbStock.PasswordChar = false;
            this.txbStock.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbStock.PlaceholderText = "Stock";
            this.txbStock.ReadOnly = false;
            this.txbStock.Size = new System.Drawing.Size(250, 37);
            this.txbStock.TabIndex = 2;
            this.txbStock.Texts = "";
            this.txbStock.UnderlinedStyle = false;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbPrecio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbPrecio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbPrecio.BorderRadius = 0;
            this.txbPrecio.BorderSize = 2;
            this.txbPrecio.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecio.Location = new System.Drawing.Point(505, 27);
            this.txbPrecio.Maxlength = 32767;
            this.txbPrecio.Multiline = false;
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbPrecio.PasswordChar = false;
            this.txbPrecio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPrecio.PlaceholderText = "Precio";
            this.txbPrecio.ReadOnly = false;
            this.txbPrecio.Size = new System.Drawing.Size(250, 37);
            this.txbPrecio.TabIndex = 1;
            this.txbPrecio.Texts = "";
            this.txbPrecio.UnderlinedStyle = false;
            // 
            // btnIngreso
            // 
            this.btnIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnIngreso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnIngreso.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnIngreso.BorderRadius = 15;
            this.btnIngreso.BorderSize = 0;
            this.btnIngreso.FlatAppearance.BorderSize = 0;
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngreso.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.ForeColor = System.Drawing.Color.White;
            this.btnIngreso.Location = new System.Drawing.Point(505, 290);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(250, 37);
            this.btnIngreso.TabIndex = 16;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.TextColor = System.Drawing.Color.White;
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnElimina.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnElimina.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnElimina.BorderRadius = 15;
            this.btnElimina.BorderSize = 0;
            this.btnElimina.FlatAppearance.BorderSize = 0;
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimina.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.ForeColor = System.Drawing.Color.White;
            this.btnElimina.Location = new System.Drawing.Point(505, 333);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(250, 37);
            this.btnElimina.TabIndex = 17;
            this.btnElimina.Text = "Eliminar";
            this.btnElimina.TextColor = System.Drawing.Color.White;
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnDeseleccionar
            // 
            this.btnDeseleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeseleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnDeseleccionar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnDeseleccionar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeseleccionar.BorderRadius = 15;
            this.btnDeseleccionar.BorderSize = 0;
            this.btnDeseleccionar.FlatAppearance.BorderSize = 0;
            this.btnDeseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeseleccionar.ForeColor = System.Drawing.Color.White;
            this.btnDeseleccionar.Location = new System.Drawing.Point(508, 561);
            this.btnDeseleccionar.Name = "btnDeseleccionar";
            this.btnDeseleccionar.Size = new System.Drawing.Size(250, 37);
            this.btnDeseleccionar.TabIndex = 18;
            this.btnDeseleccionar.Text = "Deseleccionar";
            this.btnDeseleccionar.TextColor = System.Drawing.Color.White;
            this.btnDeseleccionar.UseVisualStyleBackColor = false;
            this.btnDeseleccionar.Click += new System.EventHandler(this.btnDeseleccionar_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 15;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(508, 518);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(250, 37);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(770, 610);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDeseleccionar);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.panelDGVs);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txbDescrip);
            this.Controls.Add(this.txbStock);
            this.Controls.Add(this.txbPrecio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInventario";
            this.Text = "FormInventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatPrim)).EndInit();
            this.panelDGVs.ResumeLayout(false);
            this.panelDGVs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbPrecio;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbStock;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbDescrip;
        private CustomControls.RJControls.RJComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvMatPrim;
        private System.Windows.Forms.Label lblProds;
        private System.Windows.Forms.Label lblMatPrim;
        private System.Windows.Forms.TableLayoutPanel panelDGVs;
        private CustomControls.RJControls.RJButton btnIngreso;
        private CustomControls.RJControls.RJButton btnElimina;
        private CustomControls.RJControls.RJButton btnDeseleccionar;
        private CustomControls.RJControls.RJButton btnEdit;
    }
}