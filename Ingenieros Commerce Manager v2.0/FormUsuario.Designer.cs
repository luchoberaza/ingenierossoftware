namespace Ingenieros_Commerce_Manager_v2._0
{
    partial class FormUsuario
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserControl = new System.Windows.Forms.Label();
            this.ImgUser = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.ImgSelect = new System.Windows.Forms.OpenFileDialog();
            this.btnInfo = new CustomControls.RJControls.RJCircularPictureBox();
            this.txbTel = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbDir = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbRUT = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbDenom = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbUsername = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUserID.Location = new System.Drawing.Point(24, 50);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(90, 22);
            this.lblUserID.TabIndex = 6;
            this.lblUserID.Text = "ID de Usuario:";
            // 
            // lblUserControl
            // 
            this.lblUserControl.AutoSize = true;
            this.lblUserControl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserControl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUserControl.Location = new System.Drawing.Point(19, 9);
            this.lblUserControl.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblUserControl.Name = "lblUserControl";
            this.lblUserControl.Size = new System.Drawing.Size(167, 28);
            this.lblUserControl.TabIndex = 11;
            this.lblUserControl.Text = "Control de Usuarios";
            // 
            // ImgUser
            // 
            this.ImgUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgUser.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.galeria;
            this.ImgUser.Location = new System.Drawing.Point(429, 37);
            this.ImgUser.Name = "ImgUser";
            this.ImgUser.Size = new System.Drawing.Size(260, 232);
            this.ImgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgUser.TabIndex = 18;
            this.ImgUser.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLogo.Location = new System.Drawing.Point(435, 6);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(168, 28);
            this.lblLogo.TabIndex = 19;
            this.lblLogo.Text = "Logo de la Empresa";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(429, 275);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 47);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar...";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ImgSelect
            // 
            this.ImgSelect.Filter = "Image Files|*.JPG;*.PNG;*.BMP";
            this.ImgSelect.Title = "Seleccione una imagen";
            // 
            // btnInfo
            // 
            this.btnInfo.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.btnInfo.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnInfo.BorderColor2 = System.Drawing.Color.HotPink;
            this.btnInfo.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.btnInfo.BorderSize = 0;
            this.btnInfo.GradientAngle = 50F;
            this.btnInfo.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.info;
            this.btnInfo.Location = new System.Drawing.Point(280, 175);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(24, 24);
            this.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInfo.TabIndex = 17;
            this.btnInfo.TabStop = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // txbTel
            // 
            this.txbTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbTel.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbTel.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbTel.BorderRadius = 0;
            this.txbTel.BorderSize = 2;
            this.txbTel.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTel.Location = new System.Drawing.Point(24, 350);
            this.txbTel.Multiline = false;
            this.txbTel.Name = "txbTel";
            this.txbTel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbTel.PasswordChar = false;
            this.txbTel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbTel.PlaceholderText = "";
            this.txbTel.Size = new System.Drawing.Size(250, 37);
            this.txbTel.TabIndex = 16;
            this.txbTel.Texts = "";
            this.txbTel.UnderlinedStyle = false;
            // 
            // txbDir
            // 
            this.txbDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbDir.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbDir.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbDir.BorderRadius = 0;
            this.txbDir.BorderSize = 2;
            this.txbDir.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDir.Location = new System.Drawing.Point(24, 290);
            this.txbDir.Multiline = false;
            this.txbDir.Name = "txbDir";
            this.txbDir.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbDir.PasswordChar = false;
            this.txbDir.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbDir.PlaceholderText = "";
            this.txbDir.Size = new System.Drawing.Size(250, 37);
            this.txbDir.TabIndex = 15;
            this.txbDir.Texts = "";
            this.txbDir.UnderlinedStyle = false;
            // 
            // txbRUT
            // 
            this.txbRUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbRUT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbRUT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbRUT.BorderRadius = 0;
            this.txbRUT.BorderSize = 2;
            this.txbRUT.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRUT.Location = new System.Drawing.Point(24, 230);
            this.txbRUT.Multiline = false;
            this.txbRUT.Name = "txbRUT";
            this.txbRUT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbRUT.PasswordChar = false;
            this.txbRUT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbRUT.PlaceholderText = "";
            this.txbRUT.Size = new System.Drawing.Size(250, 37);
            this.txbRUT.TabIndex = 14;
            this.txbRUT.Texts = "";
            this.txbRUT.UnderlinedStyle = false;
            // 
            // txbDenom
            // 
            this.txbDenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbDenom.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbDenom.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbDenom.BorderRadius = 0;
            this.txbDenom.BorderSize = 2;
            this.txbDenom.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDenom.Location = new System.Drawing.Point(24, 170);
            this.txbDenom.Multiline = false;
            this.txbDenom.Name = "txbDenom";
            this.txbDenom.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbDenom.PasswordChar = false;
            this.txbDenom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbDenom.PlaceholderText = "";
            this.txbDenom.Size = new System.Drawing.Size(250, 37);
            this.txbDenom.TabIndex = 13;
            this.txbDenom.Texts = "";
            this.txbDenom.UnderlinedStyle = false;
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbUsername.BorderRadius = 0;
            this.txbUsername.BorderSize = 2;
            this.txbUsername.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(24, 110);
            this.txbUsername.Multiline = false;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbUsername.PasswordChar = false;
            this.txbUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbUsername.PlaceholderText = "";
            this.txbUsername.Size = new System.Drawing.Size(250, 37);
            this.txbUsername.TabIndex = 12;
            this.txbUsername.Texts = "";
            this.txbUsername.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(32, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(32, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Denominación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(32, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "RUT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(32, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(32, 335);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Teléfono";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(770, 610);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.ImgUser);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.txbTel);
            this.Controls.Add(this.txbDir);
            this.Controls.Add(this.txbRUT);
            this.Controls.Add(this.txbDenom);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.lblUserControl);
            this.Controls.Add(this.lblUserID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserControl;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbUsername;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbDenom;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbRUT;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbDir;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbTel;
        private CustomControls.RJControls.RJCircularPictureBox btnInfo;
        private System.Windows.Forms.PictureBox ImgUser;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.OpenFileDialog ImgSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}