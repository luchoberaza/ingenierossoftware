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
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.gboxNroVentas = new System.Windows.Forms.GroupBox();
            this.lblVentas = new System.Windows.Forms.Label();
            this.gboxTotalIngresos = new System.Windows.Forms.GroupBox();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.gboxTotalGastos = new System.Windows.Forms.GroupBox();
            this.lblGastos = new System.Windows.Forms.Label();
            this.gboxTotalGanancias = new System.Windows.Forms.GroupBox();
            this.lblGanancias = new System.Windows.Forms.Label();
            this.chartIngresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gboxBajoStock = new System.Windows.Forms.GroupBox();
            this.dgvBajoStock = new System.Windows.Forms.DataGridView();
            this.gboxInfo = new System.Windows.Forms.GroupBox();
            this.lblNroMatPrim = new System.Windows.Forms.Label();
            this.lblNroProd = new System.Windows.Forms.Label();
            this.lblNroClientes = new System.Windows.Forms.Label();
            this.gboxIngresosBrutos = new System.Windows.Forms.GroupBox();
            this.gboxGastos = new System.Windows.Forms.GroupBox();
            this.chartGastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gboxMasVendidos = new System.Windows.Forms.GroupBox();
            this.chartProds = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.dtpFechaInicio.Location = new System.Drawing.Point(157, 36);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(748, 30);
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
            this.dtpFechaFin.Location = new System.Drawing.Point(157, 71);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(748, 30);
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
            this.gboxDatosFecha.Location = new System.Drawing.Point(16, 15);
            this.gboxDatosFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxDatosFecha.Name = "gboxDatosFecha";
            this.gboxDatosFecha.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxDatosFecha.Size = new System.Drawing.Size(999, 172);
            this.gboxDatosFecha.TabIndex = 25;
            this.gboxDatosFecha.TabStop = false;
            this.gboxDatosFecha.Text = "Intervalo";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblFechaFin.Location = new System.Drawing.Point(20, 75);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(95, 26);
            this.lblFechaFin.TabIndex = 25;
            this.lblFechaFin.Text = "Fecha final";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(20, 39);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(126, 26);
            this.lblFechaInicio.TabIndex = 24;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // gboxNroVentas
            // 
            this.gboxNroVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxNroVentas.Controls.Add(this.lblVentas);
            this.gboxNroVentas.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxNroVentas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxNroVentas.Location = new System.Drawing.Point(16, 194);
            this.gboxNroVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxNroVentas.Name = "gboxNroVentas";
            this.gboxNroVentas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxNroVentas.Size = new System.Drawing.Size(240, 105);
            this.gboxNroVentas.TabIndex = 31;
            this.gboxNroVentas.TabStop = false;
            this.gboxNroVentas.Text = "Número de Ventas";
            // 
            // lblVentas
            // 
            this.lblVentas.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblVentas.Location = new System.Drawing.Point(16, 39);
            this.lblVentas.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(207, 34);
            this.lblVentas.TabIndex = 35;
            this.lblVentas.Text = "0";
            // 
            // gboxTotalIngresos
            // 
            this.gboxTotalIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxTotalIngresos.Controls.Add(this.lblIngresos);
            this.gboxTotalIngresos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxTotalIngresos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxTotalIngresos.Location = new System.Drawing.Point(16, 306);
            this.gboxTotalIngresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxTotalIngresos.Name = "gboxTotalIngresos";
            this.gboxTotalIngresos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxTotalIngresos.Size = new System.Drawing.Size(240, 105);
            this.gboxTotalIngresos.TabIndex = 32;
            this.gboxTotalIngresos.TabStop = false;
            this.gboxTotalIngresos.Text = "Total de Ingresos";
            // 
            // lblIngresos
            // 
            this.lblIngresos.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIngresos.Location = new System.Drawing.Point(17, 39);
            this.lblIngresos.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(207, 34);
            this.lblIngresos.TabIndex = 36;
            this.lblIngresos.Text = "$";
            // 
            // gboxTotalGastos
            // 
            this.gboxTotalGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxTotalGastos.Controls.Add(this.lblGastos);
            this.gboxTotalGastos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxTotalGastos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxTotalGastos.Location = new System.Drawing.Point(16, 418);
            this.gboxTotalGastos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxTotalGastos.Name = "gboxTotalGastos";
            this.gboxTotalGastos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxTotalGastos.Size = new System.Drawing.Size(240, 105);
            this.gboxTotalGastos.TabIndex = 33;
            this.gboxTotalGastos.TabStop = false;
            this.gboxTotalGastos.Text = "Total de Gastos";
            // 
            // lblGastos
            // 
            this.lblGastos.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblGastos.Location = new System.Drawing.Point(17, 39);
            this.lblGastos.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(207, 34);
            this.lblGastos.TabIndex = 37;
            this.lblGastos.Text = "$";
            // 
            // gboxTotalGanancias
            // 
            this.gboxTotalGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxTotalGanancias.Controls.Add(this.lblGanancias);
            this.gboxTotalGanancias.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxTotalGanancias.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxTotalGanancias.Location = new System.Drawing.Point(16, 530);
            this.gboxTotalGanancias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxTotalGanancias.Name = "gboxTotalGanancias";
            this.gboxTotalGanancias.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxTotalGanancias.Size = new System.Drawing.Size(240, 105);
            this.gboxTotalGanancias.TabIndex = 34;
            this.gboxTotalGanancias.TabStop = false;
            this.gboxTotalGanancias.Text = "Total de Ganancias";
            // 
            // lblGanancias
            // 
            this.lblGanancias.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancias.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblGanancias.Location = new System.Drawing.Point(17, 39);
            this.lblGanancias.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(207, 34);
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
            this.chartIngresos.Location = new System.Drawing.Point(4, 27);
            this.chartIngresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartIngresos.Name = "chartIngresos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chartIngresos.Series.Add(series1);
            this.chartIngresos.Size = new System.Drawing.Size(388, 410);
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
            this.gboxBajoStock.Location = new System.Drawing.Point(669, 643);
            this.gboxBajoStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxBajoStock.Name = "gboxBajoStock";
            this.gboxBajoStock.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxBajoStock.Size = new System.Drawing.Size(346, 219);
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
            this.dgvBajoStock.Location = new System.Drawing.Point(4, 27);
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
            this.dgvBajoStock.Size = new System.Drawing.Size(338, 188);
            this.dgvBajoStock.TabIndex = 4;
            // 
            // gboxInfo
            // 
            this.gboxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gboxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxInfo.Controls.Add(this.lblNroMatPrim);
            this.gboxInfo.Controls.Add(this.lblNroProd);
            this.gboxInfo.Controls.Add(this.lblNroClientes);
            this.gboxInfo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxInfo.Location = new System.Drawing.Point(16, 643);
            this.gboxInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxInfo.Name = "gboxInfo";
            this.gboxInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxInfo.Size = new System.Drawing.Size(240, 219);
            this.gboxInfo.TabIndex = 39;
            this.gboxInfo.TabStop = false;
            this.gboxInfo.Text = "Información";
            // 
            // lblNroMatPrim
            // 
            this.lblNroMatPrim.AutoSize = true;
            this.lblNroMatPrim.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroMatPrim.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNroMatPrim.Location = new System.Drawing.Point(9, 81);
            this.lblNroMatPrim.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblNroMatPrim.Name = "lblNroMatPrim";
            this.lblNroMatPrim.Size = new System.Drawing.Size(181, 26);
            this.lblNroMatPrim.TabIndex = 40;
            this.lblNroMatPrim.Text = "Nº de Materias Primas:";
            // 
            // lblNroProd
            // 
            this.lblNroProd.AutoSize = true;
            this.lblNroProd.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroProd.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNroProd.Location = new System.Drawing.Point(9, 31);
            this.lblNroProd.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblNroProd.Name = "lblNroProd";
            this.lblNroProd.Size = new System.Drawing.Size(137, 26);
            this.lblNroProd.TabIndex = 39;
            this.lblNroProd.Text = "Nº de Productos:";
            // 
            // lblNroClientes
            // 
            this.lblNroClientes.AutoSize = true;
            this.lblNroClientes.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroClientes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNroClientes.Location = new System.Drawing.Point(9, 132);
            this.lblNroClientes.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblNroClientes.Name = "lblNroClientes";
            this.lblNroClientes.Size = new System.Drawing.Size(121, 26);
            this.lblNroClientes.TabIndex = 38;
            this.lblNroClientes.Text = "Nº de Clientes:";
            // 
            // gboxIngresosBrutos
            // 
            this.gboxIngresosBrutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxIngresosBrutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxIngresosBrutos.Controls.Add(this.chartIngresos);
            this.gboxIngresosBrutos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxIngresosBrutos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxIngresosBrutos.Location = new System.Drawing.Point(264, 194);
            this.gboxIngresosBrutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxIngresosBrutos.Name = "gboxIngresosBrutos";
            this.gboxIngresosBrutos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxIngresosBrutos.Size = new System.Drawing.Size(396, 441);
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
            this.gboxGastos.Location = new System.Drawing.Point(669, 194);
            this.gboxGastos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxGastos.Name = "gboxGastos";
            this.gboxGastos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxGastos.Size = new System.Drawing.Size(346, 441);
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
            this.chartGastos.Location = new System.Drawing.Point(4, 27);
            this.chartGastos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartGastos.Name = "chartGastos";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.chartGastos.Series.Add(series2);
            this.chartGastos.Size = new System.Drawing.Size(338, 410);
            this.chartGastos.TabIndex = 35;
            this.chartGastos.Text = "chartGastos";
            // 
            // gboxMasVendidos
            // 
            this.gboxMasVendidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gboxMasVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxMasVendidos.Controls.Add(this.chartProds);
            this.gboxMasVendidos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxMasVendidos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gboxMasVendidos.Location = new System.Drawing.Point(264, 643);
            this.gboxMasVendidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxMasVendidos.Name = "gboxMasVendidos";
            this.gboxMasVendidos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxMasVendidos.Size = new System.Drawing.Size(397, 219);
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
            this.chartProds.Location = new System.Drawing.Point(4, 27);
            this.chartProds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartProds.Name = "chartProds";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.chartProds.Series.Add(series3);
            this.chartProds.Size = new System.Drawing.Size(389, 188);
            this.chartProds.TabIndex = 35;
            this.chartProds.Text = "chartProds";
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
            this.btnMes.Location = new System.Drawing.Point(751, 113);
            this.btnMes.Margin = new System.Windows.Forms.Padding(4);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(224, 46);
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
            this.btnOKFecha.Location = new System.Drawing.Point(912, 36);
            this.btnOKFecha.Margin = new System.Windows.Forms.Padding(4);
            this.btnOKFecha.Name = "btnOKFecha";
            this.btnOKFecha.Size = new System.Drawing.Size(72, 66);
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
            this.btn30dias.Location = new System.Drawing.Point(519, 113);
            this.btn30dias.Margin = new System.Windows.Forms.Padding(4);
            this.btn30dias.Name = "btn30dias";
            this.btn30dias.Size = new System.Drawing.Size(224, 46);
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
            this.btn7dias.Location = new System.Drawing.Point(283, 113);
            this.btn7dias.Margin = new System.Windows.Forms.Padding(4);
            this.btn7dias.Name = "btn7dias";
            this.btn7dias.Size = new System.Drawing.Size(224, 46);
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
            this.btnHoy.Location = new System.Drawing.Point(51, 113);
            this.btnHoy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(224, 46);
            this.btnHoy.TabIndex = 27;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.TextColor = System.Drawing.Color.White;
            this.btnHoy.UseVisualStyleBackColor = false;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // FormResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1027, 888);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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