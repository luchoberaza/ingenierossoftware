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
            this.btnEditarGastos = new CustomControls.RJControls.RJButton();
            this.btnEliminarGastos = new CustomControls.RJControls.RJButton();
            this.btnIngresoGastos = new CustomControls.RJControls.RJButton();
            this.txbConceptoGastos = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbFechaGastos = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbValorGastos = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValorGastos
            // 
            this.lblValorGastos.AutoSize = true;
            this.lblValorGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblValorGastos.Location = new System.Drawing.Point(34, 16);
            this.lblValorGastos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorGastos.Name = "lblValorGastos";
            this.lblValorGastos.Size = new System.Drawing.Size(41, 22);
            this.lblValorGastos.TabIndex = 3;
            this.lblValorGastos.Text = "Valor";
            this.lblValorGastos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFechaGastos
            // 
            this.lblFechaGastos.AutoSize = true;
            this.lblFechaGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblFechaGastos.Location = new System.Drawing.Point(34, 132);
            this.lblFechaGastos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaGastos.Name = "lblFechaGastos";
            this.lblFechaGastos.Size = new System.Drawing.Size(46, 22);
            this.lblFechaGastos.TabIndex = 5;
            this.lblFechaGastos.Text = "Fecha";
            // 
            // lblConceptoGasto
            // 
            this.lblConceptoGasto.AutoSize = true;
            this.lblConceptoGasto.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConceptoGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblConceptoGasto.Location = new System.Drawing.Point(34, 74);
            this.lblConceptoGasto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConceptoGasto.Name = "lblConceptoGasto";
            this.lblConceptoGasto.Size = new System.Drawing.Size(69, 22);
            this.lblConceptoGasto.TabIndex = 7;
            this.lblConceptoGasto.Text = "Concepto";
            this.lblConceptoGasto.Click += new System.EventHandler(this.label2_Click);
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
            this.dgvGastos.Location = new System.Drawing.Point(278, 16);
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
            this.dgvGastos.Size = new System.Drawing.Size(470, 574);
            this.dgvGastos.TabIndex = 20;
            this.dgvGastos.Click += new System.EventHandler(this.dgvGastos_Click);
            // 
            // btnEditarGastos
            // 
            this.btnEditarGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnEditarGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnEditarGastos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditarGastos.BorderRadius = 15;
            this.btnEditarGastos.BorderSize = 0;
            this.btnEditarGastos.FlatAppearance.BorderSize = 0;
            this.btnEditarGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarGastos.ForeColor = System.Drawing.Color.White;
            this.btnEditarGastos.Location = new System.Drawing.Point(29, 531);
            this.btnEditarGastos.Name = "btnEditarGastos";
            this.btnEditarGastos.Size = new System.Drawing.Size(110, 54);
            this.btnEditarGastos.TabIndex = 19;
            this.btnEditarGastos.Text = "Editar";
            this.btnEditarGastos.TextColor = System.Drawing.Color.White;
            this.btnEditarGastos.UseVisualStyleBackColor = false;
            this.btnEditarGastos.Click += new System.EventHandler(this.btnEditarGastos_Click);
            // 
            // btnEliminarGastos
            // 
            this.btnEliminarGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnEliminarGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnEliminarGastos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarGastos.BorderRadius = 15;
            this.btnEliminarGastos.BorderSize = 0;
            this.btnEliminarGastos.FlatAppearance.BorderSize = 0;
            this.btnEliminarGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGastos.ForeColor = System.Drawing.Color.White;
            this.btnEliminarGastos.Location = new System.Drawing.Point(141, 531);
            this.btnEliminarGastos.Name = "btnEliminarGastos";
            this.btnEliminarGastos.Size = new System.Drawing.Size(110, 54);
            this.btnEliminarGastos.TabIndex = 18;
            this.btnEliminarGastos.Text = "Eliminar";
            this.btnEliminarGastos.TextColor = System.Drawing.Color.White;
            this.btnEliminarGastos.UseVisualStyleBackColor = false;
            this.btnEliminarGastos.Click += new System.EventHandler(this.btnEliminarGastos_Click);
            // 
            // btnIngresoGastos
            // 
            this.btnIngresoGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnIngresoGastos.Location = new System.Drawing.Point(29, 470);
            this.btnIngresoGastos.Name = "btnIngresoGastos";
            this.btnIngresoGastos.Size = new System.Drawing.Size(221, 54);
            this.btnIngresoGastos.TabIndex = 17;
            this.btnIngresoGastos.Text = "Ingresar";
            this.btnIngresoGastos.TextColor = System.Drawing.Color.White;
            this.btnIngresoGastos.UseVisualStyleBackColor = false;
            this.btnIngresoGastos.Click += new System.EventHandler(this.btnIngresoGastos_Click);
            // 
            // txbConceptoGastos
            // 
            this.txbConceptoGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbConceptoGastos.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbConceptoGastos.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbConceptoGastos.BorderRadius = 0;
            this.txbConceptoGastos.BorderSize = 2;
            this.txbConceptoGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConceptoGastos.Location = new System.Drawing.Point(29, 85);
            this.txbConceptoGastos.Margin = new System.Windows.Forms.Padding(2);
            this.txbConceptoGastos.Maxlength = 32767;
            this.txbConceptoGastos.Multiline = false;
            this.txbConceptoGastos.Name = "txbConceptoGastos";
            this.txbConceptoGastos.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txbConceptoGastos.PasswordChar = false;
            this.txbConceptoGastos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbConceptoGastos.PlaceholderText = "";
            this.txbConceptoGastos.ReadOnly = false;
            this.txbConceptoGastos.Size = new System.Drawing.Size(221, 35);
            this.txbConceptoGastos.TabIndex = 6;
            this.txbConceptoGastos.Texts = "";
            this.txbConceptoGastos.UnderlinedStyle = false;
            // 
            // txbFechaGastos
            // 
            this.txbFechaGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbFechaGastos.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbFechaGastos.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbFechaGastos.BorderRadius = 0;
            this.txbFechaGastos.BorderSize = 2;
            this.txbFechaGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFechaGastos.Location = new System.Drawing.Point(29, 143);
            this.txbFechaGastos.Margin = new System.Windows.Forms.Padding(2);
            this.txbFechaGastos.Maxlength = 32767;
            this.txbFechaGastos.Multiline = false;
            this.txbFechaGastos.Name = "txbFechaGastos";
            this.txbFechaGastos.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txbFechaGastos.PasswordChar = false;
            this.txbFechaGastos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbFechaGastos.PlaceholderText = "";
            this.txbFechaGastos.ReadOnly = false;
            this.txbFechaGastos.Size = new System.Drawing.Size(221, 35);
            this.txbFechaGastos.TabIndex = 4;
            this.txbFechaGastos.Texts = "";
            this.txbFechaGastos.UnderlinedStyle = false;
            // 
            // txbValorGastos
            // 
            this.txbValorGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbValorGastos.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbValorGastos.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbValorGastos.BorderRadius = 0;
            this.txbValorGastos.BorderSize = 2;
            this.txbValorGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorGastos.Location = new System.Drawing.Point(29, 28);
            this.txbValorGastos.Margin = new System.Windows.Forms.Padding(2);
            this.txbValorGastos.Maxlength = 32767;
            this.txbValorGastos.Multiline = false;
            this.txbValorGastos.Name = "txbValorGastos";
            this.txbValorGastos.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txbValorGastos.PasswordChar = false;
            this.txbValorGastos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbValorGastos.PlaceholderText = "";
            this.txbValorGastos.ReadOnly = false;
            this.txbValorGastos.Size = new System.Drawing.Size(221, 35);
            this.txbValorGastos.TabIndex = 2;
            this.txbValorGastos.Texts = "";
            this.txbValorGastos.UnderlinedStyle = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(29, 188);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(222, 25);
            this.dtpFecha.TabIndex = 21;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // FormGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(770, 610);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dgvGastos);
            this.Controls.Add(this.btnEditarGastos);
            this.Controls.Add(this.btnEliminarGastos);
            this.Controls.Add(this.btnIngresoGastos);
            this.Controls.Add(this.lblConceptoGasto);
            this.Controls.Add(this.txbConceptoGastos);
            this.Controls.Add(this.lblFechaGastos);
            this.Controls.Add(this.txbFechaGastos);
            this.Controls.Add(this.lblValorGastos);
            this.Controls.Add(this.txbValorGastos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGastos";
            this.Text = "Gastos";
            this.Load += new System.EventHandler(this.FormGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}