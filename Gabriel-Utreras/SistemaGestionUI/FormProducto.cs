using SistemaGestionBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionEntities;

namespace SistemaGestionUI
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        private void limpiarFormulario()
        {

            txtID.Text = "0";
            txtDescripcion.Text = string.Empty;
            txtCosto.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtIdUsuario.Text = string.Empty;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {


            this.Close();
            Program.form1.id = 0;
            Program.form1.Show();

        }


        private void FormProducto_Load(object sender, EventArgs e)
        {
            int idProducto = Program.form1.id;
            List<Producto> listTxtProducto = ProductoBussiness.GetUnProducto(idProducto);

            if (idProducto > 0)
            {
                Producto _txtProducto = listTxtProducto.First();
                txtID.Text = _txtProducto.Id.ToString();
                txtDescripcion.Text = _txtProducto.Descripcion.ToString();
                txtCosto.Text = _txtProducto.Costo.ToString();
                txtPrecioVenta.Text = _txtProducto.PrecioVenta.ToString();
                txtStock.Text = _txtProducto.Stock.ToString();
                txtIdUsuario.Text = _txtProducto.IdUsuario.ToString();

            }
            else
            {
                limpiarFormulario();
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;

            if (int.Parse(id) != 0)
            {
                Producto eliminarProducto = new Producto { Id = int.Parse(id) };

                ProductoBussiness.DeleteProducto(eliminarProducto);
                MessageBox.Show("Producto Eliminado con Éxito");
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string descripcion = txtDescripcion.Text;
            double costo = Convert.ToDouble(txtCosto.Text);
            double precioVenta = Convert.ToDouble(txtPrecioVenta.Text);
            int stock = Convert.ToInt32(txtStock.Text);
            int idUsuario = Convert.ToInt32(txtIdUsuario.Text);

            int idProducto = Program.form1.id;

            Producto nuevoProducto = new Producto { Id = idProducto, Descripcion = descripcion, Costo = costo, PrecioVenta = precioVenta, Stock = stock, IdUsuario = idUsuario };

            if (idProducto > 0)
            {
                ProductoBussiness.ModifyProducto(nuevoProducto);
                MessageBox.Show("Se modificó el producto");
            }
            else
            {

                ProductoBussiness.AgregarProducto(nuevoProducto);
                MessageBox.Show("Se agregó un nuevo producto");

            }

            limpiarFormulario();
            this.Close();
            Program.form1.id = 0;
            Program.form1.Show();
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {

            //controla que solo se pueda ingresar doubles con 1 punto decimal:

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {

            //controla que solo se pueda ingresar doubles con 1 punto decimal:

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito ni un control

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito ni un control

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
