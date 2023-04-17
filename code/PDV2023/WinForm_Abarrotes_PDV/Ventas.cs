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

namespace WinForm_Abarrotes_PDV
{
    public partial class Ventas : Form
    {
        VentaDetalles venta= new VentaDetalles();
 
        public Ventas()
        {
            InitializeComponent();
        }

        private void buttonBuscarventa_Click(object sender, EventArgs e)
        {
            List<VentaDetalles> ventadetalles = venta.consultarGeneral($" venta_id LIKE '%{textBoxbuscarventa.Text}%'");
            if (ventadetalles.Count > 0)
            {
                dataGridDetallesVentas.Rows.Clear();
                foreach (VentaDetalles pro in ventadetalles)
                {
                    dataGridDetallesVentas.Rows.Add(new object[] { pro.venta_id,pro.producto_id,pro.cantidad });

                }
            }
        }
    }
}
