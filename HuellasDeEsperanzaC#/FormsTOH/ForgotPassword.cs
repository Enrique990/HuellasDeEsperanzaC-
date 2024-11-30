using HuellasDeEsperanzaC_.Models;
using HuellasDeEsperanzaC_.Servicio;
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
    public partial class ForgotPassword : Form
    {
        private Usuario usuarioActual;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NewPassword newPasswordForm = new NewPassword(usuarioActual, this);
            newPasswordForm.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            string correoElectronico = tbCorreoElectronico.Texts.Trim();
            string respuestaEmergencia = tbPreguntaEmergencia.Texts.Trim();

            if (string.IsNullOrEmpty(correoElectronico) || string.IsNullOrEmpty(respuestaEmergencia))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Usuario> usuarios = new List<Usuario>();
            GestorUsuario gestorUsuario = new GestorUsuario();
            gestorUsuario.CargarDatosUsuarios(usuarios);

            foreach (var usuario in usuarios)
            {
                if (usuario.CorreoElectronico == correoElectronico && usuario.PreguntaEmergencia == respuestaEmergencia)
                {
                    customTextBox1.Texts = usuario.HashContrasena;
                    customTextBox1.Visible = true;
                    return;
                }
            }

            MessageBox.Show("Correo electrónico o respuesta de emergencia incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
