using HuellasDeEsperanzaC_.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellasDeEsperanzaC_.Servicio
{
    public class GestorAdopcion
    {
        private Dictionary<int, List<SolicitudAdopcion>> listasDeEsperaPorUsuario;

        public GestorAdopcion()
        {
            listasDeEsperaPorUsuario = new Dictionary<int, List<SolicitudAdopcion>>();
            CargarDatosSolicitudes();
        }

        public void CrearSolicitudAdopcion(int usuarioId, int mascotaId)
        {
            if (!listasDeEsperaPorUsuario.ContainsKey(usuarioId))
            {
                listasDeEsperaPorUsuario[usuarioId] = new List<SolicitudAdopcion>();
            }

            SolicitudAdopcion solicitud = new SolicitudAdopcion
            {
                UsuarioId = usuarioId,
                MascotaId = mascotaId,
                FechaSolicitud = DateTime.Now,
                Estado = EstadoSolicitud.Pendiente
            };
            listasDeEsperaPorUsuario[usuarioId].Add(solicitud);
            GuardarDatosSolicitudes();
        }

        public List<SolicitudAdopcion> ObtenerSolicitudesPorUsuario(int usuarioId)
        {
            if (listasDeEsperaPorUsuario.ContainsKey(usuarioId))
            {
                return listasDeEsperaPorUsuario[usuarioId];
            }
            return new List<SolicitudAdopcion>();
        }

        public void AprobarSolicitud(int solicitudId, Usuario administrador)
        {
            foreach (var usuarioSolicitudes in listasDeEsperaPorUsuario.Values)
            {
                var solicitud = usuarioSolicitudes.FirstOrDefault(s => s.Id == solicitudId);
                if (solicitud != null)
                {
                    solicitud.AprobarSolicitud(administrador);
                    var mascota = ObtenerMascotaPorId(solicitud.MascotaId);
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
            foreach (var usuarioSolicitudes in listasDeEsperaPorUsuario.Values)
            {
                var solicitud = usuarioSolicitudes.FirstOrDefault(s => s.Id == solicitudId);
                if (solicitud != null)
                {
                    solicitud.RechazarSolicitud(administrador, motivo);
                    GuardarDatosSolicitudes();
                    break;
                }
            }
        }

        public Mascota ObtenerMascotaPorId(int mascotaId)
        {
            List<Mascota> mascotas = new List<Mascota>();
            GestorMascota gestorMascota = new GestorMascota();
            gestorMascota.CargarDatosMascotas(mascotas);

            return mascotas.FirstOrDefault(m => m.Id == mascotaId);
        }

        private void GuardarDatosSolicitudes()
        {
            foreach (var usuarioId in listasDeEsperaPorUsuario.Keys)
            {
                string filePath = $"solicitudes_{usuarioId}.dat";
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(fileStream))
                {
                    var solicitudes = listasDeEsperaPorUsuario[usuarioId];
                    writer.Write(solicitudes.Count);
                    foreach (var solicitud in solicitudes)
                    {
                        writer.Write(solicitud.Id);
                        writer.Write(solicitud.UsuarioId);
                        writer.Write(solicitud.MascotaId);
                        writer.Write(solicitud.FechaSolicitud.ToBinary());
                        writer.Write((int)solicitud.Estado);
                        writer.Write(solicitud.Motivo ?? string.Empty);
                    }
                }
            }
        }

        private void CargarDatosSolicitudes()
        {
            foreach (var filePath in Directory.GetFiles(".", "solicitudes_*.dat"))
            {
                int usuarioId = int.Parse(Path.GetFileNameWithoutExtension(filePath).Split('_')[1]);
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fileStream))
                {
                    int count = reader.ReadInt32();
                    var solicitudes = new List<SolicitudAdopcion>();
                    for (int i = 0; i < count; i++)
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
                    listasDeEsperaPorUsuario[usuarioId] = solicitudes;
                }
            }
        }
    }
}
