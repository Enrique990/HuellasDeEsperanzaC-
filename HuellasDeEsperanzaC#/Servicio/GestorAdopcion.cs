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
            SolicitudAdopcion nuevaSolicitud = new SolicitudAdopcion();
            if (SolicitudesAdopcion.Count > 0)
            {
                int maxId = 0;
                for (int i = 0; i < SolicitudesAdopcion.Count; i++)
                {
                    if (SolicitudesAdopcion[i].Id > maxId)
                    {
                        maxId = SolicitudesAdopcion[i].Id;
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

            SolicitudesAdopcion.Add(nuevaSolicitud);
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

        private void GuardarDatosSolicitudes()
        {
            using (FileStream fileStream = new FileStream("solicitudes.dat", FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                foreach (var solicitud in SolicitudesAdopcion)
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
            SolicitudesAdopcion.Clear();

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

                    SolicitudesAdopcion.Add(solicitud);
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
                        Tipo = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), reader.ReadString())
                        //PerfilCompleto = reader.ReadBoolean()
                    };
                    usuarios.Add(usuario);
                }
            }
        }

        public void RecargarDatosSolicitudes()
        {
            solicitudes.Clear();
            CargarDatosSolicitudes();
        }

        public SolicitudAdopcion ObtenerPrimeraSolicitudEnEsperaPorUsuario(int usuarioId)
        {
            for (int i = 0; i < SolicitudesAdopcion.Count; i++)
            {
                SolicitudAdopcion solicitud = SolicitudesAdopcion[i];
                if (solicitud.UsuarioId == usuarioId && solicitud.Estado == EstadoSolicitud.Pendiente)
                {
                    return solicitud;
                }
            }
            return null;
        }

        public List<SolicitudAdopcion> ObtenerSolicitudesEnEspera()
        {
            List<SolicitudAdopcion> solicitudesEnEspera = new List<SolicitudAdopcion>();

            for (int i = 0; i < SolicitudesAdopcion.Count; i++)
            {
                SolicitudAdopcion solicitud = SolicitudesAdopcion[i];
                if (solicitud.Estado == EstadoSolicitud.Pendiente)
                {
                    solicitudesEnEspera.Add(solicitud);
                }
            }

            return solicitudesEnEspera;
        }
    }
}
