using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoFinal
{
    public partial class FrmDashboard : Form
    {
        string conexion = "server=localhost;database=inventario;uid=root;pwd=0819200500178";
        List<Control> controlesDashboard = new List<Control>();
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos prod = new FrmProductos();
            prod.TopLevel = false;
            prod.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(prod);
            prod.Show();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria cat = new FrmCategoria();
            cat.TopLevel = false;
            cat.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(cat);
            cat.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores prov = new FrmProveedores();
            prov.TopLevel = false;
            prov.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(prov);
            prov.Show();
        }

        private void dashboardPrincToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            foreach (Control c in controlesDashboard)
            {
                panel1.Controls.Add(c);
            }

            CargarDatos();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            CargarDatos();
            foreach (Control c in panel1.Controls)
            {
                controlesDashboard.Add(c);
            }
        }

        private void CargarDatos()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    // Productos (SUM)
                    MySqlCommand cmd1 = new MySqlCommand("SELECT IFNULL(SUM(stock),0) FROM productos", conn);
                    lblProductos.Text = cmd1.ExecuteScalar().ToString();

                    // Clientes
                    //MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) FROM clientes", conn);
                    //lblClientes.Text = cmd2.ExecuteScalar().ToString();

                    // Proveedores
                    MySqlCommand cmd3 = new MySqlCommand("SELECT COUNT(*) FROM proveedores", conn);
                    lblProveedores.Text = cmd3.ExecuteScalar().ToString();

                    // Categorías
                    MySqlCommand cmd4 = new MySqlCommand("SELECT COUNT(*) FROM categorias", conn);
                    lblCategorias.Text = cmd4.ExecuteScalar().ToString();

                    // Stock bajo
                    MySqlCommand cmd5 = new MySqlCommand("SELECT COUNT(*) FROM productos WHERE stock <= 5", conn);
                    lblStockBajo.Text = cmd5.ExecuteScalar().ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error en la carga de datos: " + ex.Message);
                }
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregar agr = new FrmAgregar();
            agr.TopLevel = false;
            agr.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(agr);
            agr.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
