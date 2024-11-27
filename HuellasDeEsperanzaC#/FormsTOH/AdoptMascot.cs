using HuellasDeEsperanzaC_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuellasDeEsperanzaC_.Servicio;
using HuellasDeEsperanzaC_.CustomUserControls;
using System.IO;
using System.Runtime.InteropServices;

namespace HuellasDeEsperanzaC_.FormsTOH
{
    public partial class AdoptMascot : Form
    {
        private Usuario usuarioActual;
        private GestorAdopcion gestorAdopcionUser;

        public AdoptMascot(Usuario usuario, GestorAdopcion gestorAdopcion)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            this.gestorAdopcionUser = gestorAdopcion;
        }

        private void AdoptMascot_Load(object sender, EventArgs e)
        {
            CargarYAgregarMascotas();
            gestorAdopcionUser.RecargarDatosSolicitudes();
        }

        public void CargarYAgregarMascotas()
        {
            List<Mascota> mascotas = new List<Mascota>();
            GestorMascota gestorMascota = new GestorMascota();
            gestorMascota.CargarDatosMascotas(mascotas);

            for (int i = 0; i < mascotas.Count; i++)
            {
                AgregarMascotaCard(mascotas[i]);
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

            Card card = new Card(usuarioActual.Id, mascota.Id)
            {
                CardNombreMascota = mascota.Nombre,
                CardRaza = mascota.Raza,
                CardEdad = mascota.FechaNacimiento.ToString("dd/MM/yyyy"),
                CardSexo = mascota.Sexo,
                CardImagen = imagenMascota,
            };

            card.OnSelect += Card_OnSelect;

            flowLayoutPanel1.Controls.Add(card);
        }

        private void Card_OnSelect(object sender, EventArgs e)
        {
            Card selectedCard = sender as Card;
            if (selectedCard != null)
            {
                // Crear una nueva solicitud de adopción
                gestorAdopcionUser.CrearSolicitudAdopcion(usuarioActual.Id, selectedCard.MascotaId);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Solicitud de adopción creada con éxito.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeGeneralForm homeGeneralForm = new HomeGeneralForm(usuarioActual, gestorAdopcionUser);
            homeGeneralForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMascot addMascot = new AddMascot(usuarioActual, gestorAdopcionUser);
            addMascot.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Stop();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
            WaitingListForm waitingListForm = new WaitingListForm(usuarioActual, gestorAdopcionUser);
            waitingListForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ConfiguracionForm configuracionForm = new ConfiguracionForm(usuarioActual, gestorAdopcionUser);
            configuracionForm.Show();
            this.Hide();
        }
    }
}
