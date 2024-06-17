using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "GetVenta")]
        public IEnumerable<Venta> Ventas()
        {
            return VentaBussiness.GetVentas().ToArray();

        }

        [HttpGet("{id}")]
        public IActionResult GetVentaPorId(int id)
        {
            List<Venta> Venta = VentaBussiness.GetUnVenta(id);

            return Ok(Venta);

        }

        [HttpDelete(Name = "EliminarVenta")]
        public IActionResult Delete([FromBody] int id)
        {
            try
            {
                Venta eliminarVenta = new Venta { Id = id };
                VentaBussiness.DeleteVenta(eliminarVenta);

                return Ok("Venta eliminada con éxito");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "No se pudo eliminar la Venta " + ex.Message);
            }


        }

        [HttpPut(Name = "ModificarVenta")]
        public IActionResult Put([FromBody] Venta Venta)
        {
            try
            {
                VentaBussiness.ModifyVenta(Venta);
                return Ok("Venta modificada exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode(400, "No se pudo modificar la Venta " + ex.Message);
            }

        }

        [HttpPost(Name = "AgregarVenta")]
        public IActionResult Post([FromBody] Venta Venta)
        {
            try
            {
                VentaBussiness.AgregarVenta(Venta);
                return Ok("Venta agregada con éxito");
            }
            catch (Exception ex)
            {

                return StatusCode(500, "No se pudo agregar la Venta " + ex.Message);
            }
        }
    }
}
