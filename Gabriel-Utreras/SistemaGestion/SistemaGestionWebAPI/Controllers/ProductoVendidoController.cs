using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "GetProductoVendido")]
        public IEnumerable<ProductoVendido> ProductoVendidos()
        {
            return ProductoVendidoBussiness.GetProductosVendidos().ToArray();

        }

        [HttpGet("{id}")]
        public IActionResult GetProductoVendidoPorId(int id)
        {
            List<ProductoVendido> ProductoVendido = ProductoVendidoBussiness.GetUnProductoVendido(id);

            return Ok(ProductoVendido);

        }

        [HttpDelete(Name = "EliminarProductoVendido")]
        public IActionResult Delete([FromBody] int id)
        {
            try
            {
                ProductoVendido eliminarProductoVendido = new ProductoVendido { Id = id };
                ProductoVendidoBussiness.DeleteProductoVendido(eliminarProductoVendido);

                return Ok("ProductoVendido eliminado con éxito");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "No se pudo eliminar el ProductoVendido " + ex.Message);
            }

        }

        [HttpPut(Name = "ModificarProductoVendido")]
        public IActionResult Put([FromBody] ProductoVendido ProductoVendido)
        {
            try
            {
                ProductoVendidoBussiness.ModifyProductoVendido(ProductoVendido);
                return Ok("ProductoVendido modificado exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(400, "No se pudo modificar el ProductoVendido " + ex.Message);
            }

        }

        [HttpPost(Name = "AgregarProductoVendido")]
        public IActionResult Post([FromBody] ProductoVendido ProductoVendido)
        {
            try
            {
                ProductoVendidoBussiness.AgregarProductoVendido(ProductoVendido);
                return Ok("ProductoVendido agregado con éxito");
            }
            catch (Exception ex)
            {

                return StatusCode(500, "No se pudo agregar el ProductoVendido " + ex.Message);
            }
        }
    }
}
