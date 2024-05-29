using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Utreras.Entidades
{
    public class Venta
    {
        public int Id {  get; set; }
        public string Comentarios { get; set; }
        public int IdUsuario { get; set; }
        
        public Venta()
        {
            this.Id = 0;
            this.Comentarios = string.Empty;
            this.IdUsuario = 0;
        }
    }
}
