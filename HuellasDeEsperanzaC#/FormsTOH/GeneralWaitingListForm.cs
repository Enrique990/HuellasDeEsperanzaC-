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
    public partial class GeneralWaitingListForm : Form
    {
        private Usuario usuarioActual;
        private GestorAdopcion gestorAdopcionUser;

        public GeneralWaitingListForm(Usuario usuario, GestorAdopcion gestorAdopcion)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            this.gestorAdopcionUser = gestorAdopcion;
        }

        private void CargarTodasLasSolicitudesEnEspera()
        {
            List<SolicitudAdopcion> solicitudesEnEspera = gestorAdopcionUser.ObtenerSolicitudesEnEspera();

            if (solicitudesEnEspera.Count > 0)
            {
                // Limpiar cualquier contenido previo en el control que muestra las solicitudes
                listBox1.Items.Clear();

                for (int i = 0; i < solicitudesEnEspera.Count; i++)
                {
                    SolicitudAdopcion solicitud = solicitudesEnEspera[i];
                    Mascota mascota = gestorAdopcionUser.ObtenerMascotaPorId(solicitud.MascotaId);
                    Usuario usuario = gestorAdopcionUser.ObtenerUsuarioPorId(solicitud.UsuarioId);

                    if (usuario == null)
                    {
                        MessageBox.Show("Error: No se pudo encontrar el usuario con ID " + solicitud.UsuarioId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    if (mascota == null)
                    {
                        MessageBox.Show("Error: No se pudo encontrar la mascota con ID " + solicitud.MascotaId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    string item = "Solicitud ID: " + solicitud.Id + ", Usuario: " + usuario.NombreUsuario + ", Mascota: " + mascota.Nombre + ", Fecha: " + solicitud.FechaSolicitud.ToString("dd/MM/yyyy") + ", Estado: " + solicitud.Estado;
                    listBox1.Items.Add(item);
                }

                if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("No hay solicitudes de adopción en espera", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Solicitudes en espera cargadas correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No hay solicitudes de adopción en espera", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void GeneralWaitingListForm_Load(object sender, EventArgs e)
        {
            CargarTodasLasSolicitudesEnEspera();
        }

    }
}
