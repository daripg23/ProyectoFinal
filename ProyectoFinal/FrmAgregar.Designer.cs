namespace ProyectoFinal
{
    partial class FrmAgregar
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
            txtPassword = new TextBox();
            label2 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            txtPassword2 = new TextBox();
            label4 = new Label();
            btnRegistrar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 27);
            label1.Name = "label1";
            label1.Size = new Size(228, 31);
            label1.TabIndex = 0;
            label1.Text = "Adicion de Usuarios";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(83, 175);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 152);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 6;
            label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(83, 107);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 27);
            txtUsuario.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 84);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 4;
            label3.Text = "Usuario:";
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(83, 246);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(250, 27);
            txtPassword2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 223);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 8;
            label4.Text = "Repetir Contraseña:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(325, 307);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 348);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPassword2);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAgregar";
            Text = "FrmAgregar";
            Load += FrmAgregar_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private TextBox txtPassword2;
        private Label label4;
        private Button btnRegistrar;
        private ErrorProvider errorProvider1;
    }
}