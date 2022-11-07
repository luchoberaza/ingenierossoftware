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
    public partial class FormSoporte : Form
    {
        public FormSoporte()
        {
            InitializeComponent();
        }

        conexionsql sql = new conexionsql();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void FormSoporte_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(0, 0, "https://mail.google.com/mail/u/0/#inbox?compose=CllgCJvnrrXTcwRwDdXhNXLJNTlfRJfTSZThrKnqfTlSvLzxvkFZhbfGPNvXJQlRnxLfCkHWJfL");
        }
    }
}
