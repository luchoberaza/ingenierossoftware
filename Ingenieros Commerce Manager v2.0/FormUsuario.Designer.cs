﻿namespace Ingenieros_Commerce_Manager_v2._0
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
            this.lblUserControl = new System.Windows.Forms.Label();
            this.ImgSelect = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.ImgUser = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPWDChar = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.btnModify = new CustomControls.RJControls.RJButton();
            this.btnSaveChange = new CustomControls.RJControls.RJButton();
            this.btnLogout = new CustomControls.RJControls.RJButton();
            this.tbtnCambioClave = new CustomControls.RJControls.RJToggleButton();
            this.txbRUT = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbUsername = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbClaveNueva = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbDenom = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbClaveActual = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.txbDir = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            this.btnInfo = new CustomControls.RJControls.RJCircularPictureBox();
            this.txbTel = new Ingenieros_Commerce_Manager.CustomControls.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPWDChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserControl
            // 
            this.lblUserControl.AutoSize = true;
            this.lblUserControl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserControl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUserControl.Location = new System.Drawing.Point(25, 11);
            this.lblUserControl.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblUserControl.Name = "lblUserControl";
            this.lblUserControl.Size = new System.Drawing.Size(210, 36);
            this.lblUserControl.TabIndex = 11;
            this.lblUserControl.Text = "Control de Usuarios";
            // 
            // ImgSelect
            // 
            this.ImgSelect.AddExtension = false;
            this.ImgSelect.Filter = "Image Files *.JPG;*.PNG;*.BMP|*.JPG;*.PNG;*.BMP";
            this.ImgSelect.Title = "Seleccione una imagen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(43, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "Contraseña nueva";
            this.label6.Visible = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLogo.Location = new System.Drawing.Point(25, 421);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(212, 36);
            this.lblLogo.TabIndex = 19;
            this.lblLogo.Text = "Logo de la Empresa";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUserID.Location = new System.Drawing.Point(27, 59);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(115, 26);
            this.lblUserID.TabIndex = 6;
            this.lblUserID.Text = "ID de Usuario:";
            // 
            // ImgUser
            // 
            this.ImgUser.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.galeria;
            this.ImgUser.Location = new System.Drawing.Point(32, 459);
            this.ImgUser.Margin = new System.Windows.Forms.Padding(4);
            this.ImgUser.Name = "ImgUser";
            this.ImgUser.Size = new System.Drawing.Size(183, 167);
            this.ImgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgUser.TabIndex = 18;
            this.ImgUser.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(43, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 26);
            this.label7.TabIndex = 28;
            this.label7.Text = "Contraseña actual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(476, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(476, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(476, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "RUT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(43, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(476, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Denominación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(25, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 36);
            this.label8.TabIndex = 31;
            this.label8.Text = "Cambio de contraseña";
            // 
            // btnPWDChar
            // 
            this.btnPWDChar.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.showpwd;
            this.btnPWDChar.Location = new System.Drawing.Point(373, 203);
            this.btnPWDChar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPWDChar.Name = "btnPWDChar";
            this.btnPWDChar.Size = new System.Drawing.Size(41, 28);
            this.btnPWDChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPWDChar.TabIndex = 36;
            this.btnPWDChar.TabStop = false;
            this.btnPWDChar.Click += new System.EventHandler(this.btnPWDChar_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(652, 713);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(345, 26);
            this.label9.TabIndex = 37;
            this.label9.Text = "Ingenieros Commerce Manager versión 1.0.0";
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.rjButton1.BorderColor = System.Drawing.Color.Peru;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.Location = new System.Drawing.Point(853, 12);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(162, 44);
            this.rjButton1.TabIndex = 41;
            this.rjButton1.Text = "Soporte";
            this.rjButton1.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnModify.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnModify.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModify.BorderRadius = 10;
            this.btnModify.BorderSize = 0;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(32, 634);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(145, 34);
            this.btnModify.TabIndex = 39;
            this.btnModify.Text = "Modificar...";
            this.btnModify.TextColor = System.Drawing.Color.White;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnSaveChange.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnSaveChange.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSaveChange.BorderRadius = 10;
            this.btnSaveChange.BorderSize = 0;
            this.btnSaveChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChange.FlatAppearance.BorderSize = 0;
            this.btnSaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChange.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChange.ForeColor = System.Drawing.Color.White;
            this.btnSaveChange.Location = new System.Drawing.Point(423, 11);
            this.btnSaveChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(184, 34);
            this.btnSaveChange.TabIndex = 38;
            this.btnSaveChange.Text = "Guardar cambios";
            this.btnSaveChange.TextColor = System.Drawing.Color.White;
            this.btnSaveChange.UseVisualStyleBackColor = false;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnLogout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(269, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(145, 34);
            this.btnLogout.TabIndex = 35;
            this.btnLogout.Text = "Cerrar sesión";
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tbtnCambioClave
            // 
            this.tbtnCambioClave.AutoSize = true;
            this.tbtnCambioClave.Location = new System.Drawing.Point(305, 359);
            this.tbtnCambioClave.Margin = new System.Windows.Forms.Padding(4);
            this.tbtnCambioClave.MinimumSize = new System.Drawing.Size(60, 27);
            this.tbtnCambioClave.Name = "tbtnCambioClave";
            this.tbtnCambioClave.OffBackColor = System.Drawing.Color.Gray;
            this.tbtnCambioClave.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbtnCambioClave.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbtnCambioClave.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbtnCambioClave.Size = new System.Drawing.Size(60, 27);
            this.tbtnCambioClave.TabIndex = 30;
            this.tbtnCambioClave.UseVisualStyleBackColor = true;
            this.tbtnCambioClave.CheckedChanged += new System.EventHandler(this.tbtnCambioClave_CheckedChanged);
            // 
            // txbRUT
            // 
            this.txbRUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbRUT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbRUT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbRUT.BorderRadius = 0;
            this.txbRUT.BorderSize = 2;
            this.txbRUT.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRUT.Location = new System.Drawing.Point(465, 197);
            this.txbRUT.Margin = new System.Windows.Forms.Padding(4);
            this.txbRUT.Maxlength = 12;
            this.txbRUT.Multiline = false;
            this.txbRUT.Name = "txbRUT";
            this.txbRUT.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txbRUT.PasswordChar = false;
            this.txbRUT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbRUT.PlaceholderText = "";
            this.txbRUT.ReadOnly = false;
            this.txbRUT.Size = new System.Drawing.Size(333, 45);
            this.txbRUT.TabIndex = 14;
            this.txbRUT.Texts = "";
            this.txbRUT.UnderlinedStyle = false;
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbUsername.BorderRadius = 0;
            this.txbUsername.BorderSize = 2;
            this.txbUsername.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(32, 123);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txbUsername.Maxlength = 32767;
            this.txbUsername.Multiline = false;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txbUsername.PasswordChar = false;
            this.txbUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbUsername.PlaceholderText = "";
            this.txbUsername.ReadOnly = false;
            this.txbUsername.Size = new System.Drawing.Size(333, 45);
            this.txbUsername.TabIndex = 12;
            this.txbUsername.Texts = "";
            this.txbUsername.UnderlinedStyle = false;
            // 
            // txbClaveNueva
            // 
            this.txbClaveNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbClaveNueva.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbClaveNueva.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbClaveNueva.BorderRadius = 0;
            this.txbClaveNueva.BorderSize = 2;
            this.txbClaveNueva.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbClaveNueva.Location = new System.Drawing.Point(32, 271);
            this.txbClaveNueva.Margin = new System.Windows.Forms.Padding(4);
            this.txbClaveNueva.Maxlength = 32767;
            this.txbClaveNueva.Multiline = false;
            this.txbClaveNueva.Name = "txbClaveNueva";
            this.txbClaveNueva.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txbClaveNueva.PasswordChar = true;
            this.txbClaveNueva.PlaceholderColor = System.Drawing.Color.Black;
            this.txbClaveNueva.PlaceholderText = "";
            this.txbClaveNueva.ReadOnly = false;
            this.txbClaveNueva.Size = new System.Drawing.Size(333, 45);
            this.txbClaveNueva.TabIndex = 27;
            this.txbClaveNueva.Texts = "";
            this.txbClaveNueva.UnderlinedStyle = false;
            this.txbClaveNueva.Visible = false;
            // 
            // txbDenom
            // 
            this.txbDenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbDenom.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbDenom.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbDenom.BorderRadius = 0;
            this.txbDenom.BorderSize = 2;
            this.txbDenom.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDenom.Location = new System.Drawing.Point(465, 123);
            this.txbDenom.Margin = new System.Windows.Forms.Padding(4);
            this.txbDenom.Maxlength = 32767;
            this.txbDenom.Multiline = false;
            this.txbDenom.Name = "txbDenom";
            this.txbDenom.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txbDenom.PasswordChar = false;
            this.txbDenom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbDenom.PlaceholderText = "";
            this.txbDenom.ReadOnly = false;
            this.txbDenom.Size = new System.Drawing.Size(333, 45);
            this.txbDenom.TabIndex = 13;
            this.txbDenom.Texts = "";
            this.txbDenom.UnderlinedStyle = false;
            // 
            // txbClaveActual
            // 
            this.txbClaveActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbClaveActual.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbClaveActual.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbClaveActual.BorderRadius = 0;
            this.txbClaveActual.BorderSize = 2;
            this.txbClaveActual.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbClaveActual.Location = new System.Drawing.Point(32, 197);
            this.txbClaveActual.Margin = new System.Windows.Forms.Padding(4);
            this.txbClaveActual.Maxlength = 32767;
            this.txbClaveActual.Multiline = false;
            this.txbClaveActual.Name = "txbClaveActual";
            this.txbClaveActual.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txbClaveActual.PasswordChar = true;
            this.txbClaveActual.PlaceholderColor = System.Drawing.Color.Black;
            this.txbClaveActual.PlaceholderText = "";
            this.txbClaveActual.ReadOnly = false;
            this.txbClaveActual.Size = new System.Drawing.Size(333, 45);
            this.txbClaveActual.TabIndex = 26;
            this.txbClaveActual.Texts = "";
            this.txbClaveActual.UnderlinedStyle = false;
            // 
            // txbDir
            // 
            this.txbDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.txbDir.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbDir.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbDir.BorderRadius = 0;
            this.txbDir.BorderSize = 2;
            this.txbDir.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDir.Location = new System.Drawing.Point(465, 271);
            this.txbDir.Margin = new System.Windows.Forms.Padding(4);
            this.txbDir.Maxlength = 32767;
            this.txbDir.Multiline = false;
            this.txbDir.Name = "txbDir";
            this.txbDir.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txbDir.PasswordChar = false;
            this.txbDir.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbDir.PlaceholderText = "";
            this.txbDir.ReadOnly = false;
            this.txbDir.Size = new System.Drawing.Size(333, 45);
            this.txbDir.TabIndex = 15;
            this.txbDir.Texts = "";
            this.txbDir.UnderlinedStyle = false;
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
            this.btnInfo.Location = new System.Drawing.Point(807, 129);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(32, 32);
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
            this.txbTel.Location = new System.Drawing.Point(465, 345);
            this.txbTel.Margin = new System.Windows.Forms.Padding(4);
            this.txbTel.Maxlength = 32767;
            this.txbTel.Multiline = false;
            this.txbTel.Name = "txbTel";
            this.txbTel.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txbTel.PasswordChar = false;
            this.txbTel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbTel.PlaceholderText = "";
            this.txbTel.ReadOnly = false;
            this.txbTel.Size = new System.Drawing.Size(333, 45);
            this.txbTel.TabIndex = 16;
            this.txbTel.Texts = "";
            this.txbTel.UnderlinedStyle = false;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1027, 751);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPWDChar);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbtnCambioClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbRUT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblUserControl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ImgUser);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.txbClaveNueva);
            this.Controls.Add(this.txbDenom);
            this.Controls.Add(this.txbClaveActual);
            this.Controls.Add(this.txbDir);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.txbTel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPWDChar)).EndInit();
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
        private System.Windows.Forms.OpenFileDialog ImgSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbClaveNueva;
        private Ingenieros_Commerce_Manager.CustomControls.CustomTextBox txbClaveActual;
        private CustomControls.RJControls.RJToggleButton tbtnCambioClave;
        private System.Windows.Forms.Label label8;
        private CustomControls.RJControls.RJButton btnLogout;
        private System.Windows.Forms.PictureBox btnPWDChar;
        private System.Windows.Forms.Label label9;
        private CustomControls.RJControls.RJButton btnSaveChange;
        private CustomControls.RJControls.RJButton btnModify;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}