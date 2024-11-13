using HuellasDeEsperanzaC_.Models;
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
    public partial class HomeGeneralForm : Form
    {
        private Usuario usuarioActual;

        public HomeGeneralForm(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            showUsuario();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdoptMascot adoptMascot = new AdoptMascot(usuarioActual);
            adoptMascot.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        public void showUsuario()
        {
            listBox1.Items.Add(usuarioActual.NombreCompleto);
            listBox1.Items.Add(usuarioActual.CorreoElectronico);
            listBox1.Items.Add(usuarioActual.Tipo);
            listBox1.Items.Add(usuarioActual.NumeroTelefono);
            listBox1.Items.Add(usuarioActual.Descripcion);
            listBox1.Items.Add(usuarioActual.Direccion);
        }

        private void HomeGeneralForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMascot addMascot = new AddMascot(usuarioActual);
            addMascot.Show();
            this.Hide();
        }
    }
}
