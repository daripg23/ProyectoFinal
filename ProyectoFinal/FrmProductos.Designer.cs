namespace ProyectoFinal
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label5 = new Label();
            txtBuscar = new TextBox();
            dgvProductos = new DataGridView();
            label6 = new Label();
            cmbCategoria = new ComboBox();
            btnGuardar = new Button();
            label7 = new Label();
            errorProvider1 = new ErrorProvider(components);
            txtStock = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(385, 53);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3169414;
            pictureBox1.Location = new Point(47, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(140, 180);
            label3.Name = "label3";
            label3.Size = new Size(246, 31);
            label3.TabIndex = 4;
            label3.Text = "Nombre del Producto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(388, 183);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 27);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(140, 279);
            label4.Name = "label4";
            label4.Size = new Size(81, 31);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(388, 283);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(188, 27);
            txtPrecio.TabIndex = 7;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(128, 255, 128);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(639, 143);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(131, 47);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(639, 339);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 47);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(140, 370);
            label5.Name = "label5";
            label5.Size = new Size(196, 31);
            label5.TabIndex = 11;
            label5.Text = "Buscar Producto:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(336, 374);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(241, 27);
            txtBuscar.TabIndex = 12;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(140, 408);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(630, 188);
            dgvProductos.TabIndex = 13;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 17;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(388, 230);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(188, 28);
            cmbCategoria.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 255, 255);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(639, 246);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 47);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(140, 227);
            label7.Name = "label7";
            label7.Size = new Size(117, 31);
            label7.TabIndex = 20;
            label7.Text = "Categoria";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(388, 329);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(188, 27);
            txtStock.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(140, 325);
            label2.Name = "label2";
            label2.Size = new Size(148, 31);
            label2.TabIndex = 21;
            label2.Text = "Stock Actual";
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 195, 242);
            ClientSize = new Size(911, 609);
            Controls.Add(txtStock);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(btnGuardar);
            Controls.Add(cmbCategoria);
            Controls.Add(label6);
            Controls.Add(dgvProductos);
            Controls.Add(txtBuscar);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProductos";
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtCodigo;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtPrecio;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label5;
        private TextBox txtBuscar;
        private DataGridView dgvProductos;
        private Label label6;
        private ComboBox cmbCategoria;
        private Button btnGuardar;
        private Label label7;
        private ErrorProvider errorProvider1;
        private TextBox txtStock;
        private Label label2;
    }
}