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
            label3 = new Label();
            txtNombreCategoria = new TextBox();
            label4 = new Label();
            txtDescripcionCat = new TextBox();
            btnActualizar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            dgvCategorias = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            btnLimpiar = new Button();
            txtID = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            btnExportar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            labelTotCategorias = new Label();
            label5 = new Label();
            label1 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 87);
            label3.Name = "label3";
            label3.Size = new Size(163, 17);
            label3.TabIndex = 5;
            label3.Text = "Nombre de la Categoría: *";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(13, 115);
            txtNombreCategoria.Margin = new Padding(3, 2, 3, 2);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(412, 23);
            txtNombreCategoria.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 166);
            label4.Name = "label4";
            label4.Size = new Size(141, 17);
            label4.TabIndex = 7;
            label4.Text = "Descripción (opcional):";
            // 
            // txtDescripcionCat
            // 
            txtDescripcionCat.Location = new Point(13, 191);
            txtDescripcionCat.Margin = new Padding(3, 2, 3, 2);
            txtDescripcionCat.Name = "txtDescripcionCat";
            txtDescripcionCat.Size = new Size(412, 23);
            txtDescripcionCat.TabIndex = 8;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(57, 127, 251);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.ControlLightLight;
            btnActualizar.Location = new Point(123, 246);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(85, 27);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(25, 165, 53);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(15, 246);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 27);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(213, 22, 22);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(241, 246);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 27);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(13, 52);
            dgvCategorias.Margin = new Padding(3, 2, 3, 2);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(485, 186);
            dgvCategorias.TabIndex = 14;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(txtNombreCategoria);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDescripcionCat);
            panel1.Location = new Point(33, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 294);
            panel1.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Goldenrod;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ButtonFace;
            btnLimpiar.Location = new Point(349, 246);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 27);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(15, 40);
            txtID.Name = "txtID";
            txtID.Size = new Size(410, 23);
            txtID.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 15);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 9;
            label2.Text = "ID Categoría:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExportar);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(labelTotCategorias);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dgvCategorias);
            panel2.Location = new Point(507, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 294);
            panel2.TabIndex = 16;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(57, 127, 251);
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = SystemColors.ControlLightLight;
            btnExportar.Location = new Point(369, 244);
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
            btnBuscar.Location = new Point(423, 16);
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
            txtBuscar.Size = new Size(376, 23);
            txtBuscar.TabIndex = 17;
            // 
            // labelTotCategorias
            // 
            labelTotCategorias.AutoSize = true;
            labelTotCategorias.Location = new Point(54, 256);
            labelTotCategorias.Name = "labelTotCategorias";
            labelTotCategorias.Size = new Size(13, 15);
            labelTotCategorias.TabIndex = 16;
            labelTotCategorias.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 256);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 15;
            label5.Text = "Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 31);
            label1.Name = "label1";
            label1.Size = new Size(141, 17);
            label1.TabIndex = 17;
            label1.Text = "Datos de la Categoría";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(523, 31);
            label6.Name = "label6";
            label6.Size = new Size(141, 17);
            label6.TabIndex = 18;
            label6.Text = "Listado de Categorías";
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1044, 461);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            Load += FrmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox txtNombreCategoria;
        private Label label4;
        private TextBox txtDescripcionCat;
        private Button btnActualizar;
        private Button btnGuardar;
        private Button btnEliminar;
        private DataGridView dgvCategorias;
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private TextBox txtID;
        private Label label2;
        private Panel panel2;
        private Label labelTotCategorias;
        private Label label5;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnExportar;
        private Label label1;
        private Label label6;
        private Button btnLimpiar;
    }
}