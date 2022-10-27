using System;
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
    public partial class FormBuscarCliente : Form
    {
        public FormBuscarCliente()
        {
            InitializeComponent();
        }
        //Instancia de clase
        conexionsql sql = new conexionsql();

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = sql.GetClientes();
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
