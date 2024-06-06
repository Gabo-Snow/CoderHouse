using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Utreras.Metodos
{
    public static class ConexionADO
    {
        private static string stringConnection;
        private static SqlConnection conexion;

        static ConexionADO()

        {
            ConexionADO.stringConnection = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";
        }
        public static SqlConnection GetConexion()
        {
            if (ConexionADO.conexion is null || ConexionADO.conexion.State == System.Data.ConnectionState.Broken || ConexionADO.conexion.State == System.Data.ConnectionState.Closed)
            {
                ConexionADO.conexion = new SqlConnection(ConexionADO.stringConnection);
            }

            ConexionADO.conexion.Open();

            return ConexionADO.conexion;
        }
    }
}
