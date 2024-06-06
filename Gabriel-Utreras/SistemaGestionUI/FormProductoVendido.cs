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
    public partial class FormProductoVendido : Form
    {
        public FormProductoVendido()
        {
            InitializeComponent();
        }

        private void limpiarFormulario()
        {

            txtID.Text = "0";
            txtIdProducto.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtIdVenta.Text = string.Empty;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.id = 0;
            Program.form1.Show();
        }

        private void FormProductoVendido_Load(object sender, EventArgs e)
        {
            int idProductoVendido = Program.form1.id;
            List<ProductoVendido> listTxtProductoVendido = ProductoVendidoBussiness.GetUnProductoVendido(idProductoVendido);

            if (idProductoVendido > 0)
            {
                ProductoVendido _txtProductoVendido = listTxtProductoVendido.First();
                txtID.Text = _txtProductoVendido.Id.ToString();
                txtIdProducto.Text = _txtProductoVendido.IdProducto.ToString();
                txtStock.Text = _txtProductoVendido.Stock.ToString();
                txtIdVenta.Text = _txtProductoVendido.IdVenta.ToString();

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
                ProductoVendido eliminarProductoVendido = new ProductoVendido { Id = int.Parse(id) };

                ProductoVendidoBussiness.DeleteProductoVendido(eliminarProductoVendido);
                MessageBox.Show("Producto Vendido Eliminado con Éxito");
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

            int idProducto = Convert.ToInt32(txtIdProducto.Text);
            int stock = Convert.ToInt32(txtStock.Text);
            int idVenta = Convert.ToInt32(txtIdVenta.Text);

            int idProductoVendido = Program.form1.id;

            ProductoVendido nuevoProductoVendido = new ProductoVendido { Id = idProductoVendido, IdProducto = idProducto, Stock = stock, IdVenta = idVenta };

            if (idProductoVendido > 0)
            {
                ProductoVendidoBussiness.ModifyProductoVendido(nuevoProductoVendido);
                MessageBox.Show("Se modificó el producto vendido");
            }
            else
            {

                ProductoVendidoBussiness.AgregarProductoVendido(nuevoProductoVendido);
                MessageBox.Show("Se agregó un nuevo producto vendido");

            }

            limpiarFormulario();
            this.Close();
            Program.form1.id = 0;
            Program.form1.Show();
        }

        //Evitan que escriban carácteres no numéricos

        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

