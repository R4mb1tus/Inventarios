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
  
    public partial class FrmProveedores : Form
    {

        SqlConnection conexion = new SqlConnection("server=DESKTOP-O6MHS75\\SQLEXPRESS; database=StockInventory; integrated security=true");

        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void btnRegresarProveedores_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnconectarProductos_Click(object sender, EventArgs e)
        {
            try { 
                conexion.Open();
                MessageBox.Show("Conectados");
            } 
            
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Proveedores", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridViewProveedores.DataSource = tabla;

        }

        private void btninsertarProveedores_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Proveedores (ID_proveedor,nombre_proveedor,direccion_proveedor,telefono_proveedor,correo_proveedor) VALUES (@ID_proveedor,@nombre_proveedor,@direccion_proveedor,@telefono_proveedor,@correo_proveedor)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@ID_proveedor", txtboxIdProveedor.Text);
            comando.Parameters.AddWithValue("@nombre_proveedor", txtboxNombreProveedor.Text);
            comando.Parameters.AddWithValue("@direccion_proveedor", txtboxDireccionProveedor.Text);
            comando.Parameters.AddWithValue("@telefono_proveedor", txtboxTelefonoProveedor.Text);
            comando.Parameters.AddWithValue("@correo_proveedor", txtboxCorreoProveedor.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Insertado");
        }

        private void btneliminarProveedores_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Proveedores WHERE ID_proveedor= @ID_proveedor";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@ID_proveedor", txtboxIdProveedor.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Proveedor eliminado");
        }

        private void btnbuscarProveedores_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM Proveedores WHERE ID_proveedor = @ID_proveedor", conexion);
            comando.Parameters.AddWithValue("@ID_proveedor", txtboxIdProveedor.Text);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtboxNombreProveedor.Text = registro["nombre_proveedor"].ToString();
                txtboxDireccionProveedor.Text = registro["direccion_proveedor"].ToString();
                txtboxTelefonoProveedor.Text  = registro["telefono_proveedor"].ToString();
                txtboxCorreoProveedor.Text = registro["correo_proveedor"].ToString();
            }
            conexion.Close();
        }

        private void btnlimpiarProveedores_Click(object sender, EventArgs e)
        {
            txtboxIdProveedor.Clear();
            txtboxNombreProveedor.Clear();
            txtboxDireccionProveedor.Clear();
            txtboxTelefonoProveedor.Clear();
            txtboxCorreoProveedor.Clear();
        }
    }
}
