using HuellasDeEsperanzaC_.Models;
using HuellasDeEsperanzaC_.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HuellasDeEsperanzaC_.FormsTOH
{
    public partial class ConfiguracionForm : Form
    {
        private Usuario usuarioActual;
        private GestorAdopcion gestorAdopcionUser;  

        public ConfiguracionForm(Usuario usuario, GestorAdopcion gestorAdopcion)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            this.gestorAdopcionUser = gestorAdopcion;
            MostrarDatosUsuario();
        }

        private void MostrarDatosUsuario()
        {
            tbNombreCompleto.Texts = usuarioActual.NombreCompleto;
            tbEmail.Texts = usuarioActual.CorreoElectronico;
            tbDireccion.Texts = usuarioActual.Direccion;
            tbNumeroTelefono.Texts = usuarioActual.NumeroTelefono;
            tbNumeroCedula.Texts = usuarioActual.NumeroCedula;
            tbOcupacion.Texts = usuarioActual.Ocupacion;
            tbPreguntaEmergencia.Texts = usuarioActual.PreguntaEmergencia;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = tbNombreCompleto.Texts;
            string correo = tbEmail.Texts.Trim();
            string direccion = tbDireccion.Texts;
            string numeroTelefono = tbNumeroTelefono.Texts.Trim();
            string numeroCedula = tbNumeroCedula.Texts.Trim();
            string ocupacion = tbOcupacion.Texts;
            string preguntaEmergencia = tbPreguntaEmergencia.Texts;

            if (string.IsNullOrEmpty(nombreCompleto) &&
                string.IsNullOrEmpty(correo) &&
                string.IsNullOrEmpty(direccion) &&
                string.IsNullOrEmpty(numeroTelefono) &&
                string.IsNullOrEmpty(numeroCedula) &&
                string.IsNullOrEmpty(ocupacion) &&
                string.IsNullOrEmpty(preguntaEmergencia))
            {
                MetroFramework.MetroMessageBox.Show(this, "No hay cambios para guardar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nombreCompleto.Length < 3)
            {
                MetroFramework.MetroMessageBox.Show(this, "El nombre debe tener al menos 3 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Usuario.EsCorreoValido(correo))
            {
                MetroFramework.MetroMessageBox.Show(this, "El correo electrónico ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.IsMatch(nombreCompleto, @"^[a-zA-Z\s]+$"))
            {
                MetroFramework.MetroMessageBox.Show(this, "El nombre solo puede contener letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool hayCambios = false;

            if (nombreCompleto != usuarioActual.NombreCompleto ||
                direccion != usuarioActual.Direccion ||
                numeroTelefono != usuarioActual.NumeroTelefono ||
                numeroCedula != usuarioActual.NumeroCedula ||
                ocupacion != usuarioActual.Ocupacion ||
                preguntaEmergencia != usuarioActual.PreguntaEmergencia)
            {
                usuarioActual.CompletarPerfil(nombreCompleto, direccion, numeroTelefono, numeroCedula, ocupacion);
                usuarioActual.PreguntaEmergencia = preguntaEmergencia;
                hayCambios = true;
            }

            if (correo != usuarioActual.CorreoElectronico)
            {
                usuarioActual.CorreoElectronico = correo;
                hayCambios = true;
            }

            if (!hayCambios)
            {
                MetroFramework.MetroMessageBox.Show(this, "No hay cambios para guardar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            GestorUsuario gestorUsuario = new GestorUsuario();
            gestorUsuario.ActualizarUsuario(usuarioActual, this, gestorAdopcionUser);

            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            HomeGeneralForm homeForm = new HomeGeneralForm(usuarioActual, gestorAdopcionUser);
            homeForm.Show();
            this.Close();
        }

        // Constantes para manejar el arrastre de la ventana
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        // Método para permitir arrastrar la ventana desde el panel2
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            // Libera el control del mouse
            ReleaseCapture();
            // Envía un mensaje para iniciar el arrastre de la ventana
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNumeroTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void lblOcupacion_Click(object sender, EventArgs e)
        {

        }

        private void lblNumeroCedula_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdoptMascot adoptMascot = new AdoptMascot(usuarioActual, gestorAdopcionUser);
            adoptMascot.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMascot addMascot = new AddMascot(usuarioActual, gestorAdopcionUser);
            addMascot.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeGeneralForm homeGeneralForm = new HomeGeneralForm(usuarioActual, gestorAdopcionUser);
            homeGeneralForm.Show();
            this.Close();
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPasswordForm = new ForgotPassword();
            NewPassword newPasswordForm = new NewPassword(usuarioActual, forgotPasswordForm);
            newPasswordForm.Show();
            this.Close();
        }
    }
}
