using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> GetProductosVendidos()
        {
            return ProductoVendidoData.ListarProductosVendidos();
        }

        public static List<ProductoVendido> GetUnProductoVendido(int idProductoVendido)
        {
            return ProductoVendidoData.ObtenerProductoVendido(idProductoVendido);
        }

        public static void AgregarProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.CrearProductoVendido(productoVendido);
        }

        public static void ModifyProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.ModificarProductoVendido(productoVendido);
        }

        public static void DeleteProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.EliminarProductoVendido(productoVendido);
        }
    }
}
