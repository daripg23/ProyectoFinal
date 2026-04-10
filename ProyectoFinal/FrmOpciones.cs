using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmOpciones : Form
    {
        public FrmOpciones()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard dash = new FrmDashboard();
            dash.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregar agr = new FrmAgregar();
            agr.Show();
            this.Hide();
        }

        private void FrmOpciones_Load(object sender, EventArgs e)
        {

        }
    }
}
