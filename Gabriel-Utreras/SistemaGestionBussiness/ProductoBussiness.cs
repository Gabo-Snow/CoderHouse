using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoBussiness
    {
        public static List<Producto> GetTodosProductos() 
        {
            return ProductoData.ListarProductos();
        }

        public static List<Producto> GetUnProducto(int idProducto)
        {            
            return ProductoData.ObtenerProducto(idProducto);
        }

        public static void AgregarProducto(Producto producto)
        {
            ProductoData.CrearProducto(producto);
        }

        public static void ModifyProducto (Producto producto)
        {
            ProductoData.ModificarProducto(producto);
        }

        public static void DeleteProducto(Producto producto) 
        {
            ProductoData.EliminarProducto(producto);
        }

    }
}
