using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Utreras
{
    public class Producto
    {
        private int Id { get; set; }
        private string Descripcion { get; set; }
        private double Costo { get; set; }
        private double PrecioVenta { get; set; }
        private int Stock { get; set; }
        private int IdUsuario { get; set; }

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
