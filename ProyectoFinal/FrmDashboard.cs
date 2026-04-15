using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoFinal
{

    public partial class FrmDashboard : Form
    {
        public string usuarioLogueado;
        Chart chart1;

        string conexion = "server=localhost;database=proyectofinal;uid=root;pwd=1234";
        List<Control> controlesDashboard = new List<Control>();
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            this.Text = "Panel Principal - Usuario: " + usuarioLogueado;
            labelUsuario.Text = usuarioLogueado;

            ProveedoresRecientes();
            
            notifyIcon1.Icon = SystemIcons.Warning;
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon1.Text = "Alerta de Productos con Stock Bajo";
            ProductosStockBajo();
            VerificarStockBajo();

            dgvStock.ReadOnly = true;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvRecientes.ReadOnly = true;
            dgvRecientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            chart1 = new Chart();
            chart1.Dock = DockStyle.Fill;

            ChartArea area = new ChartArea();
            chart1.ChartAreas.Add(area);

            panel10.Controls.Add(chart1);


            CargarGrafico();
            labelFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            CargarDatos();
            foreach (Control c in panel1.Controls)
            {
                controlesDashboard.Add(c);
            }
        }

        public void CargarGrafico()
        {
            
            chart1.Dock = DockStyle.Fill;

            ChartArea area = new ChartArea();
            chart1.ChartAreas.Add(area);


            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conexion))
                    {
                        conn.Open();

                        string query = @"SELECT c.nombre AS categoria, COUNT(p.id) AS total
                             FROM categorias c
                             LEFT JOIN productos p ON p.id_categoria = c.id
                             GROUP BY c.nombre";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        chart1.Series.Clear();
                        chart1.ChartAreas.Clear();

                        ChartArea chartarea = new ChartArea();
                        chart1.ChartAreas.Add(chartarea);

                        Series serie = new Series("Productos");
                        serie.ChartType = SeriesChartType.Column;
                        serie.IsValueShownAsLabel = true;

                        chart1.Series.Add(serie);

                        while (reader.Read())
                        {
                            serie.Points.AddXY(
                                reader["categoria"].ToString(),
                                Convert.ToInt32(reader["total"])
                            );
                        }

                        reader.Close();

                        chart1.DataBind();
                        chart1.Invalidate();
                        chart1.Update();
                        chart1.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar gráfico: " + ex.Message);
                }
            }
        

        }


        public void VerificarStockBajo()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM productos WHERE stock < 5";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    int cantidad = Convert.ToInt32(cmd.ExecuteScalar());

                    if (cantidad > 0)
                    {
                        notifyIcon1.BalloonTipTitle = "Alerta de Inventario";
                        notifyIcon1.BalloonTipText = $"Hay {cantidad} productos con stock bajo.";
                        notifyIcon1.ShowBalloonTip(5000);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar stock: " + ex.Message);
                }
            }
        }


        public void ProductosStockBajo()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT p.nombre, c.nombre AS categoria, p.stock,
                             CASE 
                                WHEN p.stock < 5 THEN 'BAJO'
                                ELSE 'OK'
                             END AS estado
                             FROM productos p
                             INNER JOIN categorias c ON p.id_categoria = c.id
                             WHERE p.stock < 5
                             ORDER BY p.stock ASC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvStock.DataSource = dt;

                    
                    foreach (DataGridViewRow row in dgvStock.Rows)
                    {
                        int stock = Convert.ToInt32(row.Cells["stock"].Value);

                        if (stock < 5)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 138, 138);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
         }

        public void ProveedoresRecientes()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT nombre_empresa AS nombre, telefono, 
                             productos_suministra AS productos, fecha_registro
                             FROM proveedores
                             ORDER BY fecha_registro DESC
                             LIMIT 5";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvRecientes.DataSource = dt;

                    foreach (DataGridViewRow row in dgvRecientes.Rows)
                    {

                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 238, 153);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void CargarDatos()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd1 = new MySqlCommand("SELECT IFNULL(SUM(stock),0) FROM productos", conn);
                    lblProductos.Text = cmd1.ExecuteScalar().ToString();


                    MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) FROM clientes", conn);
                    lblClientes.Text = cmd2.ExecuteScalar().ToString();


                    MySqlCommand cmd3 = new MySqlCommand("SELECT COUNT(*) FROM proveedores", conn);
                    lblProveedores.Text = cmd3.ExecuteScalar().ToString();


                    MySqlCommand cmd4 = new MySqlCommand("SELECT COUNT(*) FROM categorias", conn);
                    lblCategorias.Text = cmd4.ExecuteScalar().ToString();


                    MySqlCommand cmd5 = new MySqlCommand("SELECT COUNT(*) FROM productos WHERE stock < 5", conn);
                    lblStockBajo.Text = cmd5.ExecuteScalar().ToString();

                    CargarGrafico();
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

            CargarGrafico();
            CargarDatos();
            ProductosStockBajo();
            ProveedoresRecientes();
            VerificarStockBajo();
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmProductos prod = new FrmProductos();
            prod.dashboard = this;
            prod.TopLevel = false;
            prod.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(prod);
            prod.Show();
        }

        private void categoríasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCategoria cat = new FrmCategoria();
            cat.dashboard = this;
            cat.TopLevel = false;
            cat.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(cat);
            cat.Show();
            CargarGrafico();
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

        private void FrmDashboard_Activated(object sender, EventArgs e)
        {
            CargarGrafico();
        }
    }
}
