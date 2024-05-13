using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Utreras
{
   public class ProductoVendido
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Stock { get; set; }
        public int IdVenta { get; set; }


        public ProductoVendido()
        {
            this.Id = 0;
            this.IdProducto = 0;
            this.Stock = 0;
            this.IdVenta = 0;
        }
    }

}
