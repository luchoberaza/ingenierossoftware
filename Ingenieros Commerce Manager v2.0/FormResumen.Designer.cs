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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResumen));
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.gboxDatosFecha = new System.Windows.Forms.GroupBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.gboxNroVentas = new System.Windows.Forms.GroupBox();
            this.gboxTotalIngresos = new System.Windows.Forms.GroupBox();
            this.gboxTotalGastos = new System.Windows.Forms.GroupBox();
            this.gboxTotalGanancias = new System.Windows.Forms.GroupBox();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblGastos = new System.Windows.Forms.Label();
            this.lblGanancias = new System.Windows.Forms.Label();
            this.chartIngresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gboxBajoStock = new System.Windows.Forms.GroupBox();
            this.dgvBajoStock = new System.Windows.Forms.DataGridView();
            this.gboxInfo = new System.Windows.Forms.GroupBox();
            this.gboxIngresosBrutos = new System.Windows.Forms.GroupBox();
            this.gboxGastos = new System.Windows.Forms.GroupBox();
            this.chartGastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gboxMasVendidos = new System.Windows.Forms.GroupBox();
            this.chartProds = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblNroClientes = new System.Windows.Forms.Label();
            this.lblNroProd = new System.Windows.Forms.Label();
            this.lblNroMatPrim = new System.Windows.Forms.Label();
            this.btnMes = new CustomControls.RJControls.RJButton();
            this.btnOKFecha = new CustomControls.RJControls.RJButton();
            this.btn30dias = new CustomControls.RJControls.RJButton();
            this.btn7dias = new CustomControls.RJControls.RJButton();
            this.btnHoy = new CustomControls.RJControls.RJButton();
            this.gboxDatosFecha.SuspendLayout();
            this.gboxNroVentas.SuspendLayout();
            this.gboxTotalIngresos.SuspendLayout();
            this.gboxTotalGastos.SuspendLayout();
            this.gboxTotalGanancias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).BeginInit();
            this.gboxBajoStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajoStock)).BeginInit();
            this.gboxInfo.SuspendLayout();
            this.gboxIngresosBrutos.SuspendLayout();
            this.gboxGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGastos)).BeginInit();
            this.gboxMasVendidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProds)).BeginInit();
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
            this.dtpFechaInicio.Location = new System.Drawing.Point(118, 29);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(539, 25);
            this.dtpFechaInicio.TabIndex = 22;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaFin.CalendarForeColor = System.Drawing.SystemColors.ControlDark;
            this.dtpFechaFin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.dtpFechaFin.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.dtpFechaFin.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(118, 58);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(539, 25);
            this.dtpFechaFin.TabIndex = 23;
            // 
            // gboxDatosFecha
            // 
            this.gboxDatosFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gboxDatosFecha.Location = new System.Drawing.Point(12, 12);
            this.gboxDatosFecha.Name = "gboxDatosFecha";
            this.gboxDatosFecha.Size = new System.Drawing.Size(746, 140);
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
            this.lblFechaInicio.Location = new System.Drawing.Point(15, 32);
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
            this.lblFechaFin.Location = new System.Drawing.Point(15, 61);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(75, 22);
            this.lblFechaFin.TabIndex = 25;
            this.lblFechaFin.Text = "Fecha final";
            // 
            // gboxNroVentas
            // 
            this.gboxNroVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxNroVentas.Controls.Add(this.lblVentas);
            this.gboxNroVentas.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxNroVentas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxNroVentas.Location = new System.Drawing.Point(12, 158);
            this.gboxNroVentas.Name = "gboxNroVentas";
            this.gboxNroVentas.Size = new System.Drawing.Size(180, 85);
            this.gboxNroVentas.TabIndex = 31;
            this.gboxNroVentas.TabStop = false;
            this.gboxNroVentas.Text = "Número de Ventas";
            // 
            // gboxTotalIngresos
            // 
            this.gboxTotalIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxTotalIngresos.Controls.Add(this.lblIngresos);
            this.gboxTotalIngresos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxTotalIngresos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxTotalIngresos.Location = new System.Drawing.Point(12, 249);
            this.gboxTotalIngresos.Name = "gboxTotalIngresos";
            this.gboxTotalIngresos.Size = new System.Drawing.Size(180, 85);
            this.gboxTotalIngresos.TabIndex = 32;
            this.gboxTotalIngresos.TabStop = false;
            this.gboxTotalIngresos.Text = "Total de Ingresos";
            // 
            // gboxTotalGastos
            // 
            this.gboxTotalGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxTotalGastos.Controls.Add(this.lblGastos);
            this.gboxTotalGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxTotalGastos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxTotalGastos.Location = new System.Drawing.Point(12, 340);
            this.gboxTotalGastos.Name = "gboxTotalGastos";
            this.gboxTotalGastos.Size = new System.Drawing.Size(180, 85);
            this.gboxTotalGastos.TabIndex = 33;
            this.gboxTotalGastos.TabStop = false;
            this.gboxTotalGastos.Text = "Total de Gastos";
            // 
            // gboxTotalGanancias
            // 
            this.gboxTotalGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxTotalGanancias.Controls.Add(this.lblGanancias);
            this.gboxTotalGanancias.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxTotalGanancias.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxTotalGanancias.Location = new System.Drawing.Point(12, 431);
            this.gboxTotalGanancias.Name = "gboxTotalGanancias";
            this.gboxTotalGanancias.Size = new System.Drawing.Size(180, 85);
            this.gboxTotalGanancias.TabIndex = 34;
            this.gboxTotalGanancias.TabStop = false;
            this.gboxTotalGanancias.Text = "Total de Ganancias";
            // 
            // lblVentas
            // 
            this.lblVentas.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblVentas.Location = new System.Drawing.Point(12, 32);
            this.lblVentas.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(155, 28);
            this.lblVentas.TabIndex = 35;
            this.lblVentas.Text = "0";
            // 
            // lblIngresos
            // 
            this.lblIngresos.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIngresos.Location = new System.Drawing.Point(13, 32);
            this.lblIngresos.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(155, 28);
            this.lblIngresos.TabIndex = 36;
            this.lblIngresos.Text = "$";
            // 
            // lblGastos
            // 
            this.lblGastos.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblGastos.Location = new System.Drawing.Point(13, 32);
            this.lblGastos.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(155, 28);
            this.lblGastos.TabIndex = 37;
            this.lblGastos.Text = "$";
            // 
            // lblGanancias
            // 
            this.lblGanancias.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancias.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblGanancias.Location = new System.Drawing.Point(13, 32);
            this.lblGanancias.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(155, 28);
            this.lblGanancias.TabIndex = 38;
            this.lblGanancias.Text = "$";
            // 
            // chartIngresos
            // 
            this.chartIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.chartIngresos.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            chartArea1.Name = "ChartArea1";
            this.chartIngresos.ChartAreas.Add(chartArea1);
            this.chartIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartIngresos.Location = new System.Drawing.Point(3, 21);
            this.chartIngresos.Name = "chartIngresos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chartIngresos.Series.Add(series1);
            this.chartIngresos.Size = new System.Drawing.Size(271, 152);
            this.chartIngresos.TabIndex = 35;
            this.chartIngresos.Text = "chartIngresos";
            // 
            // gboxBajoStock
            // 
            this.gboxBajoStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxBajoStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxBajoStock.Controls.Add(this.dgvBajoStock);
            this.gboxBajoStock.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxBajoStock.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxBajoStock.Location = new System.Drawing.Point(481, 340);
            this.gboxBajoStock.Name = "gboxBajoStock";
            this.gboxBajoStock.Size = new System.Drawing.Size(277, 258);
            this.gboxBajoStock.TabIndex = 38;
            this.gboxBajoStock.TabStop = false;
            this.gboxBajoStock.Text = "Productos con bajo stock";
            // 
            // dgvBajoStock
            // 
            this.dgvBajoStock.AllowUserToAddRows = false;
            this.dgvBajoStock.AllowUserToDeleteRows = false;
            this.dgvBajoStock.AllowUserToOrderColumns = true;
            this.dgvBajoStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBajoStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBajoStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.dgvBajoStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBajoStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBajoStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBajoStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBajoStock.ColumnHeadersHeight = 25;
            this.dgvBajoStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBajoStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBajoStock.EnableHeadersVisualStyles = false;
            this.dgvBajoStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            this.dgvBajoStock.Location = new System.Drawing.Point(3, 21);
            this.dgvBajoStock.Margin = new System.Windows.Forms.Padding(0);
            this.dgvBajoStock.Name = "dgvBajoStock";
            this.dgvBajoStock.ReadOnly = true;
            this.dgvBajoStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBajoStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBajoStock.RowHeadersVisible = false;
            this.dgvBajoStock.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(94)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.dgvBajoStock.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBajoStock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBajoStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBajoStock.ShowCellErrors = false;
            this.dgvBajoStock.Size = new System.Drawing.Size(271, 234);
            this.dgvBajoStock.TabIndex = 4;
            // 
            // gboxInfo
            // 
            this.gboxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gboxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxInfo.Controls.Add(this.lblNroMatPrim);
            this.gboxInfo.Controls.Add(this.lblNroProd);
            this.gboxInfo.Controls.Add(this.lblNroClientes);
            this.gboxInfo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxInfo.Location = new System.Drawing.Point(12, 522);
            this.gboxInfo.Name = "gboxInfo";
            this.gboxInfo.Size = new System.Drawing.Size(459, 76);
            this.gboxInfo.TabIndex = 39;
            this.gboxInfo.TabStop = false;
            this.gboxInfo.Text = "Información";
            // 
            // gboxIngresosBrutos
            // 
            this.gboxIngresosBrutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxIngresosBrutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxIngresosBrutos.Controls.Add(this.chartIngresos);
            this.gboxIngresosBrutos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxIngresosBrutos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxIngresosBrutos.Location = new System.Drawing.Point(198, 158);
            this.gboxIngresosBrutos.Name = "gboxIngresosBrutos";
            this.gboxIngresosBrutos.Size = new System.Drawing.Size(277, 176);
            this.gboxIngresosBrutos.TabIndex = 36;
            this.gboxIngresosBrutos.TabStop = false;
            this.gboxIngresosBrutos.Text = "Ingresos Brutos";
            // 
            // gboxGastos
            // 
            this.gboxGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxGastos.Controls.Add(this.chartGastos);
            this.gboxGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxGastos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxGastos.Location = new System.Drawing.Point(481, 158);
            this.gboxGastos.Name = "gboxGastos";
            this.gboxGastos.Size = new System.Drawing.Size(277, 176);
            this.gboxGastos.TabIndex = 37;
            this.gboxGastos.TabStop = false;
            this.gboxGastos.Text = "Gastos";
            // 
            // chartGastos
            // 
            this.chartGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.chartGastos.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            chartArea2.Name = "ChartArea1";
            this.chartGastos.ChartAreas.Add(chartArea2);
            this.chartGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartGastos.Location = new System.Drawing.Point(3, 21);
            this.chartGastos.Name = "chartGastos";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.chartGastos.Series.Add(series2);
            this.chartGastos.Size = new System.Drawing.Size(271, 152);
            this.chartGastos.TabIndex = 35;
            this.chartGastos.Text = "chartGastos";
            // 
            // gboxMasVendidos
            // 
            this.gboxMasVendidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gboxMasVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxMasVendidos.Controls.Add(this.chartProds);
            this.gboxMasVendidos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxMasVendidos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxMasVendidos.Location = new System.Drawing.Point(198, 340);
            this.gboxMasVendidos.Name = "gboxMasVendidos";
            this.gboxMasVendidos.Size = new System.Drawing.Size(277, 176);
            this.gboxMasVendidos.TabIndex = 38;
            this.gboxMasVendidos.TabStop = false;
            this.gboxMasVendidos.Text = "Productos más vendidos";
            // 
            // chartProds
            // 
            this.chartProds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.chartProds.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            chartArea3.Name = "ChartArea1";
            this.chartProds.ChartAreas.Add(chartArea3);
            this.chartProds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartProds.Location = new System.Drawing.Point(3, 21);
            this.chartProds.Name = "chartProds";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.chartProds.Series.Add(series3);
            this.chartProds.Size = new System.Drawing.Size(271, 152);
            this.chartProds.TabIndex = 35;
            this.chartProds.Text = "chartProds";
            // 
            // lblNroClientes
            // 
            this.lblNroClientes.AutoSize = true;
            this.lblNroClientes.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroClientes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNroClientes.Location = new System.Drawing.Point(311, 25);
            this.lblNroClientes.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblNroClientes.Name = "lblNroClientes";
            this.lblNroClientes.Size = new System.Drawing.Size(94, 22);
            this.lblNroClientes.TabIndex = 38;
            this.lblNroClientes.Text = "Nº de Clientes:";
            // 
            // lblNroProd
            // 
            this.lblNroProd.AutoSize = true;
            this.lblNroProd.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroProd.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNroProd.Location = new System.Drawing.Point(7, 25);
            this.lblNroProd.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblNroProd.Name = "lblNroProd";
            this.lblNroProd.Size = new System.Drawing.Size(107, 22);
            this.lblNroProd.TabIndex = 39;
            this.lblNroProd.Text = "Nº de Productos:";
            // 
            // lblNroMatPrim
            // 
            this.lblNroMatPrim.AutoSize = true;
            this.lblNroMatPrim.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroMatPrim.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNroMatPrim.Location = new System.Drawing.Point(7, 47);
            this.lblNroMatPrim.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblNroMatPrim.Name = "lblNroMatPrim";
            this.lblNroMatPrim.Size = new System.Drawing.Size(140, 22);
            this.lblNroMatPrim.TabIndex = 40;
            this.lblNroMatPrim.Text = "Nº de Materias Primas:";
            // 
            // btnMes
            // 
            this.btnMes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnMes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnMes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMes.BorderRadius = 15;
            this.btnMes.BorderSize = 0;
            this.btnMes.FlatAppearance.BorderSize = 0;
            this.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMes.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.ForeColor = System.Drawing.Color.White;
            this.btnMes.Location = new System.Drawing.Point(552, 92);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(168, 37);
            this.btnMes.TabIndex = 30;
            this.btnMes.Text = "Este mes";
            this.btnMes.TextColor = System.Drawing.Color.White;
            this.btnMes.UseVisualStyleBackColor = false;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btnOKFecha
            // 
            this.btnOKFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.btnOKFecha.Location = new System.Drawing.Point(661, 29);
            this.btnOKFecha.Name = "btnOKFecha";
            this.btnOKFecha.Size = new System.Drawing.Size(54, 54);
            this.btnOKFecha.TabIndex = 26;
            this.btnOKFecha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOKFecha.TextColor = System.Drawing.Color.White;
            this.btnOKFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOKFecha.UseVisualStyleBackColor = false;
            this.btnOKFecha.Click += new System.EventHandler(this.btnOKFecha_Click);
            // 
            // btn30dias
            // 
            this.btn30dias.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn30dias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btn30dias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btn30dias.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn30dias.BorderRadius = 15;
            this.btn30dias.BorderSize = 0;
            this.btn30dias.FlatAppearance.BorderSize = 0;
            this.btn30dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn30dias.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30dias.ForeColor = System.Drawing.Color.White;
            this.btn30dias.Location = new System.Drawing.Point(378, 92);
            this.btn30dias.Name = "btn30dias";
            this.btn30dias.Size = new System.Drawing.Size(168, 37);
            this.btn30dias.TabIndex = 29;
            this.btn30dias.Text = "Últimos 30 días";
            this.btn30dias.TextColor = System.Drawing.Color.White;
            this.btn30dias.UseVisualStyleBackColor = false;
            this.btn30dias.Click += new System.EventHandler(this.btn30dias_Click);
            // 
            // btn7dias
            // 
            this.btn7dias.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn7dias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btn7dias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btn7dias.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn7dias.BorderRadius = 15;
            this.btn7dias.BorderSize = 0;
            this.btn7dias.FlatAppearance.BorderSize = 0;
            this.btn7dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7dias.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7dias.ForeColor = System.Drawing.Color.White;
            this.btn7dias.Location = new System.Drawing.Point(201, 92);
            this.btn7dias.Name = "btn7dias";
            this.btn7dias.Size = new System.Drawing.Size(168, 37);
            this.btn7dias.TabIndex = 28;
            this.btn7dias.Text = "Últimos 7 días";
            this.btn7dias.TextColor = System.Drawing.Color.White;
            this.btn7dias.UseVisualStyleBackColor = false;
            this.btn7dias.Click += new System.EventHandler(this.btn7dias_Click);
            // 
            // btnHoy
            // 
            this.btnHoy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnHoy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(154)))), ((int)(((byte)(234)))));
            this.btnHoy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHoy.BorderRadius = 15;
            this.btnHoy.BorderSize = 0;
            this.btnHoy.FlatAppearance.BorderSize = 0;
            this.btnHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoy.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoy.ForeColor = System.Drawing.Color.White;
            this.btnHoy.Location = new System.Drawing.Point(27, 92);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(168, 37);
            this.btnHoy.TabIndex = 27;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.TextColor = System.Drawing.Color.White;
            this.btnHoy.UseVisualStyleBackColor = false;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // FormResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(770, 610);
            this.Controls.Add(this.gboxMasVendidos);
            this.Controls.Add(this.gboxGastos);
            this.Controls.Add(this.gboxIngresosBrutos);
            this.Controls.Add(this.gboxInfo);
            this.Controls.Add(this.gboxBajoStock);
            this.Controls.Add(this.gboxTotalGanancias);
            this.Controls.Add(this.gboxTotalGastos);
            this.Controls.Add(this.gboxTotalIngresos);
            this.Controls.Add(this.gboxNroVentas);
            this.Controls.Add(this.gboxDatosFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResumen";
            this.Text = "FormResumen";
            this.Load += new System.EventHandler(this.FormResumen_Load);
            this.gboxDatosFecha.ResumeLayout(false);
            this.gboxDatosFecha.PerformLayout();
            this.gboxNroVentas.ResumeLayout(false);
            this.gboxTotalIngresos.ResumeLayout(false);
            this.gboxTotalGastos.ResumeLayout(false);
            this.gboxTotalGanancias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).EndInit();
            this.gboxBajoStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajoStock)).EndInit();
            this.gboxInfo.ResumeLayout(false);
            this.gboxInfo.PerformLayout();
            this.gboxIngresosBrutos.ResumeLayout(false);
            this.gboxGastos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGastos)).EndInit();
            this.gboxMasVendidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.GroupBox gboxDatosFecha;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private CustomControls.RJControls.RJButton btnOKFecha;
        private CustomControls.RJControls.RJButton btnHoy;
        private CustomControls.RJControls.RJButton btnMes;
        private CustomControls.RJControls.RJButton btn30dias;
        private CustomControls.RJControls.RJButton btn7dias;
        private System.Windows.Forms.GroupBox gboxNroVentas;
        private System.Windows.Forms.GroupBox gboxTotalIngresos;
        private System.Windows.Forms.GroupBox gboxTotalGastos;
        private System.Windows.Forms.GroupBox gboxTotalGanancias;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.Label lblGanancias;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIngresos;
        private System.Windows.Forms.GroupBox gboxBajoStock;
        private System.Windows.Forms.DataGridView dgvBajoStock;
        private System.Windows.Forms.GroupBox gboxInfo;
        private System.Windows.Forms.Label lblNroProd;
        private System.Windows.Forms.Label lblNroClientes;
        private System.Windows.Forms.GroupBox gboxIngresosBrutos;
        private System.Windows.Forms.GroupBox gboxGastos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGastos;
        private System.Windows.Forms.GroupBox gboxMasVendidos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProds;
        private System.Windows.Forms.Label lblNroMatPrim;
    }
}