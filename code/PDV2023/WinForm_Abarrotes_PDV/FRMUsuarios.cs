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


namespace WinForm_Abarrotes_PDV
{
    public partial class FRMUsuarios : Form
    {

        Usuarios usua = new Usuarios();
        public FRMUsuarios()
        {
            InitializeComponent();
        }

        private void buttonGuardarUsuarios_Click(object sender, EventArgs e)
        {
            bool resultado = usua.crear(txtnombreusuario.Text, txtcorreousuario.Text, txtpasswordusuario.Text, txtimagenusuario.Text);
            if (resultado == false)
            {
                MessageBox.Show("ERROR AL GUARDAR ");
            }
            else
            {
                MessageBox.Show("Usuario registrado correctamente");
                txtcorreousuario.Clear();
                txtimagenusuario.Clear();
                txtpasswordusuario.Clear();
                txtnombreusuario.Clear();
                textBoxIDusuario.Clear();
            }
        }

        private void buttonEditarUsuarios_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bool resultado = usua.modificar(txtnombreusuario.Text, txtcorreousuario.Text, txtpasswordusuario.Text, txtimagenusuario.Text, int.Parse(id));
            //valir el res
            if (resultado == false)
            {
                MessageBox.Show("Error al Modificar");
            }
            else
            {
                MessageBox.Show("Modificado exitosamente");
                txtcorreousuario.Clear();
                txtimagenusuario.Clear();
                txtpasswordusuario.Clear();
                txtnombreusuario.Clear();
                textBoxIDusuario.Clear();
            }
        }


        private void btnElimianrUsuarios_Click(object sender, EventArgs e)
        {
            bool res = usua.borrarusuario(int.Parse(textBoxIDusuario.Text));
            if (res != null)
            {
                MessageBox.Show("El Usuario se ha eleminado correctamente");
                textBoxbuscarusuario.Clear();

            }
            else
            {
                MessageBox.Show("Error al Eliminar ");

            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Usuarios> usuario = usua.consultarGeneral($" nombre LIKE '%{textBoxbuscarusuario.Text}%'");
            if (usuario.Count > 0)
            {
                dataGridView1.Rows.Clear();
                foreach (Usuarios pro in usuario)
                {
                    dataGridView1.Rows.Add(new object[] { pro.id, pro.nombre, pro.correo, pro.password,pro.imagen});

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombreusuario.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcorreousuario.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtpasswordusuario.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtimagenusuario.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void buttonBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                buttonBuscar_Click(sender, e);
            }
        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            txtcorreousuario.Clear();
            txtimagenusuario.Clear();
            txtpasswordusuario.Clear();
            txtnombreusuario.Clear();
            textBoxIDusuario.Clear();
            textBoxbuscarusuario.Clear();
        }
    }
}
