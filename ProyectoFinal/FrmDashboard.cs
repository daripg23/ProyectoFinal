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
        string conexion = "server=localhost;database=proyectofinal;uid=root;pwd=1234";
        List<Control> controlesDashboard = new List<Control>();
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
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

                    //Clientes
                    MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) FROM clientes", conn);
                    lblClientes.Text = cmd2.ExecuteScalar().ToString();

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



        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.TopLevel = false;
            frmProductos.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(frmProductos);
            frmProductos.Show();
        }

        private void btnVerProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.TopLevel = false;
            frmProveedores.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(frmProveedores);
            frmProveedores.Show();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrmAgregar frmAgregar = new FrmAgregar();
            frmAgregar.Show();
        }


        private void menuPrincToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            foreach (Control c in controlesDashboard)
            {
                panel1.Controls.Add(c);
            }

            CargarDatos();
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmProductos prod = new FrmProductos();
            prod.TopLevel = false;
            prod.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(prod);
            prod.Show();
        }

        private void categoríasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCategoria cat = new FrmCategoria();
            cat.TopLevel = false;
            cat.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(cat);
            cat.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProveedores prov = new FrmProveedores();
            prov.TopLevel = false;
            prov.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(prov);
            prov.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAgregar agr = new FrmAgregar();
            agr.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmClientes cli = new FrmClientes();
            cli.TopLevel = false;
            cli.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(cli);
            cli.Show();
        }
    }
}
