using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmPersonal : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-O6MHS75\\SQLEXPRESS; database=StockInventory; integrated security=true");


        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void btnRegresarPersonal_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnconectarPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conectados");
            }

            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnmostrarPersonal_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from personal", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridViewPersonal.DataSource = tabla;
        }

        private void btninsertarPersonal_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO personal (IDpersona_personal,nombrepersona_personal,apellidospersona_personal,area_personal,salario_persona) VALUES (@IDpersona_personal,@nombrepersona_personal,@apellidospersona_personal,@area_personal,@salario_persona)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@IDpersona_personal", txtboxIdPersona.Text);
            comando.Parameters.AddWithValue("@nombrepersona_personal", txtboxNombresPersona.Text);
            comando.Parameters.AddWithValue("@apellidospersona_personal", txtboxApellidosPesona.Text);
            comando.Parameters.AddWithValue("@area_personal", txtboxAreaPersonal.Text);
            comando.Parameters.AddWithValue("@salario_persona", txtboxSalarioPersonal.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Insertado");
        }

        private void btneliminarPersonal_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM personal WHERE IDpersona_personal= @IDpersona_personal";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@IDpersona_personal", txtboxIdPersona.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Personal eliminado");
        }

        private void btnbuscarPersonal_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM personal WHERE IDpersona_personal = @IDpersona_personal", conexion);
            comando.Parameters.AddWithValue("@IDpersona_personal", txtboxIdPersona.Text);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtboxNombresPersona.Text = registro["nombrepersona_personal"].ToString();
                txtboxApellidosPesona.Text = registro["apellidospersona_personal"].ToString();
                txtboxAreaPersonal.Text = registro["area_personal"].ToString();
                txtboxSalarioPersonal.Text = registro["salario_persona"].ToString();
            }
            conexion.Close();
        }

        private void btnlimpiarPersonal_Click(object sender, EventArgs e)
        {
            txtboxIdPersona.Clear();
            txtboxNombresPersona.Clear();
            txtboxApellidosPesona.Clear();
            txtboxAreaPersonal.Clear();
            txtboxSalarioPersonal.Clear();
        }
    }
}
