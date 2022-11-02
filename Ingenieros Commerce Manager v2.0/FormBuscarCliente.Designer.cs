namespace Ingenieros_Commerce_Manager_v2._0
{
    partial class FormBuscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarCliente));
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.gboxClientes = new System.Windows.Forms.GroupBox();
            this.btnClear = new CustomControls.RJControls.RJButton();
            this.txbBuscar = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.cmbBusqueda = new CustomControls.RJControls.RJComboBox();
            this.btnCancel = new CustomControls.RJControls.RJButton();
            this.btnSelect = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gboxClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToOrderColumns = true;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.ColumnHeadersHeight = 25;
            this.dgvCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            this.dgvCliente.Location = new System.Drawing.Point(7, 115);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCliente.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ShowCellErrors = false;
            this.dgvCliente.Size = new System.Drawing.Size(589, 240);
            this.dgvCliente.TabIndex = 3;
            this.dgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellDoubleClick);
            // 
            // gboxClientes
            // 
            this.gboxClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxClientes.Controls.Add(this.btnClear);
            this.gboxClientes.Controls.Add(this.txbBuscar);
            this.gboxClientes.Controls.Add(this.lblBusqueda);
            this.gboxClientes.Controls.Add(this.cmbBusqueda);
            this.gboxClientes.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxClientes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxClientes.Location = new System.Drawing.Point(7, 5);
            this.gboxClientes.Name = "gboxClientes";
            this.gboxClientes.Size = new System.Drawing.Size(589, 107);
            this.gboxClientes.TabIndex = 41;
            this.gboxClientes.TabStop = false;
            this.gboxClientes.Text = "Buscar cliente";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.BorderRadius = 15;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.clean24;
            this.btnClear.Location = new System.Drawing.Point(515, 44);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(39, 37);
            this.btnClear.TabIndex = 18;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txbBuscar
            // 
            this.txbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbBuscar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbBuscar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbBuscar.BorderRadius = 0;
            this.txbBuscar.BorderSize = 2;
            this.txbBuscar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscar.Location = new System.Drawing.Point(274, 45);
            this.txbBuscar.Maxlength = 32767;
            this.txbBuscar.Multiline = false;
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbBuscar.PasswordChar = false;
            this.txbBuscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbBuscar.PlaceholderText = "";
            this.txbBuscar.ReadOnly = false;
            this.txbBuscar.Size = new System.Drawing.Size(235, 37);
            this.txbBuscar.TabIndex = 16;
            this.txbBuscar.Texts = "";
            this.txbBuscar.UnderlinedStyle = false;
            this.txbBuscar._TextChanged += new System.EventHandler(this.txbBuscar__TextChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBusqueda.Location = new System.Drawing.Point(35, 31);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(76, 22);
            this.lblBusqueda.TabIndex = 12;
            this.lblBusqueda.Text = "Buscar por:";
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cmbBusqueda.Location = new System.Drawing.Point(25, 44);
            this.cmbBusqueda.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Padding = new System.Windows.Forms.Padding(2);
            this.cmbBusqueda.Size = new System.Drawing.Size(224, 38);
            this.cmbBusqueda.TabIndex = 11;
            this.cmbBusqueda.Texts = "";
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
            this.btnCancel.Location = new System.Drawing.Point(311, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 28);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnSelect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnSelect.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSelect.BorderRadius = 10;
            this.btnSelect.BorderSize = 0;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(455, 370);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(138, 28);
            this.btnSelect.TabIndex = 39;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.TextColor = System.Drawing.Color.White;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FormBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(603, 409);
            this.Controls.Add(this.gboxClientes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar cliente";
            this.Load += new System.EventHandler(this.FormBuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gboxClientes.ResumeLayout(false);
            this.gboxClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private CustomControls.RJControls.RJButton btnSelect;
        private CustomControls.RJControls.RJButton btnCancel;
        private System.Windows.Forms.GroupBox gboxClientes;
        private System.Windows.Forms.Label lblBusqueda;
        private CustomControls.RJControls.RJComboBox cmbBusqueda;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbBuscar;
        private CustomControls.RJControls.RJButton btnClear;
    }
}