namespace ProyectoFinal
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            menuPrincToolStripMenuItem = new ToolStripMenuItem();
            sALIRToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            categoríasToolStripMenuItem1 = new ToolStripMenuItem();
            clientesToolStripMenuItem1 = new ToolStripMenuItem();
            proveedoresToolStripMenuItem1 = new ToolStripMenuItem();
            usuariosToolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            label11 = new Label();
            panel10 = new Panel();
            labelFecha = new Label();
            label10 = new Label();
            label5 = new Label();
            label7 = new Label();
            panel7 = new Panel();
            pictureBox6 = new PictureBox();
            lblStockBajo = new Label();
            label9 = new Label();
            panel9 = new Panel();
            btnVerProveedores = new Button();
            dgvRecientes = new DataGridView();
            panel8 = new Panel();
            btnVerProductos = new Button();
            dgvStock = new DataGridView();
            panel6 = new Panel();
            pictureBox5 = new PictureBox();
            lblCategorias = new Label();
            label8 = new Label();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            lblProveedores = new Label();
            label6 = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            lblClientes = new Label();
            label4 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            lblProductos = new Label();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox7 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecientes).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, productosToolStripMenuItem, categoríasToolStripMenuItem1, clientesToolStripMenuItem1, proveedoresToolStripMenuItem1, usuariosToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1050, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuPrincToolStripMenuItem, sALIRToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(62, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // menuPrincToolStripMenuItem
            // 
            menuPrincToolStripMenuItem.Name = "menuPrincToolStripMenuItem";
            menuPrincToolStripMenuItem.Size = new Size(180, 22);
            menuPrincToolStripMenuItem.Text = "Ir a Menú Principal";
            menuPrincToolStripMenuItem.Click += menuPrincToolStripMenuItem_Click;
            // 
            // sALIRToolStripMenuItem
            // 
            sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            sALIRToolStripMenuItem.Size = new Size(180, 22);
            sALIRToolStripMenuItem.Text = "Salir";
            sALIRToolStripMenuItem.Click += sALIRToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(75, 20);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click_1;
            // 
            // categoríasToolStripMenuItem1
            // 
            categoríasToolStripMenuItem1.Name = "categoríasToolStripMenuItem1";
            categoríasToolStripMenuItem1.Size = new Size(77, 20);
            categoríasToolStripMenuItem1.Text = "Categorías";
            categoríasToolStripMenuItem1.Click += categoríasToolStripMenuItem1_Click;
            // 
            // clientesToolStripMenuItem1
            // 
            clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            clientesToolStripMenuItem1.Size = new Size(63, 20);
            clientesToolStripMenuItem1.Text = "Clientes";
            clientesToolStripMenuItem1.Click += clientesToolStripMenuItem1_Click;
            // 
            // proveedoresToolStripMenuItem1
            // 
            proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            proveedoresToolStripMenuItem1.Size = new Size(90, 20);
            proveedoresToolStripMenuItem1.Text = "Proveedores";
            proveedoresToolStripMenuItem1.Click += proveedoresToolStripMenuItem1_Click;
            // 
            // usuariosToolStripMenuItem1
            // 
            usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            usuariosToolStripMenuItem1.Size = new Size(66, 20);
            usuariosToolStripMenuItem1.Text = "Usuarios";
            usuariosToolStripMenuItem1.Click += usuariosToolStripMenuItem1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(labelFecha);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 689);
            panel1.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(23, 544);
            label11.Name = "label11";
            label11.Size = new Size(140, 15);
            label11.TabIndex = 18;
            label11.Text = "Productos por categoría";
            // 
            // panel10
            // 
            panel10.Location = new Point(11, 553);
            panel10.Name = "panel10";
            panel10.Size = new Size(1016, 124);
            panel10.TabIndex = 17;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFecha.ForeColor = Color.FromArgb(57, 127, 251);
            labelFecha.Location = new Point(131, 67);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(39, 15);
            labelFecha.TabIndex = 16;
            labelFecha.Text = "Fecha";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 67);
            label10.Name = "label10";
            label10.Size = new Size(105, 15);
            label10.TabIndex = 15;
            label10.Text = "Resumen del día - ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 209);
            label5.Name = "label5";
            label5.Size = new Size(148, 15);
            label5.TabIndex = 6;
            label5.Text = "Productos con Bajo Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(537, 209);
            label7.Name = "label7";
            label7.Size = new Size(236, 15);
            label7.TabIndex = 6;
            label7.Text = "Proveedores Registrados Recientemente";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(210, 226, 254);
            panel7.Controls.Add(pictureBox6);
            panel7.Controls.Add(lblStockBajo);
            panel7.Controls.Add(label9);
            panel7.Location = new Point(843, 101);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(194, 97);
            panel7.TabIndex = 14;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.etiqueta;
            pictureBox6.Location = new Point(3, 2);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // lblStockBajo
            // 
            lblStockBajo.AutoSize = true;
            lblStockBajo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockBajo.Location = new Point(80, 58);
            lblStockBajo.Name = "lblStockBajo";
            lblStockBajo.Size = new Size(35, 41);
            lblStockBajo.TabIndex = 11;
            lblStockBajo.Text = "0";
            lblStockBajo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 40);
            label9.Name = "label9";
            label9.Size = new Size(157, 20);
            label9.TabIndex = 12;
            label9.Text = "Productos Bajo Stock";
            // 
            // panel9
            // 
            panel9.Controls.Add(btnVerProveedores);
            panel9.Controls.Add(dgvRecientes);
            panel9.Location = new Point(527, 217);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(510, 310);
            panel9.TabIndex = 8;
            // 
            // btnVerProveedores
            // 
            btnVerProveedores.BackColor = Color.FromArgb(57, 127, 251);
            btnVerProveedores.FlatStyle = FlatStyle.Flat;
            btnVerProveedores.ForeColor = SystemColors.ControlLightLight;
            btnVerProveedores.Location = new Point(14, 272);
            btnVerProveedores.Name = "btnVerProveedores";
            btnVerProveedores.Size = new Size(154, 24);
            btnVerProveedores.TabIndex = 1;
            btnVerProveedores.Text = "Ver todos los proveedores";
            btnVerProveedores.UseVisualStyleBackColor = false;
            btnVerProveedores.Click += btnVerProveedores_Click;
            // 
            // dgvRecientes
            // 
            dgvRecientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecientes.Location = new Point(10, 11);
            dgvRecientes.Margin = new Padding(3, 2, 3, 2);
            dgvRecientes.Name = "dgvRecientes";
            dgvRecientes.RowHeadersWidth = 51;
            dgvRecientes.Size = new Size(491, 251);
            dgvRecientes.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnVerProductos);
            panel8.Controls.Add(dgvStock);
            panel8.Location = new Point(9, 217);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(510, 310);
            panel8.TabIndex = 7;
            // 
            // btnVerProductos
            // 
            btnVerProductos.BackColor = Color.FromArgb(57, 127, 251);
            btnVerProductos.FlatStyle = FlatStyle.Flat;
            btnVerProductos.ForeColor = SystemColors.ControlLightLight;
            btnVerProductos.Location = new Point(14, 272);
            btnVerProductos.Name = "btnVerProductos";
            btnVerProductos.Size = new Size(160, 24);
            btnVerProductos.TabIndex = 1;
            btnVerProductos.Text = "Ver todos los productos";
            btnVerProductos.UseVisualStyleBackColor = false;
            btnVerProductos.Click += btnVerProductos_Click;
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(10, 10);
            dgvStock.Margin = new Padding(3, 2, 3, 2);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 51;
            dgvStock.Size = new Size(489, 252);
            dgvStock.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(118, 167, 252);
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(lblCategorias);
            panel6.Controls.Add(label8);
            panel6.Location = new Point(635, 101);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(194, 97);
            panel6.TabIndex = 4;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.etiqueta;
            pictureBox5.Location = new Point(3, 4);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategorias.Location = new Point(80, 58);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(35, 41);
            lblCategorias.TabIndex = 11;
            lblCategorias.Text = "0";
            lblCategorias.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 40);
            label8.Name = "label8";
            label8.Size = new Size(149, 20);
            label8.TabIndex = 12;
            label8.Text = "Cantidad Categorias";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(10, 49, 86);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(lblProveedores);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(427, 101);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(194, 97);
            panel5.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.enviado;
            pictureBox4.Location = new Point(6, 4);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // lblProveedores
            // 
            lblProveedores.AutoSize = true;
            lblProveedores.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProveedores.ForeColor = SystemColors.ControlLightLight;
            lblProveedores.Location = new Point(80, 58);
            lblProveedores.Name = "lblProveedores";
            lblProveedores.Size = new Size(35, 41);
            lblProveedores.TabIndex = 9;
            lblProveedores.Text = "0";
            lblProveedores.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(10, 39);
            label6.Name = "label6";
            label6.Size = new Size(162, 20);
            label6.TabIndex = 10;
            label6.Text = "Cantidad Proveedores";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(38, 96, 185);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(lblClientes);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(217, 101);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(194, 97);
            panel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.equipo;
            pictureBox2.Location = new Point(4, 4);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientes.ForeColor = SystemColors.ControlLightLight;
            lblClientes.Location = new Point(82, 58);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(35, 41);
            lblClientes.TabIndex = 7;
            lblClientes.Text = "0";
            lblClientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(28, 39);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 8;
            label4.Text = "Cantidad Clientes";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(57, 127, 251);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(lblProductos);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(9, 101);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(194, 97);
            panel3.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.caja_negra;
            pictureBox3.Location = new Point(3, 2);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductos.Location = new Point(74, 58);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(35, 41);
            lblProductos.TabIndex = 6;
            lblProductos.Text = "0";
            lblProductos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 40);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 6;
            label2.Text = "Cantidad Productos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1056, 49);
            panel2.TabIndex = 1;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(994, 4);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(38, 38);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(968, 17);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 7;
            label3.Text = "Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 4);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 4);
            label1.Name = "label1";
            label1.Size = new Size(171, 41);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 178, 217);
            ClientSize = new Size(1050, 713);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel Principal";
            Load += FrmDashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecientes).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem sALIRToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label lblCategorias;
        private Label label8;
        private Label lblProveedores;
        private Label label6;
        private Label lblClientes;
        private Label label4;
        private Label lblProductos;
        private Label label2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel9;
        private Label label7;
        private Panel panel7;
        private PictureBox pictureBox6;
        private Label lblStockBajo;
        private Label label9;
        private Label label5;
        private Panel panel8;
        private DataGridView dgvStock;
        private ToolStripMenuItem menuPrincToolStripMenuItem;
        private Label label3;
        private PictureBox pictureBox7;
        private DataGridView dgvRecientes;
        private Label labelFecha;
        private Label label10;
        private Panel panel10;
        private Label label11;
        private Button btnVerProveedores;
        private Button btnVerProductos;
        private NotifyIcon notifyIcon1;
        private ToolStripMenuItem categoríasToolStripMenuItem1;
        private ToolStripMenuItem clientesToolStripMenuItem1;
        private ToolStripMenuItem proveedoresToolStripMenuItem1;
        private ToolStripMenuItem usuariosToolStripMenuItem1;
    }
}