using HuellasDeEsperanzaC_.CustomUserControls;
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
    public partial class WaitingListForm : Form
    {
        private Usuario usuarioActual;
        private GestorAdopcion gestorAdopcionUser;

        public WaitingListForm(Usuario usuario, GestorAdopcion gestorAdopcion)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            this.gestorAdopcionUser = gestorAdopcion;
        }

        private void WaitingListForm_Load(object sender, EventArgs e)
        {
            CargarMascotaEnEspera();
        }

        private void CargarMascotaEnEspera()
        {
            flowLayoutPanelAdopciones.Controls.Clear();
            var solicitudesUsuario = gestorAdopcionUser.SolicitudesAdopcion.Where(s => s.UsuarioId == usuarioActual.Id).ToList();

            if (solicitudesUsuario.Count > 0)
            {
                foreach (var solicitud in solicitudesUsuario)
                {
                    Mascota mascotaEnEspera = gestorAdopcionUser.ObtenerMascotaPorId(solicitud.MascotaId);
                    AgregarMascotaCard(mascotaEnEspera);
                }
            }
            else
            {
                lblEstadoLista.Text = "No hay solicitudes de adopción en espera";
            }
        }

        public void AgregarMascotaCard(Mascota mascota)
        {
            Image imagenMascota;
            try
            {
                string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string fullPath = Path.Combine(projectDirectory, mascota.RutaImagen);
                if (string.IsNullOrEmpty(mascota.RutaImagen) || !File.Exists(fullPath))
                {
                    throw new FileNotFoundException();
                }

                imagenMascota = Image.FromFile(fullPath);
            }
            catch (Exception)
            {
                // Ruta de la imagen predeterminada
                string rutaImagenPredeterminada = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\icons8-pets-50.png");
                imagenMascota = Image.FromFile(rutaImagenPredeterminada);
            }

            Card card = new Card(usuarioActual.Id, mascota.Id, mostrarBotonAdoptar: false)
            {
                CardNombreMascota = mascota.Nombre,
                CardRaza = mascota.Raza,
                CardEdad = mascota.FechaNacimiento.ToString("dd/MM/yyyy"),
                CardSexo = mascota.Sexo,
                CardImagen = imagenMascota,
            };

            card.OnSelect += Card_OnSelect;

            flowLayoutPanelAdopciones.Controls.Add(card);
        }

        private void Card_OnSelect(object sender, EventArgs e)
        {
            Card selectedCard = sender as Card;
            if (selectedCard != null)
            {
                var solicitud = gestorAdopcionUser.SolicitudesAdopcion.FirstOrDefault(s => s.MascotaId == selectedCard.MascotaId && s.UsuarioId == usuarioActual.Id);
                if (solicitud != null)
                {
                    gestorAdopcionUser.RechazarSolicitud(solicitud.Id, usuarioActual, "Cancelada por el usuario");
                    usuarioActual.MascotasAdoptadas.RemoveAll(m => m.Id == solicitud.MascotaId);
                    MessageBox.Show("Solicitud de adopción cancelada con éxito.");
                    CargarMascotaEnEspera();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void button3_Click(object sender, EventArgs e)
        {
            AddMascot addMascot = new AddMascot(usuarioActual, gestorAdopcionUser);
            addMascot.Show();
            this.Close();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            ConfiguracionForm configuracionForm = new ConfiguracionForm(usuarioActual, gestorAdopcionUser);
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