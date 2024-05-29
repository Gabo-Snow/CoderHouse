using System.Data.SqlClient;

namespace TareaUsuario
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";
            string query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario";
            List<Usuario> listUsuario = new List<Usuario>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                usuario.Nombre = dataReader["Nombre"].ToString();
                                usuario.Apellido = dataReader["Apellido"].ToString();
                                usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                usuario.Contrasena = dataReader["Contraseña"].ToString();
                                usuario.Mail = dataReader["Mail"].ToString();

                                listUsuario.Add(usuario);

                            }
                        }
                    }
                    //   connection.Close();
                }

            }
            dgvListaUsuario.AutoGenerateColumns = true;
            dgvListaUsuario.DataSource = listUsuario;
        }
    }
}
