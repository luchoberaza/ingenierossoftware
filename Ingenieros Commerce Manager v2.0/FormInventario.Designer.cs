﻿namespace Ingenieros_Commerce_Manager_v2._0
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dgvMatPrim = new System.Windows.Forms.DataGridView();
            this.lblProds = new System.Windows.Forms.Label();
            this.lblMatPrim = new System.Windows.Forms.Label();
            this.panelDGVs = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbTipo = new CustomControls.RJControls.RJComboBox();
            this.txbDescrip = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbStock = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbPrecio = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatPrim)).BeginInit();
            this.panelDGVs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTipo.Location = new System.Drawing.Point(514, 230);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 22);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIngresar.Location = new System.Drawing.Point(500, 280);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(250, 47);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProductos.Location = new System.Drawing.Point(0, 18);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(480, 286);
            this.dgvProductos.TabIndex = 0;
            // 
            // dgvMatPrim
            // 
            this.dgvMatPrim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatPrim.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvMatPrim.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMatPrim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatPrim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatPrim.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMatPrim.Location = new System.Drawing.Point(0, 322);
            this.dgvMatPrim.Margin = new System.Windows.Forms.Padding(0);
            this.dgvMatPrim.Name = "dgvMatPrim";
            this.dgvMatPrim.ReadOnly = true;
            this.dgvMatPrim.Size = new System.Drawing.Size(480, 288);
            this.dgvMatPrim.TabIndex = 9;
            // 
            // lblProds
            // 
            this.lblProds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProds.AutoSize = true;
            this.lblProds.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProds.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProds.Location = new System.Drawing.Point(10, 0);
            this.lblProds.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblProds.Name = "lblProds";
            this.lblProds.Size = new System.Drawing.Size(470, 18);
            this.lblProds.TabIndex = 11;
            this.lblProds.Text = "Productos de Venta";
            // 
            // lblMatPrim
            // 
            this.lblMatPrim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMatPrim.AutoSize = true;
            this.lblMatPrim.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatPrim.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMatPrim.Location = new System.Drawing.Point(10, 304);
            this.lblMatPrim.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblMatPrim.Name = "lblMatPrim";
            this.lblMatPrim.Size = new System.Drawing.Size(470, 18);
            this.lblMatPrim.TabIndex = 10;
            this.lblMatPrim.Text = "Materias Primas";
            // 
            // panelDGVs
            // 
            this.panelDGVs.ColumnCount = 1;
            this.panelDGVs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDGVs.Controls.Add(this.dgvProductos, 0, 1);
            this.panelDGVs.Controls.Add(this.lblMatPrim, 0, 2);
            this.panelDGVs.Controls.Add(this.dgvMatPrim, 0, 3);
            this.panelDGVs.Controls.Add(this.lblProds, 0, 0);
            this.panelDGVs.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDGVs.Location = new System.Drawing.Point(0, 0);
            this.panelDGVs.Name = "panelDGVs";
            this.panelDGVs.RowCount = 4;
            this.panelDGVs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.panelDGVs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.panelDGVs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.panelDGVs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.panelDGVs.Size = new System.Drawing.Size(480, 610);
            this.panelDGVs.TabIndex = 12;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(500, 333);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 47);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(630, 333);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 47);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbTipo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTipo.BorderSize = 2;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTipo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTipo.Items.AddRange(new object[] {
            "Materia Prima",
            "Producto en Venta"});
            this.cmbTipo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTipo.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTipo.Location = new System.Drawing.Point(500, 240);
            this.cmbTipo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Padding = new System.Windows.Forms.Padding(2);
            this.cmbTipo.Size = new System.Drawing.Size(250, 34);
            this.cmbTipo.TabIndex = 4;
            this.cmbTipo.Texts = "";
            // 
            // txbDescrip
            // 
            this.txbDescrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbDescrip.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbDescrip.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbDescrip.BorderRadius = 0;
            this.txbDescrip.BorderSize = 2;
            this.txbDescrip.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescrip.Location = new System.Drawing.Point(500, 112);
            this.txbDescrip.Multiline = true;
            this.txbDescrip.Name = "txbDescrip";
            this.txbDescrip.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbDescrip.PasswordChar = false;
            this.txbDescrip.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbDescrip.PlaceholderText = "Descripción";
            this.txbDescrip.Size = new System.Drawing.Size(250, 118);
            this.txbDescrip.TabIndex = 3;
            this.txbDescrip.Texts = "";
            this.txbDescrip.UnderlinedStyle = false;
            // 
            // txbStock
            // 
            this.txbStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbStock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbStock.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbStock.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbStock.BorderRadius = 0;
            this.txbStock.BorderSize = 2;
            this.txbStock.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStock.Location = new System.Drawing.Point(500, 69);
            this.txbStock.Multiline = false;
            this.txbStock.Name = "txbStock";
            this.txbStock.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbStock.PasswordChar = false;
            this.txbStock.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbStock.PlaceholderText = "Stock";
            this.txbStock.Size = new System.Drawing.Size(250, 37);
            this.txbStock.TabIndex = 2;
            this.txbStock.Texts = "";
            this.txbStock.UnderlinedStyle = false;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPrecio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbPrecio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbPrecio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbPrecio.BorderRadius = 0;
            this.txbPrecio.BorderSize = 2;
            this.txbPrecio.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecio.Location = new System.Drawing.Point(500, 26);
            this.txbPrecio.Multiline = false;
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbPrecio.PasswordChar = false;
            this.txbPrecio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPrecio.PlaceholderText = "Precio";
            this.txbPrecio.Size = new System.Drawing.Size(250, 37);
            this.txbPrecio.TabIndex = 1;
            this.txbPrecio.Texts = "";
            this.txbPrecio.UnderlinedStyle = false;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(770, 610);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panelDGVs);
            this.Controls.Add(this.btnIngresar);
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
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvMatPrim;
        private System.Windows.Forms.Label lblProds;
        private System.Windows.Forms.Label lblMatPrim;
        private System.Windows.Forms.TableLayoutPanel panelDGVs;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}