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
    public partial class Login : Form
    {
        frmentrada Logeo;


        public Login()
        {
            InitializeComponent();
        }
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtusuario.Text != "") && (txtPassword.Text != ""))
            {
                if ((txtusuario.Text == "Admin") && (txtPassword.Text == "pass"))
                {
                    Logeo = new frmentrada();
                    Logeo.Show();
                    this.Hide();
                }
            }
            

        }
    }
}
