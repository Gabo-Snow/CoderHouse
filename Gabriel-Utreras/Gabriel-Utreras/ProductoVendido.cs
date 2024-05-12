using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Utreras
{
   public class ProductoVendido
    {
        private int Id { get; set; }
        private int IdProducto { get; set; }
        private int Stock { get; set; }
        private int IdVenta { get; set; }


        public ProductoVendido()
        {
            this.Id = 0;
            this.IdProducto = 0;
            this.Stock = 0;
            this.IdVenta = 0;
        }
    }

}
