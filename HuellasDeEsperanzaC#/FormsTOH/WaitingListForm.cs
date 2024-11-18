using HuellasDeEsperanzaC_.Models;
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

namespace HuellasDeEsperanzaC_.FormsTOH
{
    public partial class WaitingListForm : Form
    {
        private Usuario usuarioActual;

        public WaitingListForm(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
        }

        private void WaitingListForm_Load(object sender, EventArgs e)
        {
            CargarMascotaEnEspera();
        }

        private void CargarMascotaEnEspera()
        {
            if (usuarioActual.MascotasAdoptadas.Count > 0)
            {
                Mascota mascotaEnEspera = usuarioActual.MascotasAdoptadas[0]; // Asumiendo que solo hay una mascota en espera

                lblEstadoLista.Text = "En espera";
                lblNombreM.Text = mascotaEnEspera.Nombre;
                lblEspecieM.Text = mascotaEnEspera.Especie;
                lblSexoM.Text = mascotaEnEspera.Sexo;
                lblRazaM.Text = mascotaEnEspera.Raza;
                lblFechaNacM.Text = mascotaEnEspera.FechaNacimiento.ToString("dd/MM/yyyy");
                lblDescripcionM.Text = mascotaEnEspera.Descripcion;

                string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string fullPath = Path.Combine(projectDirectory, mascotaEnEspera.RutaImagen);
                if (File.Exists(fullPath))
                {
                    pbCircleMascota.Image = Image.FromFile(fullPath);
                }
                else
                {
                    string rutaImagenPredeterminada = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\icons8-pets-50.png");
                    pbCircleMascota.Image = Image.FromFile(rutaImagenPredeterminada);
                }
            }
            else
            {
                lblEstadoLista.Text = "No hay mascotas en espera";
                lblNombreM.Text = string.Empty;
                lblEspecieM.Text = string.Empty;
                lblSexoM.Text = string.Empty;
                lblRazaM.Text = string.Empty;
                lblFechaNacM.Text = string.Empty;
                lblDescripcionM.Text = string.Empty;
                pbCircleMascota.Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeGeneralForm homeGeneralForm = new HomeGeneralForm(usuarioActual);
            homeGeneralForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdoptMascot adoptMascot = new AdoptMascot(usuarioActual);
            adoptMascot.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMascot addMascot = new AddMascot(usuarioActual);
            addMascot.Show();
            this.Close();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            ConfiguracionForm configuracionForm = new ConfiguracionForm(usuarioActual);
            configuracionForm.Show();
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
