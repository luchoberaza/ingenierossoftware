﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenieros_Commerce_Manager_v2._0
{
    public partial class FormResumen : Form
    {
        private ResumenData model;

        public FormResumen()
        {
            InitializeComponent();
            dtpFechaInicio.Value = DateTime.Now.AddDays(-7);
            dtpFechaFin.Value = DateTime.Now;
            btn7dias.Select();

            model = new ResumenData();
            LoadData(dtpFechaInicio.Value, dtpFechaFin.Value);
        }

        private void LoadData(DateTime FechaInicio, DateTime FechaFin)
        {
            var refreshData = model.LoadData(FechaInicio, FechaFin);
            if (refreshData)
            {
                lblVentas.Text = "0" + model.NumVentas.ToString();
                lblIngresos.Text = "$" + model.TotalIngresos.ToString();
                lblGastos.Text = "$" + model.TotalGastos.ToString();
                lblGanancias.Text = "$" + model.TotalGanancias.ToString();

                lblNroClientes.Text = "Nº de Clientes:\n" + model.NumClientes.ToString();
                lblNroProd.Text = "Nº de Productos: " + model.NumProductos.ToString();
                lblNroMatPrim.Text = "Nº de Materias Primas: " + model.NumMatPrims.ToString();

                chartIngresos.DataSource = model.IngresosBrutos;
                chartIngresos.Series[0].XValueMember = "Fecha";
                chartIngresos.Series[0].YValueMembers = "Monto";
                chartIngresos.DataBind();

                chartGastos.DataSource = model.GastosXFecha;
                chartGastos.Series[0].XValueMember = "Fecha";
                chartGastos.Series[0].YValueMembers = "Monto";
                chartGastos.DataBind();
                
                chartProds.DataSource = model.ProductosMasVendidos;
                chartProds.Series[0].XValueMember = "Key";
                chartProds.Series[0].YValueMembers = "Value";
                chartProds.DataBind();

                dgvBajoStock.DataSource = model.ProductosBajoStock;
                dgvBajoStock.Columns["Key"].HeaderText = "Producto";
                dgvBajoStock.Columns["Value"].HeaderText = "Cantidad";
                Console.WriteLine("Vista cargada");
            }
            else
            {
                Console.WriteLine("Vista no cargada");

            }
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            LoadData(DateTime.Today, DateTime.Today);
        }

        private void btn7dias_Click(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Now.AddDays(-7);
            dtpFechaFin.Value = DateTime.Now;
            LoadData(DateTime.Now.AddDays(-7), DateTime.Now);
        }

        private void btn30dias_Click(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Now.AddDays(-30);
            dtpFechaFin.Value = DateTime.Now;
            LoadData(DateTime.Now.AddDays(-30), DateTime.Now);
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpFechaFin.Value = DateTime.Now;
            LoadData(dtpFechaInicio.Value, dtpFechaFin.Value);
        }

        private void btnOKFecha_Click(object sender, EventArgs e)
        {
            LoadData(dtpFechaInicio.Value, dtpFechaFin.Value);
        }

        private void FormResumen_Load(object sender, EventArgs e)
        {
            dgvBajoStock.ClearSelection();
        }
    }
}
