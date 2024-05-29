using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Utreras.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario {  get; set; }
        public string Contrasena { get; set; }
        public string Email { get; set; }

        public Usuario()
        {
            Id = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            NombreUsuario = string.Empty;
            Contrasena = string.Empty;
            Email = string.Empty;
        }

    }

}
