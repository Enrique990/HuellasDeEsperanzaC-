using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellasDeEsperanzaC_.FormsTOH
{
    public partial class AdminReports : Form
    {
        public AdminReports()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminReports_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
