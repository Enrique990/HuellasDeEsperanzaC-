using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
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
            GestorAdopcion gestorAdopcion = new GestorAdopcion();
            GestorUsuario GestorUsuario = new GestorUsuario();

            usuario.NombreCompleto = tbNombreCompleto.Texts;
            usuario.CorreoElectronico = tbEmail.Texts.Trim();
            usuario.EstablecerContraseña(tbPass.Texts.Trim());

            if (usuario.NombreCompleto.Length < 3)
            {
                MetroFramework.MetroMessageBox.Show(this, "El nombre debe tener al menos 3 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Usuario.EsCorreoValido(usuario.CorreoElectronico))
            {
                MetroFramework.MetroMessageBox.Show(this, "El correo electrónico ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if (!Regex.IsMatch(usuario.NombreCompleto, @"^[a-zA-Z\s]+$"))
            {
                MetroFramework.MetroMessageBox.Show(this, "El nombre solo puede contener letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



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

            if (string.IsNullOrWhiteSpace(usuario.NombreCompleto) || string.IsNullOrWhiteSpace(usuario.CorreoElectronico) || string.IsNullOrWhiteSpace(usuario.HashContrasena))
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isORA.Checked && (string.IsNullOrWhiteSpace(usuario.Direccion) || string.IsNullOrWhiteSpace(usuario.NumeroTelefono) || string.IsNullOrWhiteSpace(usuario.Descripcion)))
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GestorUsuario.RegistrarUsuario(usuario, this, gestorAdopcion);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblORA3_Click(object sender, EventArgs e)
        {

        }

        private void lblORA2_Click(object sender, EventArgs e)
        {

        }

        private void lblORA1_Click(object sender, EventArgs e)
        {

        }

        private void tbNombreCompleto__TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail__TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPass__TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOra1__TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOra2__TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOra3__TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
