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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtRTN = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 32);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.nueva_cuenta;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 134);
            label2.Name = "label2";
            label2.Size = new Size(196, 28);
            label2.TabIndex = 2;
            label2.Text = "Nombre del Cliente";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(332, 134);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 27);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(130, 192);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 4;
            label3.Text = "RTN";
            // 
            // txtRTN
            // 
            txtRTN.Location = new Point(332, 192);
            txtRTN.Name = "txtRTN";
            txtRTN.Size = new Size(204, 27);
            txtRTN.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(130, 246);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 6;
            label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(332, 246);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(204, 27);
            txtTelefono.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(130, 299);
            label5.Name = "label5";
            label5.Size = new Size(0, 28);
            label5.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 255, 128);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(130, 302);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 47);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(332, 302);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 47);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 355);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(630, 188);
            dgvClientes.TabIndex = 14;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 195, 242);
            ClientSize = new Size(645, 564);
            Controls.Add(dgvClientes);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtRTN);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "FrmClientes";
            Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtRTN;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private Button btnGuardar;
        private Button btnEliminar;
        private DataGridView dgvClientes;
    }
}