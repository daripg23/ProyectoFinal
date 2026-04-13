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
            dgvProductos = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            panel1 = new Panel();
            btnLimpiar = new Button();
            labelStock = new Label();
            label7 = new Label();
            txtStock = new TextBox();
            cmbCategoria = new ComboBox();
            label = new Label();
            txtID = new TextBox();
            label2 = new Label();
            btnEliminar = new Button();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            label3 = new Label();
            btnActualizar = new Button();
            label4 = new Label();
            txtPrecio = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            cmbFiltroCategoria = new ComboBox();
            label8 = new Label();
            btnExportar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            labelTotProductos = new Label();
            label5 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(5, 53);
            dgvProductos.Margin = new Padding(3, 2, 3, 2);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(587, 192);
            dgvProductos.TabIndex = 13;
            dgvProductos.CellClick += dgvProductos_CellClick;
            dgvProductos.DataBindingComplete += dgvProductos_DataBindingComplete;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 32);
            label1.Name = "label1";
            label1.Size = new Size(127, 17);
            label1.TabIndex = 19;
            label1.Text = "Datos del Producto";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(labelStock);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(label);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPrecio);
            panel1.Location = new Point(20, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 431);
            panel1.TabIndex = 18;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Goldenrod;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ButtonFace;
            btnLimpiar.Location = new Point(304, 392);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 27);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.BackColor = Color.PeachPuff;
            labelStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStock.ForeColor = Color.Red;
            labelStock.Location = new Point(17, 344);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(45, 17);
            labelStock.TabIndex = 16;
            labelStock.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 278);
            label7.Name = "label7";
            label7.Size = new Size(90, 17);
            label7.TabIndex = 14;
            label7.Text = "Stock Actual: *";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(13, 300);
            txtStock.Margin = new Padding(3, 2, 3, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(367, 23);
            txtStock.TabIndex = 15;
            txtStock.TextChanged += txtStock_TextChanged;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(13, 170);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(367, 23);
            cmbCategoria.TabIndex = 13;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Location = new Point(17, 141);
            label.Name = "label";
            label.Size = new Size(77, 17);
            label.TabIndex = 12;
            label.Text = "Categoría: *";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(15, 40);
            txtID.Name = "txtID";
            txtID.Size = new Size(365, 23);
            txtID.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(10, 49, 86);
            label2.Location = new Point(15, 15);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 9;
            label2.Text = "ID Producto:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(213, 22, 22);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(211, 392);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 27);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(13, 105);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(367, 23);
            txtNombre.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(25, 165, 53);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(15, 392);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 27);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 75);
            label3.Name = "label3";
            label3.Size = new Size(148, 17);
            label3.TabIndex = 5;
            label3.Text = "Nombre del Producto: *";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(57, 127, 251);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.ControlLightLight;
            btnActualizar.Location = new Point(108, 392);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(85, 27);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 209);
            label4.Name = "label4";
            label4.Size = new Size(111, 17);
            label4.TabIndex = 7;
            label4.Text = "Precio de Venta: *";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(13, 235);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(367, 23);
            txtPrecio.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(434, 30);
            label6.Name = "label6";
            label6.Size = new Size(138, 17);
            label6.TabIndex = 21;
            label6.Text = "Listado de Productos";
            // 
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Controls.Add(cmbFiltroCategoria);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnExportar);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(labelTotProductos);
            panel2.Controls.Add(dgvProductos);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(418, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 294);
            panel2.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(310, 261);
            label9.Name = "label9";
            label9.Size = new Size(136, 15);
            label9.TabIndex = 23;
            label9.Text = "Rojo: stock < 5 unidades";
            // 
            // cmbFiltroCategoria
            // 
            cmbFiltroCategoria.FormattingEnabled = true;
            cmbFiltroCategoria.Location = new Point(338, 16);
            cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            cmbFiltroCategoria.Size = new Size(173, 23);
            cmbFiltroCategoria.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(0, 192, 0);
            label8.Location = new Point(190, 261);
            label8.Name = "label8";
            label8.Size = new Size(114, 15);
            label8.TabIndex = 21;
            label8.Text = "Verde: stock normal ";
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(57, 127, 251);
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = SystemColors.ControlLightLight;
            btnExportar.Location = new Point(463, 254);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(129, 27);
            btnExportar.TabIndex = 20;
            btnExportar.Text = "Exportar a Excel";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(57, 127, 251);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(517, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 27);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(6, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(326, 23);
            txtBuscar.TabIndex = 17;
            // 
            // labelTotProductos
            // 
            labelTotProductos.AutoSize = true;
            labelTotProductos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTotProductos.ForeColor = Color.FromArgb(57, 127, 251);
            labelTotProductos.Location = new Point(41, 261);
            labelTotProductos.Name = "labelTotProductos";
            labelTotProductos.Size = new Size(14, 15);
            labelTotProductos.TabIndex = 16;
            labelTotProductos.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(57, 127, 251);
            label5.Location = new Point(5, 261);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 15;
            label5.Text = "Total:";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(57, 127, 251);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 482);
            panel3.Name = "panel3";
            panel3.Size = new Size(1044, 86);
            panel3.TabIndex = 22;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1044, 568);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmProductos";
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCodigo;
        private DataGridView dgvProductos;
        private ErrorProvider errorProvider1;
        private Label label1;
        private Panel panel1;
        private TextBox txtID;
        private Label label2;
        private Button btnEliminar;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Label label3;
        private Button btnActualizar;
        private Label label4;
        private TextBox txtPrecio;
        private Label label6;
        private Panel panel2;
        private Button btnExportar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label labelTotProductos;
        private Label label5;
        private Label label;
        private ComboBox cmbCategoria;
        private Label label7;
        private TextBox txtStock;
        private Label labelStock;
        private Button btnLimpiar;
        private Label label8;
        private NotifyIcon notifyIcon1;
        private ComboBox cmbFiltroCategoria;
        private Label label9;
        private Panel panel3;
    }
}