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
    public partial class FormVenta : Form
    {
        public FormVenta()
        {
            InitializeComponent();
        }
        private void limpiarFormulario()
        {

            txtID.Text = "0";
            txtComentarios.Text = string.Empty;
            txtIdUsuario.Text = string.Empty;

        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            int idVenta = Program.form1.id;
            List<Venta> listTxtVenta = VentaBussiness.GetUnVenta(idVenta);

            if (idVenta > 0)
            {
                Venta _txtVenta = listTxtVenta.First();
                txtID.Text = _txtVenta.Id.ToString();
                txtComentarios.Text = _txtVenta.Comentarios.ToString();
                txtIdUsuario.Text = _txtVenta.IdUsuario.ToString();

            }
            else
            {
                limpiarFormulario();
            }
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
                Venta eliminarVenta = new Venta { Id = int.Parse(id) };

                VentaBussiness.DeleteVenta(eliminarVenta);
                MessageBox.Show("Venta Eliminada con Éxito");
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
            string comentarios = txtComentarios.Text;
            int idUsuario = Convert.ToInt32(txtIdUsuario.Text);

            int idVenta = Program.form1.id;

            Venta nuevaVenta = new Venta { Id = idVenta, Comentarios = comentarios, IdUsuario = idUsuario };

            if (idVenta > 0)
            {
                VentaBussiness.ModifyVenta(nuevaVenta);
                MessageBox.Show("Se modificó la Venta");
            }
            else
            {

                VentaBussiness.AgregarVenta(nuevaVenta);
                MessageBox.Show("Se agregó una nueva Venta");

            }

            limpiarFormulario();
            this.Close();
            Program.form1.id = 0;
            Program.form1.Show();
        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
