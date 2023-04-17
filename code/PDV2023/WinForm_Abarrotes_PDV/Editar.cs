using Middle_Abarrotes_PDV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Back_CRUDs_BD;

namespace pruebaVENTA
{
    public partial class Editar : Form
    {
        Producto prod = new Producto();
        public Editar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridProductos.CurrentRow.Cells[0].Value.ToString();
            Presentacion valorpresentacion;
            switch (comboPresentacion.SelectedItem.ToString())
            {
                case "CAJA":
                    valorpresentacion = Presentacion.CAJA;
                    break;
                case "KILO":
                    valorpresentacion = Presentacion.KILO;
                    break;
                case "LITRO":
                    valorpresentacion = Presentacion.LITRO;
                    break;
                case "PIEZA":
                    valorpresentacion = Presentacion.PIEZA;
                    break;
                default:
                    valorpresentacion = Presentacion.KILO;
                    break;

            }
            bool resultado = prod.modificar(txtNom.Text, txtDesc.Text, double.Parse(txtPrecio.Text), txtCodBarras.Text, txtImagen.Text, txtMarca.Text, valorpresentacion,int.Parse(id));
            //valir el res
            if (resultado == false)
            {
                MessageBox.Show("Error al Modificar");
            }
            else
            {
                MessageBox.Show("Modificado exitosamente");
                txtCodBarras.Clear();
                txtDesc.Clear();
                txtNom.Clear();
                txtImagen.Clear();
                txtMarca.Clear();
                txtPrecio.Clear();
                textBoxbuscar.Clear();
            }

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Producto> prods = prod.consultarGeneral($" nombre LIKE '%{textBoxbuscar.Text}%' OR descripcion LIKE '%{textBoxbuscar.Text}%'");
            if (prods.Count > 0)
            {
                dataGridProductos.Rows.Clear();
                foreach (Producto pro in prods)
                {
                    dataGridProductos.Rows.Add(new object[] { pro.id, pro.nombre, pro.cod_barras, pro.descripcion, pro.precio, pro.imagen, pro.marca, pro.unidad });

                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void textBoxbuscar_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                buttonBuscar_Click(sender, e);
            }
        }

        private void dataGridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNom.Text = dataGridProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDesc.Text = dataGridProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrecio.Text = dataGridProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCodBarras.Text = dataGridProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtImagen.Text = dataGridProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtMarca.Text = dataGridProductos.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboPresentacion.Text = dataGridProductos.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnCancelarEditar_Click(object sender, EventArgs e)
        {
            txtCodBarras.Clear();
            txtDesc.Clear();
            txtNom.Clear();
            txtImagen.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            textBoxbuscar.Clear();
            dataGridProductos.ClearSelection();
        }
    }
}
