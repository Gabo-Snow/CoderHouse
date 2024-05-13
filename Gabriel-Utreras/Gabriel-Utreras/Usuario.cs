using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Utreras
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contrasena { get; set; }
        public string Email { get; set; }

        public Usuario()
        {
            this.Id = 0;
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.Contrasena = string.Empty;
            this.Email = string.Empty;
        }

    }
   
}
