using Gabriel_Utreras.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Data;

namespace Gabriel_Utreras.Metodos
{
    public static class UsuarioData
    {
        public static List<Usuario> ObtenerUsuario (int idUsuario)
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "Select Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario WHERE Id=@idUsuario;";
            using (SqlConnection conexion = ConexionADO.GetConexion())
            {
                //conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "idUsuario";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = idUsuario;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dataReader = comando.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                usuario.Nombre = dataReader["Nombre"].ToString();
                                usuario.Apellido = dataReader["Apellido"].ToString();
                                usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                usuario.Contrasena = dataReader["Contraseña"].ToString();
                                usuario.Email = dataReader["Mail"].ToString();

                                listaUsuario.Add(usuario);


                            }
                        }
                    }

                }
            }
            return listaUsuario;
        }

        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> listaDeUsuarios = new List<Usuario>();
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "Select Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario";
            using (SqlConnection conexion = ConexionADO.GetConexion())
            {
                //conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader dataReader = comando.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                usuario.Nombre = dataReader["Nombre"].ToString();
                                usuario.Apellido = dataReader["Apellido"].ToString();
                                usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                usuario.Contrasena = dataReader["Contraseña"].ToString();
                                usuario.Email = dataReader["Mail"].ToString();

                                listaDeUsuarios.Add(usuario);


                            }
                        }
                    }

                }
            }
            return listaDeUsuarios;
        }

        public static void CrearUsuario(Usuario usuario)
        {
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";

            var query = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail)" +
                "VALUES (@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail)";

            using (SqlConnection conexion = ConexionADO.GetConexion())
            {
                //conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                    comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                    comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contrasena });
                    comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Email });

                    comando.ExecuteNonQuery();

                }
                conexion.Close();
            }

        }
        public static void ModificarProducto(Usuario usuario)
        {
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "UPDATE Usuario " +
                        "SET Nombre = @Nombre, " +
                        "Apellido = @Apellido, " +
                        "NombreUsuario = @NombreUsuario, " +
                        "Contraseña = @Contraseña, " +
                        "Mail= @Mail " +
                        "WHERE Id = @Id";

            using (SqlConnection conexion = ConexionADO.GetConexion())
            {
                //conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });
                    comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                    comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                    comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contrasena });
                    comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Email });

                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }

        }

        public static void EliminarUsuario(Usuario usuario)
        {
            //string connectionString = @"Server=localhost\SQLExpress;Database=SistemaGestion;Trusted_Connection=True;";

            var query = "DELETE FROM Usuario WHERE Id= @Id";

            using (SqlConnection conexion = ConexionADO.GetConexion())
            {
                //conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });

                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }

        }
    }
}
