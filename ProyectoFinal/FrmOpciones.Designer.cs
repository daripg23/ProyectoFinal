namespace ProyectoFinal
{
    partial class FrmOpciones
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
            btnAgregar = new Button();
            btnDashboard = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 54);
            label1.Name = "label1";
            label1.Size = new Size(204, 31);
            label1.TabIndex = 0;
            label1.Text = "¿Que desea hacer?";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(35, 136);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 51);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Usuario";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(215, 136);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(140, 51);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard Principal";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // FrmOpciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 287);
            Controls.Add(btnDashboard);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Name = "FrmOpciones";
            Text = "FrmOpciones";
            Load += FrmOpciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregar;
        private Button btnDashboard;
    }
}