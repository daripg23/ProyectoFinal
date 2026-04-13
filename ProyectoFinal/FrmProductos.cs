using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmProductos : Form
    {
        public FrmDashboard dashboard;
        string conexion = "server=localhost;database=proyectofinal;uid=root;pwd=1234";
        int idSeleccionado = 0;

        System.Data.DataTable dt = new System.Data.DataTable();
        MySqlDataAdapter adapter;
        DataTable tabla = new DataTable();
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarCategorias();
            CargarCategoriasFiltro();
            ContarProductos();

            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "Sistema de Inventario y Ventas";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            

            labelStock.Visible = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ReadOnly = true;
            dgvProductos.MultiSelect = false;
        }


        private void CargarDatos()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.id, p.nombre, p.id_categoria, c.nombre AS categoria, 
                    p.precio, p.stock,
                    CASE 
                        WHEN p.stock < 5 THEN 'BAJO'
                    ELSE 'OK'
                    END AS estado
                    FROM productos p        
                    INNER JOIN categorias c ON p.id_categoria = c.id";
                    adapter = new MySqlDataAdapter(query, conn);
                    tabla.Clear();
                    adapter.Fill(tabla);
                    dgvProductos.DataSource = tabla;

                    dgvProductos.Columns["id_categoria"].Visible = false;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }

        }


        private void CargarCategorias()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, nombre FROM categorias";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCategoria.DataSource = dt;
                    cmbCategoria.DisplayMember = "nombre";
                    cmbCategoria.ValueMember = "id";
                    cmbCategoria.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar categorías: " + ex.Message);
                }
            }
        }

        private void CargarCategoriasFiltro()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                string query = "SELECT nombre FROM categorias";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbFiltroCategoria.DataSource = dt;
                cmbFiltroCategoria.DisplayMember = "nombre";
                cmbFiltroCategoria.SelectedIndex = -1;
            }
        }

        private void ContarProductos()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM productos";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int totalProductos = Convert.ToInt32(cmd.ExecuteScalar());
                    labelTotProductos.Text = totalProductos.ToString() + " productos registrados";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al contar productos: " + ex.Message);
                }
            }
        }



        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtNombre.Text == "" || txtPrecio.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO productos (nombre, id_categoria, precio, stock) VALUES (@nombre, @id_categoria, @precio, @stock)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@id_categoria", cmbCategoria.SelectedValue);
                    cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));

                    cmd.ExecuteNonQuery();

                    int stock = Convert.ToInt32(txtStock.Text);

                    if (stock < 5)
                    {
                        notifyIcon1.BalloonTipTitle = "Stock Bajo";
                        notifyIcon1.BalloonTipText = $"El producto '{txtNombre.Text}' tiene solo {stock} unidades en stock.";
                        notifyIcon1.ShowBalloonTip(2000);
                    }

                    MessageBox.Show("Producto registrado correctamente!");
                    txtID.Clear();
                    txtNombre.Clear();
                    cmbCategoria.SelectedIndex = -1;
                    txtPrecio.Clear();
                    txtStock.Clear();
                    ContarProductos();
                    CargarDatos();

                    if (dashboard != null)
                    {
                        dashboard.CargarDatos();
                        dashboard.CargarGrafico();
                        dashboard.ProductosStockBajo();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto para actualizar");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE productos SET nombre=@nombre, id_categoria=@id_categoria, precio=@precio, stock=@stock WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@id_categoria", cmbCategoria.SelectedValue);
                    cmd.Parameters.AddWithValue("@precio", txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@stock", txtStock.Text);
                    cmd.Parameters.AddWithValue("@id", idSeleccionado);

                    cmd.ExecuteNonQuery();

                    int stock = Convert.ToInt32(txtStock.Text);

                    if (stock < 5)
                    {
                        notifyIcon1.BalloonTipTitle = "Stock Bajo";
                        notifyIcon1.BalloonTipText = $"El producto '{txtNombre.Text}' tiene solo {stock} unidades en stock.";
                        notifyIcon1.ShowBalloonTip(2000);
                    }

                    MessageBox.Show("Producto actualizado con éxito");
                    txtID.Clear();
                    txtNombre.Clear();
                    cmbCategoria.SelectedIndex = -1;
                    txtPrecio.Clear();
                    txtStock.Clear();
                    CargarDatos();
                    if (dashboard != null)
                    {
                        dashboard.CargarDatos();
                        dashboard.CargarGrafico();
                        dashboard.ProductosStockBajo();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Esta seguro de eliminar este producto?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM productos WHERE id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", idSeleccionado);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Producto eliminado con éxito");
                        txtID.Clear();
                        txtNombre.Clear();
                        cmbCategoria.SelectedIndex = -1;
                        txtPrecio.Clear();
                        txtStock.Clear();
                        CargarDatos();
                        ContarProductos();
                        if (dashboard != null)
                        {
                            dashboard.CargarDatos();
                            dashboard.CargarGrafico();
                            dashboard.ProductosStockBajo();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }



        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                idSeleccionado = Convert.ToInt32(fila.Cells["id"].Value);
                txtID.Text = idSeleccionado.ToString();
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();

                cmbCategoria.SelectedValue = fila.Cells["id_categoria"].Value;

                txtPrecio.Text = fila.Cells["precio"].Value.ToString();
                txtStock.Text = fila.Cells["stock"].Value.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombre.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtStock.Clear();
            txtPrecio.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = tabla.DefaultView;

                string filtro = "";


                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    string texto = txtBuscar.Text.Replace("'", "''");
                    filtro += $"nombre LIKE '%{texto}%'";
                }


                if (cmbFiltroCategoria.SelectedIndex != -1)
                {
                    string categoria = cmbFiltroCategoria.Text;

                    if (filtro != "")
                        filtro += " AND ";

                    filtro += $"categoria = '{categoria}'";
                }

                dv.RowFilter = filtro;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en búsqueda: " + ex.Message);
            }
        }

        private void ExportarExcel(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }
            using (SaveFileDialog sfd = new SaveFileDialog())
            {

                sfd.Filter = "Excel (*.xlsx)|*.xlsx";
                sfd.FileName = "Productos.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add(dt, "Productos");
                            ws.Row(1).Style.Font.Bold = true;
                            ws.Columns().AdjustToContents();
                            wb.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Datos exportados correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar: " + ex.Message);
                    }
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel(tabla);
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            int stock;
            if (int.TryParse(txtStock.Text, out stock))
            {
                if (stock < 5)
                {
                    labelStock.Text = "ADVERTENCIA: STOCK BAJO – Requiere reposición";
                    labelStock.Visible = true;
                }
                else
                {
                    labelStock.Visible = false;
                }
            }
            else
            {
                labelStock.Visible = false;
            }
        }

        private void dgvProductos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.Cells["stock"].Value != null)
                {
                    int stock = Convert.ToInt32(row.Cells["stock"].Value);

                    if (stock < 5)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
        }

        
    }
}
