using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuellasDeEsperanzaC_.FormsTOH;

namespace HuellasDeEsperanzaC_.FormsTOH
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.Size = new Size(902, 430);
            roundButton1.Location = new Point(710, 332);
            
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (isORA.Checked)
            {
                this.Size = new Size(902, 653);
                lblORA1.Visible = true;
                lblORA2.Visible = true;
                lblORA3.Visible = true;
                tbOra1.Visible = true;
                tbOra2.Visible = true;
                tbOra3.Visible = true;
                roundButton1.Location = new Point(710, 569);
            }
            else
            {
                this.Size = new Size(902, 430);
                lblORA1.Visible = false;
                lblORA2.Visible = false;
                lblORA3.Visible = false;
                tbOra1.Visible = false;
                tbOra2.Visible = false;
                tbOra3.Visible = false;
                roundButton1.Location = new Point(710, 332);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void customTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
