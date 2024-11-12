using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuellasDeEsperanzaC_.FormsTOH;
using HuellasDeEsperanzaC_.Models;
using HuellasDeEsperanzaC_.Servicio;

namespace HuellasDeEsperanzaC_.FormsTOH
{
    public partial class LoginForm : Form
    {
        List<Usuario> usuarios = new List<Usuario>();
        GestorUsuario GestorUsuario = new GestorUsuario();

        public LoginForm()
        {
            InitializeComponent();
            this.ActiveControl = tbCorreo;
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            RegisterForm RegisterForm = new RegisterForm();
            RegisterForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            string correoVerificar = tbCorreo.Texts;
            string contrasenaVerificar = tbContrasena.Texts;

            GestorUsuario.CargarDatosUsuarios(usuarios);

            GestorUsuario.VerificarUsuario(correoVerificar, contrasenaVerificar, usuarios, this);

        }

        private void tbCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbContrasena.Focus();
            }
        }

        private void tbContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                roundButton1_Click(sender, e);
            }
        }
    }
}
