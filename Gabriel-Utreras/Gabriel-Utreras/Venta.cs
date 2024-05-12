using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Utreras
{
    public class Venta
    {
        private int Id {  get; set; }
        private string Comentarios { get; set; }
        private int IdUsuario { get; set; }
        
        public Venta()
        {
            this.Id = 0;
            this.Comentarios = string.Empty;
            this.IdUsuario = 0;
        }
    }
}
