using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SolicitudEntity: DBEntity
    {
        public int? IdSolicitud { get; set; }
        public int? IdCliente { get; set; }
        public int? IdServicio { get; set; }
        public int? IdCantidad { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string UsuarioEntrega { get; set; }
        public string Observaciones { get; set; }
    }
}
