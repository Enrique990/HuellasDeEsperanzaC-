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
        private List<SolicitudAdopcion> solicitudes;
        private List<Mascota> mascotas;
        private List<Usuario> usuarios;

        public List<SolicitudAdopcion> SolicitudesAdopcion
        {
            get
            {
                return solicitudes;
            }
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
            SolicitudAdopcion nuevaSolicitud = new SolicitudAdopcion
            {
                UsuarioId = usuarioId,
                MascotaId = mascotaId
            };

            solicitudes.Add(nuevaSolicitud);
            GuardarDatosSolicitudes();
        }

        public List<Mascota> ObtenerMascotasDisponibles()
        {
            List<Mascota> mascotasDisponibles = new List<Mascota>();
            for (int i = 0; i < mascotas.Count; i++)
            {
                bool solicitudPendiente = false;
                for (int j = 0; j < solicitudes.Count; j++)
                {
                    if (solicitudes[j].MascotaId == mascotas[i].Id && solicitudes[j].Estado == EstadoSolicitud.Pendiente)
                    {
                        solicitudPendiente = true;
                        break;
                    }
                }

                if (!mascotas[i].EstaAdoptado || solicitudPendiente)
                {
                    mascotasDisponibles.Add(mascotas[i]);
                }
            }
            return mascotasDisponibles;
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
            for (int i = 0; i < mascotas.Count; i++)
            {
                if (mascotas[i].Id == mascotaId)
                {
                    return mascotas[i];
                }
            }
            return null;
        }

        public Usuario ObtenerUsuarioPorId(int usuarioId)
        {
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Id == usuarioId)
                {
                    return usuarios[i];
                }
            }
            return null;
        }

        private void CargarDatosSolicitudes()
        {
            if (!File.Exists("solicitudes.dat"))
            {
                return;
            }

            using (FileStream fileStreamSolicitudes = new FileStream("solicitudes.dat", FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fileStreamSolicitudes))
            {
                while (fileStreamSolicitudes.Position < fileStreamSolicitudes.Length)
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

        private void GuardarDatosSolicitudes()
        {
            using (FileStream fileStreamSolicitudes = new FileStream("solicitudes.dat", FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fileStreamSolicitudes))
            {
                for (int i = 0; i < solicitudes.Count; i++)
                {
                    writer.Write(solicitudes[i].Id);
                    writer.Write(solicitudes[i].UsuarioId);
                    writer.Write(solicitudes[i].MascotaId);
                    writer.Write(solicitudes[i].FechaSolicitud.ToBinary());
                    writer.Write((int)solicitudes[i].Estado);
                    if (solicitudes[i].Motivo != null)
                    {
                        writer.Write(solicitudes[i].Motivo);
                    }
                    else
                    {
                        writer.Write(string.Empty);
                    }
                }
            }
        }

        private void CargarDatosMascotas()
        {
            if (!File.Exists("mascotas.dat"))
            {
                return;
            }

            using (FileStream fileStreamMascotas = new FileStream("mascotas.dat", FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fileStreamMascotas))
            {
                while (fileStreamMascotas.Position < fileStreamMascotas.Length)
                {
                    Mascota mascota = new Mascota
                    {
                        Id = reader.ReadInt32(),
                        Nombre = reader.ReadString(),
                        Especie = reader.ReadString(),
                        Sexo = reader.ReadString(),
                        Raza = reader.ReadString(),
                        FechaNacimiento = DateTime.FromBinary(reader.ReadInt64()),
                        Descripcion = reader.ReadString(),
                        RutaImagen = reader.ReadString()
                    };
                    mascotas.Add(mascota);
                }
            }
        }

        private void CargarDatosUsuarios()
        {
            if (!File.Exists("usuarios.dat"))
            {
                return;
            }

            using (FileStream fileStreamUsuarios = new FileStream("usuarios.dat", FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fileStreamUsuarios))
            {
                while (fileStreamUsuarios.Position < fileStreamUsuarios.Length)
                {
                    Usuario usuario = new Usuario
                    {
                        Id = reader.ReadInt32(),
                        NombreUsuario = reader.ReadString(),
                        CorreoElectronico = reader.ReadString(),
                        HashContrasena = reader.ReadString(),
                        NombreCompleto = reader.ReadString(),
                        Direccion = reader.ReadString(),
                        NumeroTelefono = reader.ReadString(),
                        Descripcion = reader.ReadString(),
                        NumeroCedula = reader.ReadString(),
                        Ocupacion = reader.ReadString(),
                        Tipo = (TipoUsuario)reader.ReadInt32(),
                        PerfilCompleto = reader.ReadBoolean()
                    };
                    usuarios.Add(usuario);
                }
            }
        }
    }
}
