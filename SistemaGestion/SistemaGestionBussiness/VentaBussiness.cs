using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        public static List<Venta> GetVentas()
        {
            return VentaData.ListarVentas();
        }

        public static List<Venta> GetUnVenta(int idVenta)
        {
            return VentaData.ObtenerVenta(idVenta);
        }

        public static void AgregarVenta(Venta Venta)
        {
            VentaData.CrearVenta(Venta);
        }

        public static void ModifyVenta(Venta Venta)
        {
            VentaData.ModificarVenta(Venta);
        }

        public static void DeleteVenta(Venta Venta)
        {
            VentaData.EliminarVenta(Venta);
        }
    }
}
