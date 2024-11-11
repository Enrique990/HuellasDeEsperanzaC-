using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellasDeEsperanzaC_.Models
{
    public class ActividadVoluntariado
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int CupoMaximo { get; set; }
        public List<Usuario> Participantes { get; set; }
        public int OrganizacionId { get; set; }

        public ActividadVoluntariado()
        {
            Participantes = new List<Usuario>();
        }

        public bool HayCupoDisponible()
        {
            return Participantes.Count < CupoMaximo;
        }

        public bool RegistrarParticipante(Usuario usuario)
        {
            if (HayCupoDisponible() && usuario.PerfilCompleto)
            {
                Participantes.Add(usuario);
                return true;
            }
            return false;
        }
    }
}
