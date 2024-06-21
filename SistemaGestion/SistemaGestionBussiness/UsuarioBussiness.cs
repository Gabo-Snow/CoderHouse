using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class UsuarioBussiness
    {
        public static List<Usuario> GetUsuarios()
        {
            return UsuarioData.ListarUsuarios();
        }

        public static List<Usuario> GetUnUsuario(int idUsuario)
        {
            return UsuarioData.ObtenerUsuario(idUsuario);
        }

        public static void AgregarUsuario(Usuario usuario)
        {
            UsuarioData.CrearUsuario(usuario);
        }

        public static void ModifyUsuario(Usuario usuario)
        {
            UsuarioData.ModificarUsuario(usuario);
        }

        public static void DeleteUsuario(Usuario usuario)
        {
            UsuarioData.EliminarUsuario(usuario);
        }

        public static List<Usuario> GetUsuariosPorNombre(string nombreRealUsuario)
        {
            return UsuarioData.ObtenerPorNombre(nombreRealUsuario);
        }

        public static Usuario GetNombrePorId(int idUsuario)
        {
            return UsuarioData.ObtenerNombrePorId(idUsuario);

        }

        public static List<Usuario> GetUsuariosPorNombreParcial(string nombreRealUsuarioParcial)
        {
            return UsuarioData.ObtenerPorNombreParcial(nombreRealUsuarioParcial);
        }


    }
}
