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

namespace HuellasDeEsperanzaC_.FormsTOH
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.ActiveControl = tbNombreCompleto;
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
            // TODO: Verificar si usuario existe

            Usuario usuario = new Usuario();
            GestorUsuario GestorUsuario = new GestorUsuario();

            usuario.NombreCompleto = tbNombreCompleto.Texts;
            usuario.CorreoElectronico = tbEmail.Texts;
            usuario.EstablecerContraseña(tbPass.Texts);

            if (isORA.Checked)
            {
                usuario.Direccion = tbOra1.Texts;
                usuario.NumeroTelefono = tbOra2.Texts;
                usuario.Descripcion = tbOra3.Texts;
                usuario.Tipo = TipoUsuario.Organizacion;
            }
            else
            {
                usuario.Direccion = string.Empty;
                usuario.NumeroTelefono = string.Empty;
                usuario.Descripcion = string.Empty;
                usuario.Tipo = TipoUsuario.Comun;
            }

            if (usuario.NombreCompleto == "" || usuario.CorreoElectronico == "" || usuario.HashContrasena == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isORA.Checked && (usuario.Direccion == "" || usuario.NumeroTelefono == "" || usuario.Descripcion == ""))
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GestorUsuario.RegistrarUsuario(usuario, this);
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
            tbOra1.Focus();
        }

        private void tbOra2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbOra3.Focus();
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
                tbOra2.Focus();
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
    }
}
