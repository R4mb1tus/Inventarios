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
    public partial class FrmProductos : Form
    {   
        SqlConnection conexion = new SqlConnection("server=DESKTOP-O6MHS75\\SQLEXPRESS; database=StockInventory; integrated security=true");


        public FrmProductos()
        {
            InitializeComponent();
        }

        private void btnRegresarProductos_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void btnconectar_Click(object sender, EventArgs e)
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

        private void btnmostrarProductos_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select * from productos", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dataGridViewProductos.DataSource = tabla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO productos (ID_producto,nombre_producto,categoria_producto,precio_producto,stock_producto) VALUES (@ID_producto,@nombre_producto,@categoria_producto,@precio_producto,@stock_producto)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@ID_producto", txtboxIdProducto.Text);
            comando.Parameters.AddWithValue("@nombre_producto", txtboxNombreProducto.Text);
            comando.Parameters.AddWithValue("@categoria_producto", txtboxCategoria.Text);
            comando.Parameters.AddWithValue("@precio_producto", txtboxPrecio.Text);
            comando.Parameters.AddWithValue("@stock_producto", txtboxStock.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Insertado");
        }

        private void btneliminarProductos_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM productos WHERE ID_producto= @ID_producto";
            conexion.Open();
            SqlCommand comando = new SqlCommand( query, conexion);
            comando.Parameters.AddWithValue("@ID_producto", txtboxIdProducto.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Producto eliminado");
        }

        private void btnbuscarProductos_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM productos WHERE ID_producto = @ID_producto", conexion);
            comando.Parameters.AddWithValue("@ID_producto", txtboxIdProducto.Text);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if(registro.Read()){
                txtboxNombreProducto.Text = registro["nombre_producto"].ToString();
                txtboxCategoria.Text = registro["categoria_producto"].ToString();
                txtboxPrecio.Text = registro["precio_producto"].ToString();
                txtboxStock.Text = registro["stock_producto"].ToString();
            }
            conexion.Close();
        }

        private void btnlimpiarProductos_Click(object sender, EventArgs e)
        {
            txtboxIdProducto.Clear();
            txtboxNombreProducto.Clear();
            txtboxCategoria.Clear();
            txtboxPrecio.Clear();
            txtboxStock.Clear();
        }
    }
}
