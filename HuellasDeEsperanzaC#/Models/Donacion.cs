using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellasDeEsperanzaC_.Models
{
    public enum TipoDonacion
    {
        Dinero,
        Alimentos,
        Juguetes
    }
    internal class Donacion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int OrganizacionId { get; set; }
        public TipoDonacion Tipo { get; set; }
        public decimal Cantidad { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaDonacion { get; set; }
        public string MetodoPago { get; set; }

        public Donacion()
        {
            FechaDonacion = DateTime.Now;
        }
    }
}
