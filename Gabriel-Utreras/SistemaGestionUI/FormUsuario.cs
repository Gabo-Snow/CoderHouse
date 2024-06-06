using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }
        private void limpiarFormulario()
        {

            txtID.Text = "0";
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNombreUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.id = 0;
            Program.form1.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;

            if (int.Parse(id) != 0)
            {
                Usuario eliminarUsuario = new Usuario { Id = int.Parse(id) };

                UsuarioBussiness.DeleteUsuario(eliminarUsuario);
                MessageBox.Show("Usuario Eliminado con Éxito");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }

            limpiarFormulario();
            this.Close();
            Program.form1.id = 0;
            Program.form1.Show();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            int idUsuario = Program.form1.id;
            List<Usuario> listTxtUsuario = UsuarioBussiness.GetUnUsuario(idUsuario);

            if (idUsuario > 0)
            {
                Usuario _txtUsuario = listTxtUsuario.First();
                txtID.Text = _txtUsuario.Id.ToString();
                txtNombre.Text = _txtUsuario.Nombre.ToString();
                txtApellido.Text = _txtUsuario.Apellido.ToString();
                txtNombreUsuario.Text = _txtUsuario.NombreUsuario.ToString();
                txtContrasena.Text = _txtUsuario.Contrasena.ToString();
                txtEmail.Text = _txtUsuario.Email.ToString();

            }
            else
            {
                limpiarFormulario();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nombreUsuario= txtNombreUsuario.Text;
            string contrasena = txtContrasena.Text;
            string email = txtEmail.Text;


            int idUsuario = Program.form1.id;

            Usuario nuevoUsuario = new Usuario{ Id = idUsuario, Nombre = nombre, Apellido = apellido, NombreUsuario = nombreUsuario, Contrasena = contrasena, Email = email};

            if (idUsuario > 0)
            {
                UsuarioBussiness.ModifyUsuario(nuevoUsuario);
                MessageBox.Show("Se modificó el usuario");
            }
            else
            {

                UsuarioBussiness.AgregarUsuario(nuevoUsuario);
                MessageBox.Show("Se agregó un nuevo usuario");

            }

            limpiarFormulario();
            this.Close();
            Program.form1.id = 0;
            Program.form1.Show();
        }
    }
}
