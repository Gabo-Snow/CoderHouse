using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }

        public Producto()
        {
            this.Id = 0;
            this.Descripcion = string.Empty;
            this.Costo = 0;
            this.PrecioVenta = 0;
            this.Stock = 0;
            this.IdUsuario = 0;

        }
    }
}
