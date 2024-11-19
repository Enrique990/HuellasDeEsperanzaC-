using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellasDeEsperanzaC_.Models
{
    public enum EstadoSolicitud
    {
        Pendiente,
        Aprobada,
        Rechazada
    }
    public class SolicitudAdopcion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int MascotaId { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public EstadoSolicitud Estado { get; set; }
        public string Motivo { get; set; }

        public SolicitudAdopcion()
        {
            FechaSolicitud = DateTime.Now;
            Estado = EstadoSolicitud.Pendiente;
        }

        public void AprobarSolicitud(Usuario administrador)
        {
            if (administrador.Tipo == TipoUsuario.Administrador)
            {
                Estado = EstadoSolicitud.Aprobada;
            }
            else
            {
                throw new UnauthorizedAccessException("Solo los administradores pueden aprobar solicitudes.");
            }
        }

        public void RechazarSolicitud(Usuario administrador, string motivo)
        {
            if (administrador.Tipo == TipoUsuario.Administrador)
            {
                Estado = EstadoSolicitud.Rechazada;
                Motivo = motivo;
            }
            else
            {
                throw new UnauthorizedAccessException("Solo los administradores pueden rechazar solicitudes.");
            }
        }
    }
}
