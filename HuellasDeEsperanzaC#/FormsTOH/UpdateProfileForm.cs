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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellasDeEsperanzaC_.FormsTOH
{
    public partial class ConfiguracionForm : Form
    {
        private Usuario usuarioActual;
        private GestorUsuario gestorUsuario;
        private GestorAdopcion gestorAdopcionUser;


        public ConfiguracionForm(Usuario usuario, GestorUsuario gestorUsuario, GestorAdopcion gestorAdopcion)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            this.gestorUsuario = gestorUsuario;
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

            if (!ValidarUsuario(correo, numeroTelefono))
            {
                MetroFramework.MetroMessageBox.Show(this, "Los datos ingresados no son válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool hayCambios = false;

            if (nombreCompleto != usuarioActual.NombreCompleto ||
                direccion != usuarioActual.Direccion ||
                numeroTelefono != usuarioActual.NumeroTelefono ||
                numeroCedula != usuarioActual.NumeroCedula ||
                ocupacion != usuarioActual.Ocupacion)
            {
                usuarioActual.NombreCompleto = nombreCompleto;
                usuarioActual.Direccion = direccion;
                usuarioActual.NumeroTelefono = numeroTelefono;
                usuarioActual.NumeroCedula = numeroCedula;
                usuarioActual.Ocupacion = ocupacion;
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

            try
            {
                gestorUsuario.ActualizarUsuarioExistente(usuarioActual);
                gestorUsuario.GuardarArchivoUsuario();
                MetroFramework.MetroMessageBox.Show(this, "Perfil actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Ocurrió un error al actualizar el perfil: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private bool ValidarUsuario(string correo, string numeroTelefono)
        {
            // Validar formato de correo electrónico
            if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return false;
            }

            // Validar formato de número de teléfono
            if (!string.IsNullOrWhiteSpace(numeroTelefono) &&
                !Regex.IsMatch(numeroTelefono, @"^\d{4}-\d{4}$"))
            {
                return false;
            }

            return true;
        }

        // private bool ValidarUsuario(Usuario usuario)
        // {
        //     // Validar campos comunes a todos los usuarios
        //     if (string.IsNullOrWhiteSpace(usuario.CorreoElectronico) ||
        //         string.IsNullOrWhiteSpace(usuario.HashContrasena))
        //     {
        //         return false;
        //     }

        //     // Validar formato de correo electrónico
        //     if (!Regex.IsMatch(usuario.CorreoElectronico, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        //     {
        //         return false;
        //     }

        //     // Validar longitud de la contraseña
        //     if (usuario.HashContrasena.Length > 11)
        //     {
        //         return false;
        //     }

        //     // Validar formato de número de teléfono
        //     if (!string.IsNullOrWhiteSpace(usuario.NumeroTelefono) &&
        //         !Regex.IsMatch(usuario.NumeroTelefono, @"^\d{4}-\d{4}$"))
        //     {
        //         return false;
        //     }

        //     // Validar campos específicos según el tipo de usuario
        //     if (usuario.Tipo == TipoUsuario.Comun)
        //     {
        //         if (string.IsNullOrWhiteSpace(usuario.NombreCompleto))
        //         {
        //             return false;
        //         }
        //     }
        //     else if (usuario.Tipo == TipoUsuario.Organizacion)
        //     {
        //         if (string.IsNullOrWhiteSpace(usuario.NombreOrganizacion) ||
        //             string.IsNullOrWhiteSpace(usuario.Direccion) ||
        //             string.IsNullOrWhiteSpace(usuario.NumeroTelefono) ||
        //             string.IsNullOrWhiteSpace(usuario.Descripcion))
        //         {
        //             return false;
        //         }
        //     }

        //     return true;
        // }

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

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
