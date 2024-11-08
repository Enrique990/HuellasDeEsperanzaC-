using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellasDeEsperanzaC_.Models
{
    internal class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Especie { get; set; }
        public string Tamaño { get; set; }
        public string Descripcion { get; set; }
        public string RutaImagen { get; set; }
        public bool EstaAdoptado { get; set; }
        public int OrganizacionId { get; set; }

        public Mascota()
        {
            EstaAdoptado = false;
        }

        public int CalcularEdad()
        {
            return DateTime.Now.Year - FechaNacimiento.Year;
        }
    }
}
