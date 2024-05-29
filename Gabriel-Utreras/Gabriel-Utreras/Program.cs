using Gabriel_Utreras.Entidades;
using Gabriel_Utreras.Metodos;
using System.Data.SqlClient;

namespace Gabriel_Utreras
{
    public class Program
    {

        static void Main(string[] args)
        {
            
            try
            {
                var ventas = VentaData.ObtenerVenta(1); // Reemplaza el 1 con el ID del producto que deseas probar
                if (ventas.Any())
                {
                    foreach (var venta in ventas)
                    {
                        Console.WriteLine($"ID: {venta.Id}, Comentarios: {venta.Comentarios}, IdUsuario: {venta.IdUsuario}");
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron Ventas.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }


            try
            {
                var ventas = VentaData.ListarVentas(); // Reemplaza el 1 con el ID del producto que deseas probar
                if (ventas.Any())
                {
                    foreach (var venta in ventas)
                    {
                        Console.WriteLine($"ID: {venta.Id}, Comentarios: {venta.Comentarios}, IdUsuario: {venta.IdUsuario}");
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron Venta.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }

            //Venta crearVenta= new Venta
            Venta modificarVenta = new Venta

            {
                Id = 7,
                Comentarios = "mira soy una venta modificada",
                IdUsuario = 2,
            };

            try
            {
                //VentaData.CrearVenta(crearVenta);
                //VentaData.ModificarVenta(modificarVenta);

                //Console.WriteLine("Venta modificada con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar el producto: {ex.Message}");
            }



            Venta eliminarVenta = new Venta
            {
              Id = 7
            };

            try
            {
                //VentaData.EliminarVenta(eliminarVenta);
                //Console.WriteLine("ProductoVendido Eliminado");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error al eliminar: {ex.Message}");
            }

            Console.ReadLine(); // Mantén la consola abierta

        }
    }
}

