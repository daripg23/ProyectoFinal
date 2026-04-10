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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            txtNombreProveedor = new TextBox();
            label4 = new Label();
            txtRTN = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            TxtCorreo = new TextBox();
            dgvProveedores = new DataGridView();
            btnActualizar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._11671524;
            pictureBox1.Location = new Point(40, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 64);
            label1.Name = "label1";
            label1.Size = new Size(146, 31);
            label1.TabIndex = 1;
            label1.Text = "Proveedores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 240);
            label3.Name = "label3";
            label3.Size = new Size(257, 31);
            label3.TabIndex = 6;
            label3.Text = "Nombre del Proveedor";
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(378, 246);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(188, 27);
            txtNombreProveedor.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(217, 289);
            label4.Name = "label4";
            label4.Size = new Size(60, 31);
            label4.TabIndex = 8;
            label4.Text = "RTN";
            // 
            // txtRTN
            // 
            txtRTN.Location = new Point(378, 295);
            txtRTN.Name = "txtRTN";
            txtRTN.Size = new Size(188, 27);
            txtRTN.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(188, 338);
            label5.Name = "label5";
            label5.Size = new Size(107, 31);
            label5.TabIndex = 10;
            label5.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(378, 344);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(188, 27);
            txtTelefono.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(188, 391);
            label6.Name = "label6";
            label6.Size = new Size(86, 31);
            label6.TabIndex = 12;
            label6.Text = "Correo";
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(378, 397);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(188, 27);
            TxtCorreo.TabIndex = 13;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(43, 430);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(702, 188);
            dgvProveedores.TabIndex = 15;
            dgvProveedores.CellClick += dgvProveedores_CellClick;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(128, 255, 128);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(614, 188);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(131, 47);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 255, 255);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(614, 273);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 47);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(614, 375);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 47);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 195, 242);
            ClientSize = new Size(800, 623);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvProveedores);
            Controls.Add(TxtCorreo);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtRTN);
            Controls.Add(label4);
            Controls.Add(txtNombreProveedor);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProveedores";
            Text = "FrmProveedores";
            Load += FrmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private TextBox txtNombreProveedor;
        private Label label4;
        private TextBox txtRTN;
        private Label label5;
        private TextBox txtTelefono;
        private Label label6;
        private TextBox TxtCorreo;
        private DataGridView dgvProveedores;
        private Button btnActualizar;
        private Button btnGuardar;
        private Button btnEliminar;
        private ErrorProvider errorProvider1;
    }
}