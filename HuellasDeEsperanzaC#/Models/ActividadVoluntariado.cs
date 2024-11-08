using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellasDeEsperanzaC_.Models
{
    internal class ActividadVoluntariado
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int CupoMaximo { get; set; }
        public int CupoActual { get; set; }
        public int OrganizacionId { get; set; }

        public bool HayCupoDisponible()
        {
            return CupoActual < CupoMaximo;
        }

        public bool RegistrarVoluntario()
        {
            if (HayCupoDisponible())
            {
                CupoActual++;
                return true;
            }
            return false;
        }
    }
}
