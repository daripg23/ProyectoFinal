namespace ProyectoFinal
{
    partial class FrmCategoria
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
            txtNombreCategoria = new TextBox();
            label4 = new Label();
            txtDescripcionCat = new TextBox();
            btnActualizar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            dgvCategorias = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_clipart_computer_icons_icon_design_information_computer_software_category_management_text_trademark;
            pictureBox1.Location = new Point(30, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 47);
            label1.Name = "label1";
            label1.Size = new Size(127, 31);
            label1.TabIndex = 1;
            label1.Text = "Categorias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 217);
            label3.Name = "label3";
            label3.Size = new Size(268, 31);
            label3.TabIndex = 5;
            label3.Text = "Nombre de la Categoria";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(378, 223);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(188, 27);
            txtNombreCategoria.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(187, 267);
            label4.Name = "label4";
            label4.Size = new Size(140, 31);
            label4.TabIndex = 7;
            label4.Text = "Descripcion";
            // 
            // txtDescripcionCat
            // 
            txtDescripcionCat.Location = new Point(378, 273);
            txtDescripcionCat.Name = "txtDescripcionCat";
            txtDescripcionCat.Size = new Size(188, 27);
            txtDescripcionCat.TabIndex = 8;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(128, 255, 128);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(615, 168);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(131, 47);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 255, 255);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(615, 239);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 47);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(615, 318);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 47);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(97, 371);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(630, 188);
            dgvCategorias.TabIndex = 14;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 195, 242);
            ClientSize = new Size(800, 565);
            Controls.Add(dgvCategorias);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnActualizar);
            Controls.Add(txtDescripcionCat);
            Controls.Add(label4);
            Controls.Add(txtNombreCategoria);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            Load += FrmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private TextBox txtNombreCategoria;
        private Label label4;
        private TextBox txtDescripcionCat;
        private Button btnActualizar;
        private Button btnGuardar;
        private Button btnEliminar;
        private DataGridView dgvCategorias;
        private ErrorProvider errorProvider1;
    }
}