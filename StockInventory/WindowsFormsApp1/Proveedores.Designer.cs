namespace WindowsFormsApp1
{
    partial class FrmProveedores
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
            this.dataGridViewProveedores = new System.Windows.Forms.DataGridView();
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.lblDireccionProveedor = new System.Windows.Forms.Label();
            this.lblTelefonoProveedor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxIdProveedor = new System.Windows.Forms.TextBox();
            this.txtboxNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtboxDireccionProveedor = new System.Windows.Forms.TextBox();
            this.txtboxTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.txtboxCorreoProveedor = new System.Windows.Forms.TextBox();
            this.btnRegresarProveedores = new System.Windows.Forms.Button();
            this.btnconectarProveedores = new System.Windows.Forms.Button();
            this.btnmostrarProveedores = new System.Windows.Forms.Button();
            this.btninsertarProveedores = new System.Windows.Forms.Button();
            this.btneliminarProveedores = new System.Windows.Forms.Button();
            this.btnbuscarProveedores = new System.Windows.Forms.Button();
            this.btnlimpiarProveedores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProveedores
            // 
            this.dataGridViewProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProveedores.Location = new System.Drawing.Point(33, 95);
            this.dataGridViewProveedores.Name = "dataGridViewProveedores";
            this.dataGridViewProveedores.Size = new System.Drawing.Size(410, 240);
            this.dataGridViewProveedores.TabIndex = 0;
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProveedor.Location = new System.Drawing.Point(472, 126);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(142, 20);
            this.lblIdProveedor.TabIndex = 1;
            this.lblIdProveedor.Text = "ID del proveedor";
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProveedor.Location = new System.Drawing.Point(472, 169);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(185, 20);
            this.lblNombreProveedor.TabIndex = 2;
            this.lblNombreProveedor.Text = "Nombre del proveedor";
            // 
            // lblDireccionProveedor
            // 
            this.lblDireccionProveedor.AutoSize = true;
            this.lblDireccionProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionProveedor.Location = new System.Drawing.Point(470, 209);
            this.lblDireccionProveedor.Name = "lblDireccionProveedor";
            this.lblDireccionProveedor.Size = new System.Drawing.Size(169, 20);
            this.lblDireccionProveedor.TabIndex = 3;
            this.lblDireccionProveedor.Text = "Direccion proveedor";
            // 
            // lblTelefonoProveedor
            // 
            this.lblTelefonoProveedor.AutoSize = true;
            this.lblTelefonoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoProveedor.Location = new System.Drawing.Point(470, 248);
            this.lblTelefonoProveedor.Name = "lblTelefonoProveedor";
            this.lblTelefonoProveedor.Size = new System.Drawing.Size(165, 20);
            this.lblTelefonoProveedor.TabIndex = 4;
            this.lblTelefonoProveedor.Text = "Telefono Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Correo proveedor";
            // 
            // txtboxIdProveedor
            // 
            this.txtboxIdProveedor.Location = new System.Drawing.Point(658, 122);
            this.txtboxIdProveedor.Name = "txtboxIdProveedor";
            this.txtboxIdProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtboxIdProveedor.TabIndex = 6;
            // 
            // txtboxNombreProveedor
            // 
            this.txtboxNombreProveedor.Location = new System.Drawing.Point(658, 165);
            this.txtboxNombreProveedor.Name = "txtboxNombreProveedor";
            this.txtboxNombreProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtboxNombreProveedor.TabIndex = 7;
            // 
            // txtboxDireccionProveedor
            // 
            this.txtboxDireccionProveedor.Location = new System.Drawing.Point(658, 205);
            this.txtboxDireccionProveedor.Name = "txtboxDireccionProveedor";
            this.txtboxDireccionProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtboxDireccionProveedor.TabIndex = 8;
            // 
            // txtboxTelefonoProveedor
            // 
            this.txtboxTelefonoProveedor.Location = new System.Drawing.Point(658, 244);
            this.txtboxTelefonoProveedor.Name = "txtboxTelefonoProveedor";
            this.txtboxTelefonoProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtboxTelefonoProveedor.TabIndex = 9;
            // 
            // txtboxCorreoProveedor
            // 
            this.txtboxCorreoProveedor.Location = new System.Drawing.Point(658, 290);
            this.txtboxCorreoProveedor.Name = "txtboxCorreoProveedor";
            this.txtboxCorreoProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtboxCorreoProveedor.TabIndex = 10;
            // 
            // btnRegresarProveedores
            // 
            this.btnRegresarProveedores.Location = new System.Drawing.Point(12, 415);
            this.btnRegresarProveedores.Name = "btnRegresarProveedores";
            this.btnRegresarProveedores.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarProveedores.TabIndex = 11;
            this.btnRegresarProveedores.Text = "Regresar";
            this.btnRegresarProveedores.UseVisualStyleBackColor = true;
            this.btnRegresarProveedores.Click += new System.EventHandler(this.btnRegresarProveedores_Click);
            // 
            // btnconectarProveedores
            // 
            this.btnconectarProveedores.Location = new System.Drawing.Point(202, 378);
            this.btnconectarProveedores.Name = "btnconectarProveedores";
            this.btnconectarProveedores.Size = new System.Drawing.Size(88, 28);
            this.btnconectarProveedores.TabIndex = 14;
            this.btnconectarProveedores.Text = "Conectar";
            this.btnconectarProveedores.UseVisualStyleBackColor = true;
            this.btnconectarProveedores.Click += new System.EventHandler(this.btnconectarProductos_Click);
            // 
            // btnmostrarProveedores
            // 
            this.btnmostrarProveedores.Location = new System.Drawing.Point(321, 378);
            this.btnmostrarProveedores.Name = "btnmostrarProveedores";
            this.btnmostrarProveedores.Size = new System.Drawing.Size(88, 28);
            this.btnmostrarProveedores.TabIndex = 15;
            this.btnmostrarProveedores.Text = "Mostrar";
            this.btnmostrarProveedores.UseVisualStyleBackColor = true;
            this.btnmostrarProveedores.Click += new System.EventHandler(this.button1_Click);
            // 
            // btninsertarProveedores
            // 
            this.btninsertarProveedores.Location = new System.Drawing.Point(437, 378);
            this.btninsertarProveedores.Name = "btninsertarProveedores";
            this.btninsertarProveedores.Size = new System.Drawing.Size(88, 28);
            this.btninsertarProveedores.TabIndex = 16;
            this.btninsertarProveedores.Text = "Insertar";
            this.btninsertarProveedores.UseVisualStyleBackColor = true;
            this.btninsertarProveedores.Click += new System.EventHandler(this.btninsertarProveedores_Click);
            // 
            // btneliminarProveedores
            // 
            this.btneliminarProveedores.Location = new System.Drawing.Point(551, 378);
            this.btneliminarProveedores.Name = "btneliminarProveedores";
            this.btneliminarProveedores.Size = new System.Drawing.Size(88, 28);
            this.btneliminarProveedores.TabIndex = 17;
            this.btneliminarProveedores.Text = "Eliminar";
            this.btneliminarProveedores.UseVisualStyleBackColor = true;
            this.btneliminarProveedores.Click += new System.EventHandler(this.btneliminarProveedores_Click);
            // 
            // btnbuscarProveedores
            // 
            this.btnbuscarProveedores.Location = new System.Drawing.Point(670, 378);
            this.btnbuscarProveedores.Name = "btnbuscarProveedores";
            this.btnbuscarProveedores.Size = new System.Drawing.Size(88, 28);
            this.btnbuscarProveedores.TabIndex = 18;
            this.btnbuscarProveedores.Text = "Buscar";
            this.btnbuscarProveedores.UseVisualStyleBackColor = true;
            this.btnbuscarProveedores.Click += new System.EventHandler(this.btnbuscarProveedores_Click);
            // 
            // btnlimpiarProveedores
            // 
            this.btnlimpiarProveedores.Location = new System.Drawing.Point(658, 63);
            this.btnlimpiarProveedores.Name = "btnlimpiarProveedores";
            this.btnlimpiarProveedores.Size = new System.Drawing.Size(88, 28);
            this.btnlimpiarProveedores.TabIndex = 19;
            this.btnlimpiarProveedores.Text = "Limpiar";
            this.btnlimpiarProveedores.UseVisualStyleBackColor = true;
            this.btnlimpiarProveedores.Click += new System.EventHandler(this.btnlimpiarProveedores_Click);
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpiarProveedores);
            this.Controls.Add(this.btnbuscarProveedores);
            this.Controls.Add(this.btneliminarProveedores);
            this.Controls.Add(this.btninsertarProveedores);
            this.Controls.Add(this.btnmostrarProveedores);
            this.Controls.Add(this.btnconectarProveedores);
            this.Controls.Add(this.btnRegresarProveedores);
            this.Controls.Add(this.txtboxCorreoProveedor);
            this.Controls.Add(this.txtboxTelefonoProveedor);
            this.Controls.Add(this.txtboxDireccionProveedor);
            this.Controls.Add(this.txtboxNombreProveedor);
            this.Controls.Add(this.txtboxIdProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTelefonoProveedor);
            this.Controls.Add(this.lblDireccionProveedor);
            this.Controls.Add(this.lblNombreProveedor);
            this.Controls.Add(this.lblIdProveedor);
            this.Controls.Add(this.dataGridViewProveedores);
            this.Name = "FrmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProveedores;
        private System.Windows.Forms.Label lblIdProveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.Label lblDireccionProveedor;
        private System.Windows.Forms.Label lblTelefonoProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxIdProveedor;
        private System.Windows.Forms.TextBox txtboxNombreProveedor;
        private System.Windows.Forms.TextBox txtboxDireccionProveedor;
        private System.Windows.Forms.TextBox txtboxTelefonoProveedor;
        private System.Windows.Forms.TextBox txtboxCorreoProveedor;
        private System.Windows.Forms.Button btnRegresarProveedores;
        private System.Windows.Forms.Button btnconectarProveedores;
        private System.Windows.Forms.Button btnmostrarProveedores;
        private System.Windows.Forms.Button btninsertarProveedores;
        private System.Windows.Forms.Button btneliminarProveedores;
        private System.Windows.Forms.Button btnbuscarProveedores;
        private System.Windows.Forms.Button btnlimpiarProveedores;
    }
}