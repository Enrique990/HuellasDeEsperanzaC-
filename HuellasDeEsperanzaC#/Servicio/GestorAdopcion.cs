using HuellasDeEsperanzaC_.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellasDeEsperanzaC_.Servicio
{
    public class GestorAdopcion
    {
        private List<SolicitudAdopcion> solicitudes;
        private List<Mascota> mascotas;
        private List<Usuario> usuarios;

       
        public List<SolicitudAdopcion> SolicitudesAdopcion()
        {
            return solicitudes;
        }

        public GestorAdopcion()
        {
            solicitudes = new List<SolicitudAdopcion>();
            mascotas = new List<Mascota>();
            usuarios = new List<Usuario>();
            CargarDatosSolicitudes();
            CargarDatosMascotas();
            CargarDatosUsuarios();
        }

        public void CrearSolicitudAdopcion(int usuarioId, int mascotaId)
        {
            if (UsuarioPendienteAdopcion(usuarioId))
            {
                MessageBox.Show("Ya tienes una solicitud de adopción pendiente.", "Adopción pendiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SolicitudAdopcion nuevaSolicitud = new SolicitudAdopcion();
            if (solicitudes.Count > 0)
            {
                int maxId = 0;
                for (int i = 0; i < solicitudes.Count; i++)
                {
                    if (solicitudes[i].Id > maxId)
                    {
                        maxId = solicitudes[i].Id;
                    }
                }
                nuevaSolicitud.Id = maxId + 1;
            }
            else
            {
                nuevaSolicitud.Id = 1;
            }
            nuevaSolicitud.UsuarioId = usuarioId;
            nuevaSolicitud.MascotaId = mascotaId;
            nuevaSolicitud.FechaSolicitud = DateTime.Now;
            nuevaSolicitud.Estado = EstadoSolicitud.Pendiente;

            solicitudes.Add(nuevaSolicitud);
            GuardarDatosSolicitudes();
            MessageBox.Show("Solicitud de adopción creada con éxito.");
        }

        public List<Mascota> ObtenerMascotasDisponibles()
        {
            return mascotas.Where(m => !m.EstaAdoptado || solicitudes.Any(s => s.MascotaId == m.Id && s.Estado == EstadoSolicitud.Pendiente)).ToList();
        }

        public void AprobarSolicitud(int solicitudId, Usuario administrador)
        {
            for (int i = 0; i < solicitudes.Count; i++)
            {
                if (solicitudes[i].Id == solicitudId)
                {
                    solicitudes[i].AprobarSolicitud(administrador);
                    Mascota mascota = ObtenerMascotaPorId(solicitudes[i].MascotaId);
                    if (mascota != null)
                    {
                        mascota.EstaAdoptado = true;
                    }
                    GuardarDatosSolicitudes();
                    break;
                }
            }
        }

        public void RechazarSolicitud(int solicitudId, Usuario administrador, string motivo)
        {
            for (int i = 0; i < solicitudes.Count; i++)
            {
                if (solicitudes[i].Id == solicitudId)
                {
                    solicitudes[i].RechazarSolicitud(administrador, motivo);
                    GuardarDatosSolicitudes();
                    break;
                }
            }
        }

        public Mascota ObtenerMascotaPorId(int mascotaId)
        {
            return mascotas.FirstOrDefault(mascota => mascota.Id == mascotaId);
        }

        public Usuario ObtenerUsuarioPorId(int usuarioId)
        {
            return usuarios.FirstOrDefault(usuario => usuario.Id == usuarioId);
        }

        private void GuardarDatosSolicitudes()
        {
            using (FileStream fileStream = new FileStream("solicitudes.dat", FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                foreach (var solicitud in solicitudes)
                {
                    writer.Write(solicitud.Id);
                    writer.Write(solicitud.UsuarioId);
                    writer.Write(solicitud.MascotaId);
                    writer.Write(solicitud.FechaSolicitud.ToBinary());
                    writer.Write((int)solicitud.Estado);
                    if (solicitud.Motivo != null)
                    {
                        writer.Write(solicitud.Motivo);
                    }
                    else
                    {
                        writer.Write(string.Empty);
                    }
                }
            }
        }

        private void CargarDatosSolicitudes()
        {
            solicitudes.Clear();

            if (!File.Exists("solicitudes.dat"))
            {
                return;
            }

            using (FileStream fileStream = new FileStream("solicitudes.dat", FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                while (fileStream.Position < fileStream.Length)
                {
                    SolicitudAdopcion solicitud = new SolicitudAdopcion
                    {
                        Id = reader.ReadInt32(),
                        UsuarioId = reader.ReadInt32(),
                        MascotaId = reader.ReadInt32(),
                        FechaSolicitud = DateTime.FromBinary(reader.ReadInt64()),
                        Estado = (EstadoSolicitud)reader.ReadInt32(),
                        Motivo = reader.ReadString()
                    };

                    solicitudes.Add(solicitud);
                }
            }
        }

        private bool UsuarioPendienteAdopcion(int usuarioId)
        {
            for (int i = 0; i < solicitudes.Count; i++)
            {
                if (solicitudes[i].UsuarioId == usuarioId && solicitudes[i].Estado == EstadoSolicitud.Pendiente)
                {
                    return true;
                }
            }
            return false;
        }   

        private void CargarDatosMascotas()
        {
            GestorMascota gestorMascota = new GestorMascota();
            gestorMascota.CargarDatosMascotas();
            mascotas = gestorMascota.GetListaMascotas();
        }

        private void CargarDatosUsuarios()
        {
            GestorUsuario gestorUsuario = new GestorUsuario();
            gestorUsuario.CargarDatosUsuarios();
            usuarios = gestorUsuario.GetListaUsuarios();
        }

        public void RecargarDatosSolicitudes()
        {
            solicitudes.Clear();
            CargarDatosSolicitudes();
        }

        public SolicitudAdopcion ObtenerPrimeraSolicitudEnEsperaPorUsuario(int usuarioId)
        {
            return solicitudes.FirstOrDefault(solicitud => solicitud.UsuarioId == usuarioId && solicitud.Estado == EstadoSolicitud.Pendiente);
        }

        public List<SolicitudAdopcion> ObtenerSolicitudesEnEspera()
        {
            return solicitudes.Where(solicitud => solicitud.Estado == EstadoSolicitud.Pendiente).ToList();
        }
    }
}
