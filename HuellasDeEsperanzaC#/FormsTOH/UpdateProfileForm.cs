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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = tbNombreCompleto.Texts.Trim();
            string correo = tbEmail.Texts.Trim();
            string direccion = tbDireccion.Texts.Trim();
            string numeroTelefono = tbNumeroTelefono.Texts.Trim();
            string numeroCedula = tbNumeroCedula.Texts.Trim();
            string ocupacion = tbOcupacion.Texts.Trim();

            if (string.IsNullOrEmpty(nombreCompleto) &&
                string.IsNullOrEmpty(correo) &&
                string.IsNullOrEmpty(direccion) &&
                string.IsNullOrEmpty(numeroTelefono) &&
                string.IsNullOrEmpty(numeroCedula) &&
                string.IsNullOrEmpty(ocupacion))
            {
                MetroFramework.MetroMessageBox.Show(this, "No hay cambios para guardar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool hayCambios = false;

            if (nombreCompleto != usuarioActual.NombreCompleto ||
                direccion != usuarioActual.Direccion ||
                numeroTelefono != usuarioActual.NumeroTelefono ||
                numeroCedula != usuarioActual.NumeroCedula ||
                ocupacion != usuarioActual.Ocupacion)
            {
                usuarioActual.CompletarPerfil(nombreCompleto, direccion, numeroTelefono, numeroCedula, ocupacion);
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
    }
}
