using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellasDeEsperanzaC_.Models
{
    internal class OpcionDonacion
    {
        public int Id { get; set; }
        public TipoDonacion Tipo { get; set; }
        public string Descripcion { get; set; }
        public string InstruccionesDonacion { get; set; }
    }
}
