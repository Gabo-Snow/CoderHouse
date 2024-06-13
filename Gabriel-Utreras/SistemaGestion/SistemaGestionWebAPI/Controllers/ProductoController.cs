using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System.Security.Cryptography.X509Certificates;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "GetProducto")]
        public IEnumerable<Producto> Productos()
        {
            return ProductoBussiness.GetTodosProductos().ToArray() ;
            
        }

        [HttpGet("{id}")]
        public IActionResult GetProductoPorId(int id) 
        {
            List<Producto> producto = ProductoBussiness.GetUnProducto(id);

            return Ok(producto);

        }

        [HttpDelete(Name = "EliminarProducto")]
        public IActionResult Delete([FromBody] int id) 
        {
            try
            {
                Producto eliminarProducto = new Producto { Id = id };
                ProductoBussiness.DeleteProducto(eliminarProducto);

                return Ok("Producto eliminado con éxito");
            }
            catch (Exception ex) 
            { 
                return StatusCode(500, "No se pudo eliminar el producto "+ ex.Message);
            }  
            
            
        }

        [HttpPut(Name = "ModificarProducto")]
        public IActionResult Put([FromBody] Producto producto)
        {
            try
            {
                ProductoBussiness.ModifyProducto(producto);
                return Ok("Producto modificado exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(400, "No se pudo modificar el producto " + ex.Message);
            }

        }

        [HttpPost(Name = "AgregarProducto")]
        public IActionResult Post([FromBody] Producto producto) 
        {
            try
            {
                ProductoBussiness.AgregarProducto(producto);
                return Ok("Producto agregado con éxito");
            }
            catch (Exception ex) 
            {
                 
               return StatusCode(500, "No se pudo agregar el producto " + ex.Message);
            }
        }


    }
}
