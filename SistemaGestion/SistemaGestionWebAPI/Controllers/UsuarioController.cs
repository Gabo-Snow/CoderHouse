using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuario")]
        public IEnumerable<Usuario> Usuarios()
        {
            return UsuarioBussiness.GetUsuarios().ToArray();

        }

        [HttpGet("{id}")]
        public IActionResult GetUsuarioPorId(int id)
        {
            List<Usuario> Usuario = UsuarioBussiness.GetUnUsuario(id);

            return Ok(Usuario);

        }

        [HttpDelete(Name = "EliminarUsuario")]
        public IActionResult Delete([FromBody] int id)
        {
            try
            {
                Usuario eliminarUsuario = new Usuario { Id = id };
                UsuarioBussiness.DeleteUsuario(eliminarUsuario);

                return Ok("Usuario eliminado con éxito");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "No se pudo eliminar el Usuario " + ex.Message);
            }


        }

        [HttpPut(Name = "ModificarUsuario")]
        public IActionResult Put([FromBody] Usuario Usuario)
        {
            try
            {
                UsuarioBussiness.ModifyUsuario(Usuario);
                return Ok("Usuario modificado exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(400, "No se pudo modificar el Usuario " + ex.Message);
            }

        }

        [HttpPost(Name = "AgregarUsuario")]
        public IActionResult Post([FromBody] Usuario Usuario)
        {
            try
            {
                UsuarioBussiness.AgregarUsuario(Usuario);
                return Ok("Usuario agregado con éxito");
            }
            catch (Exception ex)
            {

                return StatusCode(500, "No se pudo agregar el Usuario " + ex.Message);
            }
        }
    }
}
