namespace WindowsFormsApp1
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtboxIdProducto = new System.Windows.Forms.TextBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtboxNombreProducto = new System.Windows.Forms.TextBox();
            this.txtboxCategoria = new System.Windows.Forms.TextBox();
            this.txtboxPrecio = new System.Windows.Forms.TextBox();
            this.txtboxStock = new System.Windows.Forms.TextBox();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.btnRegresarProductos = new System.Windows.Forms.Button();
            this.btnconectarProductos = new System.Windows.Forms.Button();
            this.btnbuscarProductos = new System.Windows.Forms.Button();
            this.btnmostrarProductos = new System.Windows.Forms.Button();
            this.btninsertarProductos = new System.Windows.Forms.Button();
            this.btneliminarProductos = new System.Windows.Forms.Button();
            this.btnlimpiarProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxIdProducto
            // 
            this.txtboxIdProducto.Location = new System.Drawing.Point(669, 97);
            this.txtboxIdProducto.Name = "txtboxIdProducto";
            this.txtboxIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtboxIdProducto.TabIndex = 0;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.Location = new System.Drawing.Point(481, 104);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(133, 20);
            this.lblIdProducto.TabIndex = 1;
            this.lblIdProducto.Text = "ID del producto";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(481, 153);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(176, 20);
            this.lblNombreProducto.TabIndex = 2;
            this.lblNombreProducto.Text = "Nombre del producto";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(481, 205);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(87, 20);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(481, 258);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(59, 20);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(481, 306);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(55, 20);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock";
            // 
            // txtboxNombreProducto
            // 
            this.txtboxNombreProducto.Location = new System.Drawing.Point(669, 150);
            this.txtboxNombreProducto.Name = "txtboxNombreProducto";
            this.txtboxNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtboxNombreProducto.TabIndex = 6;
            // 
            // txtboxCategoria
            // 
            this.txtboxCategoria.Location = new System.Drawing.Point(669, 205);
            this.txtboxCategoria.Name = "txtboxCategoria";
            this.txtboxCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtboxCategoria.TabIndex = 7;
            // 
            // txtboxPrecio
            // 
            this.txtboxPrecio.Location = new System.Drawing.Point(669, 258);
            this.txtboxPrecio.Name = "txtboxPrecio";
            this.txtboxPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtboxPrecio.TabIndex = 9;
            // 
            // txtboxStock
            // 
            this.txtboxStock.Location = new System.Drawing.Point(669, 306);
            this.txtboxStock.Name = "txtboxStock";
            this.txtboxStock.Size = new System.Drawing.Size(100, 20);
            this.txtboxStock.TabIndex = 10;
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(23, 85);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(421, 247);
            this.dataGridViewProductos.TabIndex = 11;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            // 
            // btnRegresarProductos
            // 
            this.btnRegresarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarProductos.Location = new System.Drawing.Point(23, 415);
            this.btnRegresarProductos.Name = "btnRegresarProductos";
            this.btnRegresarProductos.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarProductos.TabIndex = 12;
            this.btnRegresarProductos.Text = "Regresar";
            this.btnRegresarProductos.UseVisualStyleBackColor = true;
            this.btnRegresarProductos.Click += new System.EventHandler(this.btnRegresarProductos_Click);
            // 
            // btnconectarProductos
            // 
            this.btnconectarProductos.Location = new System.Drawing.Point(205, 374);
            this.btnconectarProductos.Name = "btnconectarProductos";
            this.btnconectarProductos.Size = new System.Drawing.Size(88, 28);
            this.btnconectarProductos.TabIndex = 13;
            this.btnconectarProductos.Text = "Conectar";
            this.btnconectarProductos.UseVisualStyleBackColor = true;
            this.btnconectarProductos.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // btnbuscarProductos
            // 
            this.btnbuscarProductos.Location = new System.Drawing.Point(657, 374);
            this.btnbuscarProductos.Name = "btnbuscarProductos";
            this.btnbuscarProductos.Size = new System.Drawing.Size(88, 28);
            this.btnbuscarProductos.TabIndex = 14;
            this.btnbuscarProductos.Text = "Buscar";
            this.btnbuscarProductos.UseVisualStyleBackColor = true;
            this.btnbuscarProductos.Click += new System.EventHandler(this.btnbuscarProductos_Click);
            // 
            // btnmostrarProductos
            // 
            this.btnmostrarProductos.Location = new System.Drawing.Point(320, 374);
            this.btnmostrarProductos.Name = "btnmostrarProductos";
            this.btnmostrarProductos.Size = new System.Drawing.Size(88, 28);
            this.btnmostrarProductos.TabIndex = 15;
            this.btnmostrarProductos.Text = "Mostrar";
            this.btnmostrarProductos.UseVisualStyleBackColor = true;
            this.btnmostrarProductos.Click += new System.EventHandler(this.btnmostrarProductos_Click);
            // 
            // btninsertarProductos
            // 
            this.btninsertarProductos.Location = new System.Drawing.Point(432, 374);
            this.btninsertarProductos.Name = "btninsertarProductos";
            this.btninsertarProductos.Size = new System.Drawing.Size(88, 28);
            this.btninsertarProductos.TabIndex = 16;
            this.btninsertarProductos.Text = "Insertar";
            this.btninsertarProductos.UseVisualStyleBackColor = true;
            this.btninsertarProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneliminarProductos
            // 
            this.btneliminarProductos.Location = new System.Drawing.Point(546, 374);
            this.btneliminarProductos.Name = "btneliminarProductos";
            this.btneliminarProductos.Size = new System.Drawing.Size(88, 28);
            this.btneliminarProductos.TabIndex = 17;
            this.btneliminarProductos.Text = "Eliminar";
            this.btneliminarProductos.UseVisualStyleBackColor = true;
            this.btneliminarProductos.Click += new System.EventHandler(this.btneliminarProductos_Click);
            // 
            // btnlimpiarProductos
            // 
            this.btnlimpiarProductos.Location = new System.Drawing.Point(669, 35);
            this.btnlimpiarProductos.Name = "btnlimpiarProductos";
            this.btnlimpiarProductos.Size = new System.Drawing.Size(88, 28);
            this.btnlimpiarProductos.TabIndex = 18;
            this.btnlimpiarProductos.Text = "Limpiar";
            this.btnlimpiarProductos.UseVisualStyleBackColor = true;
            this.btnlimpiarProductos.Click += new System.EventHandler(this.btnlimpiarProductos_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpiarProductos);
            this.Controls.Add(this.btneliminarProductos);
            this.Controls.Add(this.btninsertarProductos);
            this.Controls.Add(this.btnmostrarProductos);
            this.Controls.Add(this.btnbuscarProductos);
            this.Controls.Add(this.btnconectarProductos);
            this.Controls.Add(this.btnRegresarProductos);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.txtboxStock);
            this.Controls.Add(this.txtboxPrecio);
            this.Controls.Add(this.txtboxCategoria);
            this.Controls.Add(this.txtboxNombreProducto);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.txtboxIdProducto);
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxIdProducto;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtboxNombreProducto;
        private System.Windows.Forms.TextBox txtboxCategoria;
        private System.Windows.Forms.TextBox txtboxPrecio;
        private System.Windows.Forms.TextBox txtboxStock;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button btnRegresarProductos;
        private System.Windows.Forms.Button btnconectarProductos;
        private System.Windows.Forms.Button btnbuscarProductos;
        private System.Windows.Forms.Button btnmostrarProductos;
        private System.Windows.Forms.Button btninsertarProductos;
        private System.Windows.Forms.Button btneliminarProductos;
        private System.Windows.Forms.Button btnlimpiarProductos;
    }
}