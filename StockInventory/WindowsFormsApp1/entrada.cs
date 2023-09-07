using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmentrada : Form
    {
        public frmentrada()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            Form formularioProductos = new FrmProductos ();
            formularioProductos.ShowDialog();

        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            Form formularioProveedores = new FrmProveedores ();
            formularioProveedores.ShowDialog();
        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            Form formularioPersonal = new FrmPersonal();
            formularioPersonal.ShowDialog();
        }
    }
}
