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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellasDeEsperanzaC_.FormsTOH
{
    public partial class AdminWaitingList : Form
    {
        private Usuario usuarioActual;
        private GestorAdopcion gestorAdopcionUser;
        private GestorUsuario gestorUsuario;

        public AdminWaitingList(Usuario usuario, GestorAdopcion gestorAdopcion, GestorUsuario gestorusuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            this.gestorAdopcionUser = gestorAdopcion;
            this.gestorUsuario = gestorusuario;
            this.gestorUsuario.CargarDatosUsuarios();
        }

        private void CargarTodasLasSolicitudesEnEspera()
        {
            List<SolicitudAdopcion> solicitudesEnEspera = gestorAdopcionUser.ObtenerSolicitudesEnEspera();

            if (solicitudesEnEspera.Count > 0)
            {
                // Limpiar cualquier contenido previo en el control que muestra las solicitudes
                flowLayoutPanel1.Controls.Clear();

                // Agrupar las solicitudes por usuario
                var solicitudesAgrupadasPorUsuario = solicitudesEnEspera.GroupBy(s => s.UsuarioId);

                foreach (var grupo in solicitudesAgrupadasPorUsuario)
                {
                    Usuario usuario = gestorUsuario.ObtenerUsuarioPorId(grupo.Key);

                    if (usuario == null)
                    {
                        MetroFramework.MetroMessageBox.Show(this,
                            "Error: No se pudo encontrar el usuario con ID " + grupo.Key,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    foreach (var solicitud in grupo)
                    {
                        Mascota mascota = gestorAdopcionUser.ObtenerMascotaPorId(solicitud.MascotaId);

                        if (mascota == null)
                        {
                            MetroFramework.MetroMessageBox.Show(this,
                                "Error: No se pudo encontrar la mascota con ID " + solicitud.MascotaId,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        WaitingCard waitingCard = new WaitingCard(solicitud.Id)
                        {
                            NombreMascota = mascota.Nombre,
                            ImagenMascota = CargarImagenMascota(mascota.RutaImagen),
                            NombreSolicitante = usuario.NombreCompleto,
                            EmailSolicitante = usuario.CorreoElectronico,
                            TelefonoSolicitante = usuario.NumeroTelefono
                        };

                        waitingCard.OnAccept += WaitingCard_OnAccept;

                        flowLayoutPanel1.Controls.Add(waitingCard);
                    }
                }
            }
        }

        private Image CargarImagenMascota(string rutaImagen)
        {
            try
            {
                string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string fullPath = Path.Combine(projectDirectory, rutaImagen);
                if (string.IsNullOrEmpty(rutaImagen) || !System.IO.File.Exists(fullPath))
                {
                    throw new System.IO.FileNotFoundException();
                }

                return Image.FromFile(fullPath);
            }
            catch (Exception)
            {
                // Ruta de la imagen predeterminada
                string rutaImagenPredeterminada = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\icons8-pets-50.png");
                return Image.FromFile(rutaImagenPredeterminada);
            }
        }

        private void WaitingCard_OnAccept(object sender, int solicitudId)
        {
            // Obtener la solicitud y la mascota
            SolicitudAdopcion solicitud = gestorAdopcionUser.ObtenerPrimeraSolicitudEnEsperaPorUsuario(solicitudId);
            Mascota mascota = gestorAdopcionUser.ObtenerMascotaPorId(solicitud.MascotaId);

            // Aprobar la solicitud
            gestorAdopcionUser.AprobarSolicitud(solicitudId, usuarioActual);

            // Eliminar la mascota de la vista de todos los usuarios
            AdoptMascot adoptMascotForm = Application.OpenForms.OfType<AdoptMascot>().FirstOrDefault();
            adoptMascotForm?.EliminarMascotaDeVista(mascota.Id);

            // Permitir que los usuarios que querían adoptar esta mascota puedan adoptar otra
            foreach (var usuario in gestorUsuario.GetListaUsuarios())
            {
                if (gestorAdopcionUser.UsuarioPendienteAdopcion(usuario.Id))
                {
                    gestorAdopcionUser.RechazarSolicitud(solicitudId, usuarioActual, "La mascota ha sido adoptada por otro usuario.");
                }
            }

            // Eliminar la card de la lista de espera
            flowLayoutPanel1.Controls.Remove((Control)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome adminHomet = new AdminHome(usuarioActual, gestorAdopcionUser);
            adminHomet.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button10_Click_1(object sender, EventArgs e)
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

        private void button9_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminWaitingList_Load(object sender, EventArgs e)
        {
            gestorAdopcionUser.RecargarDatosSolicitudes();
            CargarTodasLasSolicitudesEnEspera();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminCreator creator = new AdminCreator();
            creator.Show();
            this.Hide();
        }
    }
}
