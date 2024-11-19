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
    public partial class LoginForm : Form
    {
        List<Usuario> usuarios = new List<Usuario>();
        GestorAdopcion GestorAdopcion = new GestorAdopcion();
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

            GestorUsuario.VerificarUsuario(correoVerificar, contrasenaVerificar, usuarios, this, GestorAdopcion);

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
    }
}
