using Middle_Abarrotes_PDV;
using pruebaVENTA;

namespace WinForm_Abarrotes_PDV
{
    public partial class Guardar : Form
    {
        //crear una instancia de producto
        Producto prod = new Producto();

        public Guardar()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Presentacion valorPresentacion;
            //convertir de string a PResentacion
            switch (comboPresentacion.SelectedItem.ToString())
            {
                case "CAJA":
                    valorPresentacion = Presentacion.CAJA; break;
                case "LITRO":
                    valorPresentacion = Presentacion.LITRO; break;
                case "KILO":
                    valorPresentacion = Presentacion.KILO; break;
                case "PIEZA":
                    valorPresentacion = Presentacion.PIEZA; break;
                default:
                    valorPresentacion = Presentacion.KILO; break;


            }

            bool resultado = prod.crear(txtNom.Text, txtDesc.Text, double.Parse(txtPrecio.Text), txtCodBarras.Text, txtImagen.Text, txtMarca.Text, valorPresentacion);
            if (resultado == false)
            {
                MessageBox.Show("ERROR AL GUARDAR " + Producto.msgError);
            }
            else
            {
                MessageBox.Show("Producto registrado correctamente");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presentacion valorPresentacion;
            //convertir de string a PResentacion
            switch (comboPresentacion.SelectedItem.ToString())
            {
                case "CAJA":
                    valorPresentacion = Presentacion.CAJA; break;
                case "LITRO":
                    valorPresentacion = Presentacion.LITRO; break;
                case "KILO":
                    valorPresentacion = Presentacion.KILO; break;
                case "PIEZA":
                    valorPresentacion = Presentacion.PIEZA; break;
                default:
                    valorPresentacion = Presentacion.KILO; break;


            }

            bool resultado = prod.crear(txtNom.Text, txtDesc.Text, double.Parse(txtPrecio.Text), txtCodBarras.Text, txtImagen.Text, txtMarca.Text, valorPresentacion);
            if (resultado == false)
            {
                MessageBox.Show("ERROR AL GUARDAR " + Producto.msgError);
            }
            else
            {
                MessageBox.Show("Producto registrado correctamente");
            }
        }

        private void btnCancelarGuardar_Click(object sender, EventArgs e)
        {
            txtCodBarras.Clear();
            txtNom.Clear();
            txtImagen.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();

        }

        private void txtProductos_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtImagen_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCodBarras_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
        }
    }
}