namespace Ingenieros_Commerce_Manager_v2._0
{
    partial class FormSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeguridad));
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txbContra = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.btnAceptar = new CustomControls.RJControls.RJButton();
            this.btnCancelar = new CustomControls.RJControls.RJButton();
            this.btnPWDChar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnPWDChar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBusqueda.Location = new System.Drawing.Point(11, 21);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(437, 26);
            this.lblBusqueda.TabIndex = 13;
            this.lblBusqueda.Text = "Ingrese su contraseña para acceder a esta información:";
            // 
            // txbContra
            // 
            this.txbContra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbContra.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbContra.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbContra.BorderRadius = 0;
            this.txbContra.BorderSize = 2;
            this.txbContra.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContra.Location = new System.Drawing.Point(60, 80);
            this.txbContra.Margin = new System.Windows.Forms.Padding(4);
            this.txbContra.Maxlength = 32767;
            this.txbContra.Multiline = false;
            this.txbContra.Name = "txbContra";
            this.txbContra.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txbContra.PasswordChar = true;
            this.txbContra.PlaceholderColor = System.Drawing.Color.Black;
            this.txbContra.PlaceholderText = "";
            this.txbContra.ReadOnly = false;
            this.txbContra.Size = new System.Drawing.Size(312, 45);
            this.txbContra.TabIndex = 17;
            this.txbContra.Texts = "";
            this.txbContra.UnderlinedStyle = false;
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
            this.btnAceptar.Location = new System.Drawing.Point(264, 172);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(184, 34);
            this.btnAceptar.TabIndex = 44;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(72, 172);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(184, 34);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPWDChar
            // 
            this.btnPWDChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPWDChar.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.showpwd;
            this.btnPWDChar.Location = new System.Drawing.Point(378, 92);
            this.btnPWDChar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPWDChar.Name = "btnPWDChar";
            this.btnPWDChar.Size = new System.Drawing.Size(34, 23);
            this.btnPWDChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPWDChar.TabIndex = 46;
            this.btnPWDChar.TabStop = false;
            this.btnPWDChar.Click += new System.EventHandler(this.btnPWDChar_Click);
            // 
            // FormSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(461, 219);
            this.Controls.Add(this.btnPWDChar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txbContra);
            this.Controls.Add(this.lblBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificación";
            ((System.ComponentModel.ISupportInitialize)(this.btnPWDChar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusqueda;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbContra;
        private CustomControls.RJControls.RJButton btnAceptar;
        private CustomControls.RJControls.RJButton btnCancelar;
        private System.Windows.Forms.PictureBox btnPWDChar;
    }
}