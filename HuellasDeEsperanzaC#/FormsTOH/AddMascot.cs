using HuellasDeEsperanzaC_.Models;
using HuellasDeEsperanzaC_.Servicio;
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
    public partial class AddMascot : Form
    {
        private Usuario usuarioActual;
        private GestorAdopcion gestorAdopcionUser;
        private string rutaImagenSeleccionada;

        public AddMascot(Usuario usuario, GestorAdopcion gestorAdopcion)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            this.gestorAdopcionUser = gestorAdopcion;
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            cbRazaPerro.Visible = false;
            cbRazaGato.Visible = false;
            cbRazaConejo.Visible = false;
        }

        private void privacidadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeGeneralForm homeGeneralForm = new HomeGeneralForm(usuarioActual, gestorAdopcionUser);
            homeGeneralForm.Show();
            this.Close();
        }

        private void pbCircle_Click(object sender, EventArgs e)
        {
            GestorMascota gestorMascota = new GestorMascota();
            rutaImagenSeleccionada = gestorMascota.SeleccionarYGuardarImagen(this);

            if (!string.IsNullOrEmpty(rutaImagenSeleccionada))
            {
                try
                {
                    string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                    string fullPath = Path.Combine(projectDirectory, rutaImagenSeleccionada);
                    pbCircle.Image = Image.FromFile(fullPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }

        private void btnGuardarMascota_Click(object sender, EventArgs e)
        {
            // Validar campos requeridos

            DateTime fechaNacimiento = dtFechaMascota.Value;
            DateTime fechaActual = DateTime.Now;
            int edadMaxima = 33;

            if (fechaNacimiento > fechaActual)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser una fecha futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((fechaActual.Year - fechaNacimiento.Year) > edadMaxima)
            {
                MessageBox.Show($"Es imposible que esta mascota tanga esa edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(tbNombreMascota.Texts) ||
            string.IsNullOrEmpty(cbEspecie.Text) ||
            string.IsNullOrEmpty(cbSexo.Text) ||
            (cbEspecie.SelectedItem.ToString() == "Perro" && string.IsNullOrEmpty(cbRazaPerro.Text)) ||
            (cbEspecie.SelectedItem.ToString() == "Gato" && string.IsNullOrEmpty(cbRazaGato.Text)) ||
            (cbEspecie.SelectedItem.ToString() == "Conejo" && string.IsNullOrEmpty(cbRazaConejo.Text)) ||
            string.IsNullOrEmpty(tbDescripcionMascota.Texts))
            {
                MessageBox.Show("Por favor, rellene todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Asignar imagen predeterminada si no se selecciona una imagen
            if (string.IsNullOrEmpty(rutaImagenSeleccionada))
            {
                MessageBox.Show("Por favor, seleccione una imagen para la mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Mascota mascota = new Mascota
            {
                Nombre = tbNombreMascota.Texts,
                Especie = cbEspecie.Text,
                Sexo = cbSexo.Text,
                Raza = cbEspecie.SelectedItem.ToString() == "Perro" ? cbRazaPerro.Text : cbEspecie.SelectedItem.ToString() == "Gato" ? cbRazaGato.Text : cbEspecie.SelectedItem.ToString() == "Conejo" ? cbRazaConejo.Text : string.Empty,
                FechaNacimiento = dtFechaMascota.Value,
                Descripcion = tbDescripcionMascota.Texts,
                RutaImagen = rutaImagenSeleccionada
            };

            GestorMascota gestorMascota = new GestorMascota();
            List<Mascota> mascotas = new List<Mascota>();
            gestorMascota.CargarDatosMascotas();

            bool esEdicion = false;
            for (int i = 0; i < mascotas.Count; i++)
            {
                if (mascotas[i].Id == mascota.Id)
                {
                    esEdicion = true;
                    break;
                }
            }

            if (esEdicion)
            {
                gestorMascota.ActualizarMascota(mascota, this);
            }
            else
            {
                gestorMascota.RegistrarMascota(mascota, this);
            }

            HomeGeneralForm homeGeneralForm = new HomeGeneralForm(usuarioActual, gestorAdopcionUser);
            homeGeneralForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdoptMascot adoptMascot = new AdoptMascot(usuarioActual, gestorAdopcionUser);
            adoptMascot.Show();
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ConfiguracionForm configuracionForm = new ConfiguracionForm(usuarioActual, gestorAdopcionUser);
            configuracionForm.Show();
            this.Close();
        }

        private void cbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ocultar todos los ComboBox de raza
            cbRazaPerro.Visible = false;
            cbRazaGato.Visible = false;

            // Mostrar el ComboBox de raza correspondiente según la especie seleccionada
            if (cbEspecie.SelectedItem.ToString() == "Perro")
            {
                cbRazaPerro.Visible = true;
            }
            else if (cbEspecie.SelectedItem.ToString() == "Gato")
            {
                cbRazaGato.Visible = true;
            }
            else if (cbEspecie.SelectedItem.ToString() == "Conejo")
            {
                cbRazaConejo.Visible = true;
            }
        }
    }
}
