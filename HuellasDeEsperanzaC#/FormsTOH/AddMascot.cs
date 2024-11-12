using HuellasDeEsperanzaC_.Models;
using HuellasDeEsperanzaC_.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellasDeEsperanzaC_.FormsTOH
{
    public partial class AddMascot : Form
    {
        private Usuario usuarioActual;
        private string rutaImagenSeleccionada;

        public AddMascot(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }

        private void privacidadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeGeneralForm homeGeneralForm = new HomeGeneralForm(usuarioActual);
            homeGeneralForm.Show();
            this.Close();
        }

        private void pbCircle_Click(object sender, EventArgs e)
        {
            GestorMascota gestorMascota = new GestorMascota();
            rutaImagenSeleccionada = gestorMascota.SeleccionarYGuardarImagen(this);

            if (!string.IsNullOrEmpty(rutaImagenSeleccionada))
            {
                pbCircle.Image = Image.FromFile(rutaImagenSeleccionada);
            }
        }

        private void btnGuardarMascota_Click(object sender, EventArgs e)
        {

            Mascota mascota = new Mascota
            {
                Nombre = tbNombreMascota.Texts,
                Especie = tbTipoMascota.Texts,
                Sexo = tbSexoMascota.Texts,
                Raza = tbRazaMascota.Texts,
                FechaNacimiento = dtFechaMascota.Value,
                Descripcion = tbDescripcionMascota.Texts,
                RutaImagen = rutaImagenSeleccionada
            };

            GestorMascota gestorMascota = new GestorMascota();
            List<Mascota> mascotas = new List<Mascota>();
            gestorMascota.CargarDatosMascotas(mascotas);

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

            HomeGeneralForm homeGeneralForm = new HomeGeneralForm(usuarioActual);
            homeGeneralForm.Show();
            this.Close();
        }
    }
}
