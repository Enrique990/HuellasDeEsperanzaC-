using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellasDeEsperanzaC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            TabPage currentTab = tabControlMain.SelectedTab;
            Panel scrollablePanel = currentTab.Controls.OfType<Panel>().FirstOrDefault(p => p.AutoScroll);

            if (scrollablePanel != null)
            {
                int newY = scrollablePanel.VerticalScroll.Value - (e.Delta * SystemInformation.MouseWheelScrollLines / 120);

                newY = Math.Max(newY, scrollablePanel.VerticalScroll.Minimum);
                newY = Math.Min(newY, scrollablePanel.VerticalScroll.Maximum);

                scrollablePanel.VerticalScroll.Value = newY;

                scrollablePanel.PerformLayout();
            }
        }

        private void buttonHowToAdopt_Click(object sender, EventArgs e)
        {

        }

        private void panelHowToStart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblWellcom_Click(object sender, EventArgs e)
        {

        }
    }
}
