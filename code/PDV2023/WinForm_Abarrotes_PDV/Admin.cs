using pruebaVENTA;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void AceptarLogin_Click(object sender, EventArgs e)
        {
            if (textboxPasswordAdmin.Text == "Ganzo")
            {
                Interfaz interfaz = new Interfaz();
                this.Hide();
                interfaz.Show();
            }
            else
            {
                MessageBox.Show("CONTRASEÑA INCORRECTA");
            }
        }

        private void RegresarAdmin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
