namespace ProyectoFinal
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
            components = new System.ComponentModel.Container();
            dgvProveedores = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            panel1 = new Panel();
            txtContacto = new TextBox();
            label11 = new Label();
            txtProductos = new TextBox();
            labelCorreo = new Label();
            labelTelefono = new Label();
            label10 = new Label();
            txtDireccion = new TextBox();
            label9 = new Label();
            label8 = new Label();
            btnLimpiar = new Button();
            label7 = new Label();
            txtCorreo = new TextBox();
            label = new Label();
            txtID = new TextBox();
            label2 = new Label();
            btnEliminar = new Button();
            txtNombreProveedor = new TextBox();
            btnGuardar = new Button();
            label3 = new Label();
            btnActualizar = new Button();
            label4 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            btnExportar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            labelTotProveedores = new Label();
            label5 = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(11, 57);
            dgvProveedores.Margin = new Padding(3, 2, 3, 2);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(609, 182);
            dgvProveedores.TabIndex = 15;
            dgvProveedores.CellClick += dgvProveedores_CellClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 32);
            label1.Name = "label1";
            label1.Size = new Size(134, 17);
            label1.TabIndex = 21;
            label1.Text = "Datos del Proveedor";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtContacto);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtProductos);
            panel1.Controls.Add(labelCorreo);
            panel1.Controls.Add(labelTelefono);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(txtNombreProveedor);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTelefono);
            panel1.Location = new Point(8, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 517);
            panel1.TabIndex = 20;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(15, 167);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(348, 23);
            txtContacto.TabIndex = 31;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(15, 420);
            label11.Name = "label11";
            label11.Size = new Size(159, 17);
            label11.TabIndex = 29;
            label11.Text = "Productos que suministra:";
            // 
            // txtProductos
            // 
            txtProductos.Location = new Point(13, 442);
            txtProductos.Margin = new Padding(3, 2, 3, 2);
            txtProductos.Name = "txtProductos";
            txtProductos.Size = new Size(350, 23);
            txtProductos.TabIndex = 30;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(19, 337);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(44, 15);
            labelCorreo.TabIndex = 28;
            labelCorreo.Text = "label12";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(19, 258);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(44, 15);
            labelTelefono.TabIndex = 27;
            labelTelefono.Text = "label11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(18, 363);
            label10.Name = "label10";
            label10.Size = new Size(65, 17);
            label10.TabIndex = 25;
            label10.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(16, 386);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(347, 23);
            txtDireccion.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(154, 295);
            label9.Name = "label9";
            label9.Size = new Size(105, 15);
            label9.TabIndex = 24;
            label9.Text = "(debe contener @)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(95, 210);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 23;
            label8.Text = "formato (XXXX-XXXX)";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Goldenrod;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ButtonFace;
            btnLimpiar.Location = new Point(287, 479);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 27);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 292);
            label7.Name = "label7";
            label7.Size = new Size(129, 17);
            label7.TabIndex = 14;
            label7.Text = "Correo Electrónico: *";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(13, 310);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(350, 23);
            txtCorreo.TabIndex = 15;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Location = new Point(17, 143);
            label.Name = "label";
            label.Size = new Size(132, 17);
            label.TabIndex = 12;
            label.Text = "Contacto (persona): *";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(15, 40);
            txtID.Name = "txtID";
            txtID.Size = new Size(348, 23);
            txtID.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(10, 49, 86);
            label2.Location = new Point(15, 16);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 9;
            label2.Text = "ID Proveedor:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(213, 22, 22);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(200, 479);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 27);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(13, 101);
            txtNombreProveedor.Margin = new Padding(3, 2, 3, 2);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(350, 23);
            txtNombreProveedor.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(25, 165, 53);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(16, 479);
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
            label3.Location = new Point(13, 78);
            label3.Name = "label3";
            label3.Size = new Size(133, 17);
            label3.TabIndex = 5;
            label3.Text = "Nombre / Empresa: *";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(57, 127, 251);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.ControlLightLight;
            btnActualizar.Location = new Point(103, 479);
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
            label4.Location = new Point(15, 208);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 7;
            label4.Text = "Telefono: *";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(13, 232);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(350, 23);
            txtTelefono.TabIndex = 8;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(423, 32);
            label6.Name = "label6";
            label6.Size = new Size(152, 17);
            label6.TabIndex = 23;
            label6.Text = "Listado de Proveedores";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExportar);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(labelTotProveedores);
            panel2.Controls.Add(dgvProveedores);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(409, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(623, 294);
            panel2.TabIndex = 22;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(57, 127, 251);
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = SystemColors.ControlLightLight;
            btnExportar.Location = new Point(491, 254);
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
            btnBuscar.Location = new Point(545, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 27);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(505, 23);
            txtBuscar.TabIndex = 17;
            // 
            // labelTotProveedores
            // 
            labelTotProveedores.AutoSize = true;
            labelTotProveedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTotProveedores.ForeColor = Color.FromArgb(57, 127, 251);
            labelTotProveedores.Location = new Point(51, 261);
            labelTotProveedores.Name = "labelTotProveedores";
            labelTotProveedores.Size = new Size(14, 15);
            labelTotProveedores.TabIndex = 16;
            labelTotProveedores.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(57, 127, 251);
            label5.Location = new Point(13, 261);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 15;
            label5.Text = "Total:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(57, 127, 251);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 566);
            panel3.Name = "panel3";
            panel3.Size = new Size(1044, 86);
            panel3.TabIndex = 24;
            // 
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1044, 652);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmProveedores";
            Text = "FrmProveedores";
            Load += FrmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvProveedores;
        private ErrorProvider errorProvider1;
        private Label label1;
        private Panel panel1;
        private Button btnLimpiar;
        private Label label7;
        private TextBox txtCorreo;
        private Label label;
        private TextBox txtID;
        private Label label2;
        private Button btnEliminar;
        private TextBox txtNombreProveedor;
        private Button btnGuardar;
        private Label label3;
        private Button btnActualizar;
        private Label label4;
        private TextBox txtTelefono;
        private Label label6;
        private Panel panel2;
        private Button btnExportar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label labelTotProveedores;
        private Label label5;
        private Label label10;
        private TextBox txtDireccion;
        private Label label9;
        private Label label8;
        private Label label11;
        private TextBox txtProductos;
        private Label labelCorreo;
        private Label labelTelefono;
        private TextBox txtContacto;
        private Panel panel3;
    }
}