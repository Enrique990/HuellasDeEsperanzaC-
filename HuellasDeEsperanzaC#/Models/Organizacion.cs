using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellasDeEsperanzaC_.Models
{
    internal class Organizacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Ubicacion { get; set; }
        public string NumeroTelefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string RutaImagenReferencia { get; set; }
        public string RutaLogo { get; set; }
        public Dictionary<string, string> EnlacesRedesSociales { get; set; }
        public List<Mascota> MascotasEnAdopcion { get; set; }
        public List<ActividadVoluntariado> ActividadesVoluntariado { get; set; }
        public List<OpcionDonacion> OpcionesDonacion { get; set; }

        public Organizacion()
        {
            EnlacesRedesSociales = new Dictionary<string, string>();
            MascotasEnAdopcion = new List<Mascota>();
            ActividadesVoluntariado = new List<ActividadVoluntariado>();
            OpcionesDonacion = new List<OpcionDonacion>();
        }

        public void AgregarMascota(Mascota mascota)
        {
            MascotasEnAdopcion.Add(mascota);
        }

        public void AgregarActividadVoluntariado(ActividadVoluntariado actividad)
        {
            ActividadesVoluntariado.Add(actividad);
        }

        public void AgregarOpcionDonacion(OpcionDonacion opcion)
        {
            OpcionesDonacion.Add(opcion);
        }

        public void AgregarEnlaceRedSocial(string redSocial, string enlace)
        {
            EnlacesRedesSociales[redSocial] = enlace;
        }
    }
}
