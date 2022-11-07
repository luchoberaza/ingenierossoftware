namespace Ingenieros_Commerce_Manager_v2._0
{
    partial class FormResumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResumen));
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblUserControl = new System.Windows.Forms.Label();
            this.gboxDatosFecha = new System.Windows.Forms.GroupBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.btnOKFecha = new CustomControls.RJControls.RJButton();
            this.btnHoy = new CustomControls.RJControls.RJButton();
            this.btn7dias = new CustomControls.RJControls.RJButton();
            this.btn30dias = new CustomControls.RJControls.RJButton();
            this.btnMes = new CustomControls.RJControls.RJButton();
            this.gboxDatosFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaInicio.CalendarForeColor = System.Drawing.SystemColors.ControlDark;
            this.dtpFechaInicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.dtpFechaInicio.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.dtpFechaInicio.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(118, 36);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(539, 25);
            this.dtpFechaInicio.TabIndex = 22;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaFin.CalendarForeColor = System.Drawing.SystemColors.ControlDark;
            this.dtpFechaFin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.dtpFechaFin.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.dtpFechaFin.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(118, 65);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(539, 25);
            this.dtpFechaFin.TabIndex = 23;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // lblUserControl
            // 
            this.lblUserControl.AutoSize = true;
            this.lblUserControl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserControl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUserControl.Location = new System.Drawing.Point(19, 9);
            this.lblUserControl.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblUserControl.Name = "lblUserControl";
            this.lblUserControl.Size = new System.Drawing.Size(86, 28);
            this.lblUserControl.TabIndex = 24;
            this.lblUserControl.Text = "Resumen";
            // 
            // gboxDatosFecha
            // 
            this.gboxDatosFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxDatosFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxDatosFecha.Controls.Add(this.btnMes);
            this.gboxDatosFecha.Controls.Add(this.btnOKFecha);
            this.gboxDatosFecha.Controls.Add(this.btn30dias);
            this.gboxDatosFecha.Controls.Add(this.lblFechaFin);
            this.gboxDatosFecha.Controls.Add(this.lblFechaInicio);
            this.gboxDatosFecha.Controls.Add(this.btn7dias);
            this.gboxDatosFecha.Controls.Add(this.dtpFechaInicio);
            this.gboxDatosFecha.Controls.Add(this.dtpFechaFin);
            this.gboxDatosFecha.Controls.Add(this.btnHoy);
            this.gboxDatosFecha.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDatosFecha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxDatosFecha.Location = new System.Drawing.Point(12, 40);
            this.gboxDatosFecha.Name = "gboxDatosFecha";
            this.gboxDatosFecha.Size = new System.Drawing.Size(746, 157);
            this.gboxDatosFecha.TabIndex = 25;
            this.gboxDatosFecha.TabStop = false;
            this.gboxDatosFecha.Text = "Intervalo";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(15, 39);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(99, 22);
            this.lblFechaInicio.TabIndex = 24;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblFechaFin.Location = new System.Drawing.Point(15, 68);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(75, 22);
            this.lblFechaFin.TabIndex = 25;
            this.lblFechaFin.Text = "Fecha final";
            // 
            // btnOKFecha
            // 
            this.btnOKFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOKFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnOKFecha.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnOKFecha.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOKFecha.BorderRadius = 15;
            this.btnOKFecha.BorderSize = 0;
            this.btnOKFecha.FlatAppearance.BorderSize = 0;
            this.btnOKFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKFecha.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKFecha.ForeColor = System.Drawing.Color.White;
            this.btnOKFecha.Image = global::Ingenieros_Commerce_Manager_v2._0.Properties.Resources.check;
            this.btnOKFecha.Location = new System.Drawing.Point(662, 36);
            this.btnOKFecha.Name = "btnOKFecha";
            this.btnOKFecha.Size = new System.Drawing.Size(59, 54);
            this.btnOKFecha.TabIndex = 26;
            this.btnOKFecha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOKFecha.TextColor = System.Drawing.Color.White;
            this.btnOKFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOKFecha.UseVisualStyleBackColor = false;
            // 
            // btnHoy
            // 
            this.btnHoy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnHoy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnHoy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHoy.BorderRadius = 15;
            this.btnHoy.BorderSize = 0;
            this.btnHoy.FlatAppearance.BorderSize = 0;
            this.btnHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoy.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoy.ForeColor = System.Drawing.Color.White;
            this.btnHoy.Location = new System.Drawing.Point(23, 105);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(168, 37);
            this.btnHoy.TabIndex = 27;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.TextColor = System.Drawing.Color.White;
            this.btnHoy.UseVisualStyleBackColor = false;
            // 
            // btn7dias
            // 
            this.btn7dias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn7dias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btn7dias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btn7dias.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn7dias.BorderRadius = 15;
            this.btn7dias.BorderSize = 0;
            this.btn7dias.FlatAppearance.BorderSize = 0;
            this.btn7dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7dias.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7dias.ForeColor = System.Drawing.Color.White;
            this.btn7dias.Location = new System.Drawing.Point(197, 105);
            this.btn7dias.Name = "btn7dias";
            this.btn7dias.Size = new System.Drawing.Size(168, 37);
            this.btn7dias.TabIndex = 28;
            this.btn7dias.Text = "Últimos 7 días";
            this.btn7dias.TextColor = System.Drawing.Color.White;
            this.btn7dias.UseVisualStyleBackColor = false;
            // 
            // btn30dias
            // 
            this.btn30dias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn30dias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btn30dias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btn30dias.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn30dias.BorderRadius = 15;
            this.btn30dias.BorderSize = 0;
            this.btn30dias.FlatAppearance.BorderSize = 0;
            this.btn30dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn30dias.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30dias.ForeColor = System.Drawing.Color.White;
            this.btn30dias.Location = new System.Drawing.Point(371, 105);
            this.btn30dias.Name = "btn30dias";
            this.btn30dias.Size = new System.Drawing.Size(168, 37);
            this.btn30dias.TabIndex = 29;
            this.btn30dias.Text = "Últimos 30 días";
            this.btn30dias.TextColor = System.Drawing.Color.White;
            this.btn30dias.UseVisualStyleBackColor = false;
            // 
            // btnMes
            // 
            this.btnMes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnMes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnMes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMes.BorderRadius = 15;
            this.btnMes.BorderSize = 0;
            this.btnMes.FlatAppearance.BorderSize = 0;
            this.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMes.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.ForeColor = System.Drawing.Color.White;
            this.btnMes.Location = new System.Drawing.Point(545, 105);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(168, 37);
            this.btnMes.TabIndex = 30;
            this.btnMes.Text = "Este mes";
            this.btnMes.TextColor = System.Drawing.Color.White;
            this.btnMes.UseVisualStyleBackColor = false;
            // 
            // FormResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(770, 610);
            this.Controls.Add(this.gboxDatosFecha);
            this.Controls.Add(this.lblUserControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResumen";
            this.Text = "FormResumen";
            this.gboxDatosFecha.ResumeLayout(false);
            this.gboxDatosFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblUserControl;
        private System.Windows.Forms.GroupBox gboxDatosFecha;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private CustomControls.RJControls.RJButton btnOKFecha;
        private CustomControls.RJControls.RJButton btnHoy;
        private CustomControls.RJControls.RJButton btnMes;
        private CustomControls.RJControls.RJButton btn30dias;
        private CustomControls.RJControls.RJButton btn7dias;
    }
}