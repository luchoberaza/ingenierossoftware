namespace Ingenieros_Commerce_Manager_v2._0
{
    partial class FormClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.rjButtonIngresar = new CustomControls.RJControls.RJButton();
            this.rjButtonEditar = new CustomControls.RJControls.RJButton();
            this.customTextBoxNombre = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.customTextBoxDireccion = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customTextBoxTelefono = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customTextBoxSaldo = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rjButtonEliminar = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClientes.ColumnHeadersHeight = 25;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            this.dgvClientes.Location = new System.Drawing.Point(19, 35);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(0);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ShowCellErrors = false;
            this.dgvClientes.Size = new System.Drawing.Size(467, 377);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.Click += new System.EventHandler(this.dgvClientes_Click);
            // 
            // rjButtonIngresar
            // 
            this.rjButtonIngresar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButtonIngresar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButtonIngresar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonIngresar.BorderRadius = 0;
            this.rjButtonIngresar.BorderSize = 0;
            this.rjButtonIngresar.FlatAppearance.BorderSize = 0;
            this.rjButtonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonIngresar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonIngresar.ForeColor = System.Drawing.Color.White;
            this.rjButtonIngresar.Location = new System.Drawing.Point(571, 257);
            this.rjButtonIngresar.Name = "rjButtonIngresar";
            this.rjButtonIngresar.Size = new System.Drawing.Size(150, 39);
            this.rjButtonIngresar.TabIndex = 2;
            this.rjButtonIngresar.Text = "Ingresar";
            this.rjButtonIngresar.TextColor = System.Drawing.Color.White;
            this.rjButtonIngresar.UseVisualStyleBackColor = false;
            this.rjButtonIngresar.Click += new System.EventHandler(this.rjButtonIngresar_Click);
            // 
            // rjButtonEditar
            // 
            this.rjButtonEditar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButtonEditar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButtonEditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonEditar.BorderRadius = 0;
            this.rjButtonEditar.BorderSize = 0;
            this.rjButtonEditar.FlatAppearance.BorderSize = 0;
            this.rjButtonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonEditar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonEditar.ForeColor = System.Drawing.Color.White;
            this.rjButtonEditar.Location = new System.Drawing.Point(571, 314);
            this.rjButtonEditar.Name = "rjButtonEditar";
            this.rjButtonEditar.Size = new System.Drawing.Size(150, 40);
            this.rjButtonEditar.TabIndex = 3;
            this.rjButtonEditar.Text = "Editar";
            this.rjButtonEditar.TextColor = System.Drawing.Color.White;
            this.rjButtonEditar.UseVisualStyleBackColor = false;
            this.rjButtonEditar.Click += new System.EventHandler(this.rjButtonEditar_Click);
            // 
            // customTextBoxNombre
            // 
            this.customTextBoxNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customTextBoxNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBoxNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBoxNombre.BorderRadius = 0;
            this.customTextBoxNombre.BorderSize = 2;
            this.customTextBoxNombre.Location = new System.Drawing.Point(556, 34);
            this.customTextBoxNombre.Maxlength = 32767;
            this.customTextBoxNombre.Multiline = false;
            this.customTextBoxNombre.Name = "customTextBoxNombre";
            this.customTextBoxNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBoxNombre.PasswordChar = false;
            this.customTextBoxNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBoxNombre.PlaceholderText = "";
            this.customTextBoxNombre.Size = new System.Drawing.Size(182, 28);
            this.customTextBoxNombre.TabIndex = 4;
            this.customTextBoxNombre.Texts = "";
            this.customTextBoxNombre.UnderlinedStyle = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelNombre.Location = new System.Drawing.Point(562, 17);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(57, 22);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // customTextBoxDireccion
            // 
            this.customTextBoxDireccion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customTextBoxDireccion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBoxDireccion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBoxDireccion.BorderRadius = 0;
            this.customTextBoxDireccion.BorderSize = 2;
            this.customTextBoxDireccion.Location = new System.Drawing.Point(556, 90);
            this.customTextBoxDireccion.Maxlength = 32767;
            this.customTextBoxDireccion.Multiline = false;
            this.customTextBoxDireccion.Name = "customTextBoxDireccion";
            this.customTextBoxDireccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBoxDireccion.PasswordChar = false;
            this.customTextBoxDireccion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBoxDireccion.PlaceholderText = "";
            this.customTextBoxDireccion.Size = new System.Drawing.Size(182, 28);
            this.customTextBoxDireccion.TabIndex = 6;
            this.customTextBoxDireccion.Texts = "";
            this.customTextBoxDireccion.UnderlinedStyle = false;
            this.customTextBoxDireccion._TextChanged += new System.EventHandler(this.customTextBox1__TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(562, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Direccion";
            // 
            // customTextBoxTelefono
            // 
            this.customTextBoxTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customTextBoxTelefono.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBoxTelefono.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBoxTelefono.BorderRadius = 0;
            this.customTextBoxTelefono.BorderSize = 2;
            this.customTextBoxTelefono.Location = new System.Drawing.Point(556, 149);
            this.customTextBoxTelefono.Maxlength = 32767;
            this.customTextBoxTelefono.Multiline = false;
            this.customTextBoxTelefono.Name = "customTextBoxTelefono";
            this.customTextBoxTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBoxTelefono.PasswordChar = false;
            this.customTextBoxTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBoxTelefono.PlaceholderText = "";
            this.customTextBoxTelefono.Size = new System.Drawing.Size(182, 28);
            this.customTextBoxTelefono.TabIndex = 8;
            this.customTextBoxTelefono.Texts = "";
            this.customTextBoxTelefono.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(562, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Telefono";
            // 
            // customTextBoxSaldo
            // 
            this.customTextBoxSaldo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customTextBoxSaldo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBoxSaldo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBoxSaldo.BorderRadius = 0;
            this.customTextBoxSaldo.BorderSize = 2;
            this.customTextBoxSaldo.Location = new System.Drawing.Point(556, 204);
            this.customTextBoxSaldo.Maxlength = 32767;
            this.customTextBoxSaldo.Multiline = false;
            this.customTextBoxSaldo.Name = "customTextBoxSaldo";
            this.customTextBoxSaldo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBoxSaldo.PasswordChar = false;
            this.customTextBoxSaldo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBoxSaldo.PlaceholderText = "";
            this.customTextBoxSaldo.Size = new System.Drawing.Size(182, 28);
            this.customTextBoxSaldo.TabIndex = 10;
            this.customTextBoxSaldo.Texts = "";
            this.customTextBoxSaldo.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(562, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Saldo";
            // 
            // rjButtonEliminar
            // 
            this.rjButtonEliminar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButtonEliminar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButtonEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonEliminar.BorderRadius = 0;
            this.rjButtonEliminar.BorderSize = 0;
            this.rjButtonEliminar.FlatAppearance.BorderSize = 0;
            this.rjButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonEliminar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonEliminar.ForeColor = System.Drawing.Color.White;
            this.rjButtonEliminar.Location = new System.Drawing.Point(571, 371);
            this.rjButtonEliminar.Name = "rjButtonEliminar";
            this.rjButtonEliminar.Size = new System.Drawing.Size(150, 40);
            this.rjButtonEliminar.TabIndex = 12;
            this.rjButtonEliminar.Text = "Eliminar";
            this.rjButtonEliminar.TextColor = System.Drawing.Color.White;
            this.rjButtonEliminar.UseVisualStyleBackColor = false;
            this.rjButtonEliminar.Click += new System.EventHandler(this.rjButtonEliminar_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rjButtonEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customTextBoxSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customTextBoxTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customTextBoxDireccion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.customTextBoxNombre);
            this.Controls.Add(this.rjButtonEditar);
            this.Controls.Add(this.rjButtonIngresar);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private CustomControls.RJControls.RJButton rjButtonIngresar;
        private CustomControls.RJControls.RJButton rjButtonEditar;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox customTextBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox customTextBoxDireccion;
        private System.Windows.Forms.Label label1;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox customTextBoxTelefono;
        private System.Windows.Forms.Label label2;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox customTextBoxSaldo;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton rjButtonEliminar;
    }
}