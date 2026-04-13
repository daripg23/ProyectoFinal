namespace ProyectoFinal
{
    partial class FrmClientes
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
            dgvClientes = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            btnLimpiar = new Button();
            labelCorreo = new Label();
            label7 = new Label();
            labelTelefono = new Label();
            label6 = new Label();
            label5 = new Label();
            txtDireccion = new TextBox();
            label1 = new Label();
            txtCorreo = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            btnEliminar = new Button();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            label3 = new Label();
            btnActualizar = new Button();
            label4 = new Label();
            txtTelefono = new TextBox();
            panel2 = new Panel();
            btnExportar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            labelTotClientes = new Label();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(14, 55);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(546, 186);
            dgvClientes.TabIndex = 14;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(labelCorreo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(labelTelefono);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTelefono);
            panel1.Location = new Point(33, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 424);
            panel1.TabIndex = 16;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Goldenrod;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ButtonFace;
            btnLimpiar.Location = new Point(299, 381);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 27);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(15, 286);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(38, 15);
            labelCorreo.TabIndex = 19;
            labelCorreo.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(139, 236);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 18;
            label7.Text = "(debe contener @)";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(16, 206);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(38, 15);
            labelTelefono.TabIndex = 17;
            labelTelefono.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(89, 159);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 16;
            label6.Text = "(formato: XXXX-XXXX)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 314);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 14;
            label5.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(13, 339);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(375, 23);
            txtDireccion.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 234);
            label1.Name = "label1";
            label1.Size = new Size(120, 17);
            label1.TabIndex = 12;
            label1.Text = "Correo electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(13, 260);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(375, 23);
            txtCorreo.TabIndex = 13;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(15, 48);
            txtID.Name = "txtID";
            txtID.Size = new Size(373, 23);
            txtID.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 23);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 9;
            label2.Text = "ID Cliente:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(213, 22, 22);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(206, 381);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 27);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(13, 115);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(375, 23);
            txtNombre.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(25, 165, 53);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(16, 381);
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
            label3.Location = new Point(13, 87);
            label3.Name = "label3";
            label3.Size = new Size(130, 17);
            label3.TabIndex = 5;
            label3.Text = "Nombre Completo: *";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(57, 127, 251);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.ControlLightLight;
            btnActualizar.Location = new Point(106, 381);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(85, 27);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 157);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 7;
            label4.Text = "Teléfono: *";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(13, 181);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(375, 23);
            txtTelefono.TabIndex = 8;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExportar);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(dgvClientes);
            panel2.Controls.Add(labelTotClientes);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(449, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(571, 424);
            panel2.TabIndex = 17;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(57, 127, 251);
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = SystemColors.ControlLightLight;
            btnExportar.Location = new Point(432, 251);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(129, 27);
            btnExportar.TabIndex = 19;
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
            btnBuscar.Location = new Point(485, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 27);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(14, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(394, 23);
            txtBuscar.TabIndex = 17;
            // 
            // labelTotClientes
            // 
            labelTotClientes.AutoSize = true;
            labelTotClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTotClientes.ForeColor = Color.FromArgb(57, 127, 251);
            labelTotClientes.Location = new Point(55, 256);
            labelTotClientes.Name = "labelTotClientes";
            labelTotClientes.Size = new Size(14, 15);
            labelTotClientes.TabIndex = 16;
            labelTotClientes.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(57, 127, 251);
            label9.Location = new Point(14, 256);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 15;
            label9.Text = "Total:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(45, 32);
            label10.Name = "label10";
            label10.Size = new Size(114, 17);
            label10.TabIndex = 18;
            label10.Text = "Datos del Cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(463, 32);
            label8.Name = "label8";
            label8.Size = new Size(125, 17);
            label8.TabIndex = 19;
            label8.Text = "Listado de Clientes";
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1044, 461);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmClientes";
            Text = "Clientes";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvClientes;
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private Label label5;
        private TextBox txtDireccion;
        private Label label1;
        private TextBox txtCorreo;
        private TextBox txtID;
        private Label label2;
        private Button btnEliminar;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Label label3;
        private Button btnActualizar;
        private Label label4;
        private TextBox txtTelefono;
        private Label label6;
        private Label labelCorreo;
        private Label label7;
        private Label labelTelefono;
        private Panel panel2;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label labelTotClientes;
        private Label label9;
        private Label label10;
        private Button btnExportar;
        private Label label8;
        private Button btnLimpiar;
    }
}