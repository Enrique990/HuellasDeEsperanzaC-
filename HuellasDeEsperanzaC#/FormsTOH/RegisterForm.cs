using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuellasDeEsperanzaC_.FormsTOH;
using HuellasDeEsperanzaC_.Models;
using HuellasDeEsperanzaC_.Servicio;
using MetroFramework;

namespace HuellasDeEsperanzaC_.FormsTOH
{
    public partial class RegisterForm : Form
    {
        GestorUsuario gestorUsuario = new GestorUsuario();

        public RegisterForm()
        {
            InitializeComponent();
            ConfigurarFormularioInicial();
            this.ActiveControl = tbNombreCompleto;
        }

        private void ConfigurarFormularioInicial()
        {
            // Inicialmente, ocultamos los campos adicionales para organizaciones
            MostrarCamposOrganizacion(false);
            AjustarTamañoFormulario(false);
        }

        private void MostrarCamposOrganizacion(bool mostrar)
        {
            lblORA1.Visible = mostrar;
            lblORA2.Visible = mostrar;
            lblORA3.Visible = mostrar;
            tbDireccion.Visible = mostrar;
            tbTelefono.Visible = mostrar;
            tbDescripcion.Visible = mostrar;

            // Ajustar la posición del botón de registro dependiendo de si mostramos los campos adicionales
            roundButton1.Location = mostrar ? new Point(710, 569) : new Point(710, 332);
        }

        private void AjustarTamañoFormulario(bool esOrganizacion)
        {
            this.Size = esOrganizacion ? new Size(902, 653) : new Size(902, 430);
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
            bool esOrganizacion = cbEsORA.Checked;
            MostrarCamposOrganizacion(esOrganizacion);
            AjustarTamañoFormulario(esOrganizacion);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void customTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear el nuevo usuario
                Usuario nuevoUsuario = new Usuario
                {
                    CorreoElectronico = tbEmail.Texts.Trim(),
                    Tipo = cbEsORA.Checked ? TipoUsuario.Organizacion : TipoUsuario.Comun
                };

                // Asignar datos comunes o específicos según el tipo
                if (nuevoUsuario.Tipo == TipoUsuario.Comun)
                {
                    nuevoUsuario.NombreCompleto = tbNombreCompleto.Texts.Trim();
                }
                else if (nuevoUsuario.Tipo == TipoUsuario.Organizacion)
                {
                    nuevoUsuario.NombreOrganizacion = tbNombreCompleto.Texts.Trim();
                    nuevoUsuario.Direccion = tbDireccion.Texts.Trim();
                    nuevoUsuario.NumeroTelefono = tbTelefono.Texts.Trim();
                    nuevoUsuario.Descripcion = tbDescripcion.Texts.Trim();
                }

                // Establecer la contraseña encriptada
                nuevoUsuario.EstablecerContraseña(tbPass.Texts.Trim());

                // Validar y registrar el usuario
                if (!gestorUsuario.ValidarRegistroUsuario(nuevoUsuario))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Por favor complete todos los campos correctamente.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                gestorUsuario.RegistrarUsuario(nuevoUsuario, this, new GestorAdopcion());

                // Redirigir al formulario principal
                HomeGeneralForm homeForm = new HomeGeneralForm(nuevoUsuario, new GestorAdopcion());
                homeForm.Show();
                this.Hide();
            }
            catch (ArgumentException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Ocurrió un error al registrar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void roundButton2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void tbNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbEmail.Focus();
            }
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbPass.Focus();
            }
        }

        private void isORA_Click(object sender, EventArgs e)
        {
            tbDireccion.Focus();
        }

        private void tbOra2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbDescripcion.Focus();
            }
        }

        private void tbOra3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                roundButton1.PerformClick();
            }
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                roundButton1.PerformClick();
            }
        }

        private void tbOra1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbTelefono.Focus();
            }
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
