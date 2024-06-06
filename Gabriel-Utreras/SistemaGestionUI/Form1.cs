using SistemaGestionEntities;
using SistemaGestionBussiness;
using System.Security.Cryptography.X509Certificates;

namespace SistemaGestionUI
{
    public partial class Form1 : Form
    {

        public int id;

        public Form1()
        {
            InitializeComponent();
        }

        public void ComboBoxMostrarListado()
        {
            if (cmbSeleccionarListado.SelectedIndex == 0)
            {
                this.dgvSistemaGestion.DataSource = null;
            }
            if (cmbSeleccionarListado.SelectedIndex == 1)
            {
                MostrarUsuarios();
            }
            else if (cmbSeleccionarListado.SelectedIndex == 2)
            {
                MostrarProductos();
            }
            else if (cmbSeleccionarListado.SelectedIndex == 3)
            {
                MostrarProductosVendidos();
            }
            else if (cmbSeleccionarListado.SelectedIndex == 4)
            {
                MostrarVentas();
            }
        }

        public void CambiarFormulario()
        {
            if (cmbSeleccionarListado.SelectedIndex == 0)
            {
                this.dgvSistemaGestion.DataSource = null;
            }
            if (cmbSeleccionarListado.SelectedIndex == 1)
            {
                FormUsuario formUsuario = new FormUsuario();
                Program.form1.Hide();
                formUsuario.Show();
            }
            else if (cmbSeleccionarListado.SelectedIndex == 2)
            {
                FormProducto formProducto = new FormProducto();
                Program.form1.Hide();
                formProducto.Show();
            }
            else if (cmbSeleccionarListado.SelectedIndex == 3)
            {
                FormProductoVendido formProductoVendido = new FormProductoVendido();
                Program.form1.Hide();
                formProductoVendido.Show();
            }
            else if (cmbSeleccionarListado.SelectedIndex == 4)
            {
                FormVenta formVenta = new FormVenta();
                Program.form1.Hide();
                formVenta.Show();
            }

        }

        public void MostrarProductos()
        {

            List<Producto> productos = ProductoBussiness.GetTodosProductos();
            dgvSistemaGestion.AutoGenerateColumns = true;
            dgvSistemaGestion.DataSource = productos;
        }

        public void MostrarProductosVendidos()
        {

            List<ProductoVendido> productosVendidos = ProductoVendidoBussiness.GetProductosVendidos();
            dgvSistemaGestion.AutoGenerateColumns = true;
            dgvSistemaGestion.DataSource = productosVendidos;
        }

        public void MostrarUsuarios()
        {

            List<Usuario> usuario = UsuarioBussiness.GetUsuarios();
            dgvSistemaGestion.AutoGenerateColumns = true;
            dgvSistemaGestion.DataSource = usuario;
        }

        public void MostrarVentas()
        {

            List<Venta> venta = VentaBussiness.GetVentas();
            dgvSistemaGestion.AutoGenerateColumns = true;
            dgvSistemaGestion.DataSource = venta;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            id = 0;
            cmbSeleccionarListado.SelectedIndex = 0;

            ComboBoxMostrarListado();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            CambiarFormulario();

        }

        private void dgvSistemaGestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                id = int.Parse(dgvSistemaGestion[0, filaSeleccionada].Value.ToString());
            }

            CambiarFormulario();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvSistemaGestion.DataSource = null;
            dgvSistemaGestion.Refresh();
            id = 0;
            ComboBoxMostrarListado();

        }

        private void cmbSeleccionarListado_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBoxMostrarListado();
        }
    }
}
