using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellasDeEsperanzaC_.Models
{
    internal class Notificacion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Leida { get; set; }

        public Notificacion()
        {
            FechaCreacion = DateTime.Now;
            Leida = false;
        }

        public void MarcarComoLeida()
        {
            Leida = true;
        }
    }
}
