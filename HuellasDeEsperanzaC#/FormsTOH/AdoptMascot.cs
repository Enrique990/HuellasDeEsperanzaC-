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

namespace HuellasDeEsperanzaC_.FormsTOH
{
    public partial class AdoptMascot : Form
    {
        private Usuario usuarioActual;

        public AdoptMascot(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
        }

        private void AdoptMascot_Load(object sender, EventArgs e)
        {
            CargarYAgregarMascotas();
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
                if (string.IsNullOrEmpty(mascota.RutaImagen) || !File.Exists(mascota.RutaImagen))
                {
                    throw new FileNotFoundException();
                }

                imagenMascota = Image.FromFile(mascota.RutaImagen);
            }
            catch (Exception)
            {
                // Ruta de la imagen predeterminada
                string rutaImagenPredeterminada = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\icons8-pets-50.png");
                imagenMascota = Image.FromFile(rutaImagenPredeterminada);
            }

            flowLayoutPanel1.Controls.Add(new Card()
            {
                CardNombreMascota = mascota.Nombre,
                CardRaza = mascota.Raza,
                CardEdad = mascota.FechaNacimiento.ToString("dd/MM/yyyy"),
                CardSexo = mascota.Sexo,
                CardImagen = imagenMascota,
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeGeneralForm homeGeneralForm = new HomeGeneralForm(usuarioActual);
            homeGeneralForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMascot addMascot = new AddMascot(usuarioActual);
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
    }
}
