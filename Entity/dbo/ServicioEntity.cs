using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ServicioEntity: DBEntity
    {
        public int? IdServicio { get; set; }
        public string NombreServicio { get; set; }
        public int? PlazoEntrega { get; set; }
        public decimal CostoServicio { get; set; }
        public bool Estado { get; set; }
        public string CuentaContable { get; set; }
    }
}
