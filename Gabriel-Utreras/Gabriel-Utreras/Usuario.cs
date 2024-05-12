using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Utreras
{
    public class Usuario
    {
        private int Id { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Contrasena { get; set; }
        private string Email { get; set; }

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
