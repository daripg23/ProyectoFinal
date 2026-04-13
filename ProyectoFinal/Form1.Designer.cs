namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnIngresar = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            label4 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            checkBoxMostrar = new CheckBox();
            label5 = new Label();
            btnRegistrate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 163);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(60, 187);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(247, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(60, 243);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(247, 23);
            txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 219);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(57, 127, 251);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = SystemColors.ControlLightLight;
            btnIngresar.Location = new Point(58, 309);
            btnIngresar.Margin = new Padding(3, 2, 3, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(250, 28);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Iniciar Sesión";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(57, 127, 251);
            label3.Location = new Point(87, 29);
            label3.Name = "label3";
            label3.Size = new Size(85, 34);
            label3.TabIndex = 6;
            label3.Text = "Soluciones \r\ntecnológicas";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(63, 92);
            label4.Name = "label4";
            label4.Size = new Size(230, 25);
            label4.TabIndex = 7;
            label4.Text = "¡Te damos la bienvenida!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 127, 251);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(363, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 410);
            panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(318, 276);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // checkBoxMostrar
            // 
            checkBoxMostrar.AutoSize = true;
            checkBoxMostrar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxMostrar.Location = new Point(181, 276);
            checkBoxMostrar.Name = "checkBoxMostrar";
            checkBoxMostrar.Size = new Size(126, 17);
            checkBoxMostrar.TabIndex = 9;
            checkBoxMostrar.Text = "Mostrar contraseña";
            checkBoxMostrar.UseVisualStyleBackColor = true;
            checkBoxMostrar.CheckedChanged += checkBoxMostrar_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(95, 127);
            label5.Name = "label5";
            label5.Size = new Size(166, 15);
            label5.TabIndex = 10;
            label5.Text = "Sistema de Inventario y Ventas";
            // 
            // btnRegistrate
            // 
            btnRegistrate.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnRegistrate.Location = new Point(58, 350);
            btnRegistrate.Name = "btnRegistrate";
            btnRegistrate.Size = new Size(75, 25);
            btnRegistrate.TabIndex = 11;
            btnRegistrate.Text = "Regístrate";
            btnRegistrate.UseVisualStyleBackColor = true;
            btnRegistrate.Click += btnRegistrate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(684, 410);
            Controls.Add(btnRegistrate);
            Controls.Add(label5);
            Controls.Add(checkBoxMostrar);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Label label2;
        private Button btnIngresar;
        private PictureBox pictureBox1;
        private Label label3;
        private ErrorProvider errorProvider1;
        private Label label4;
        private Panel panel1;
        private CheckBox checkBoxMostrar;
        private Label label5;
        private Button btnRegistrate;
        private PictureBox pictureBox2;
    }
}
