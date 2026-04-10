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
    public partial class FrmProductos : Form
    {
        string conexion = "server=localhost;database=inventario;uid=root;pwd=0819200500178";
        int idSeleccionado = 0;

        System.Data.DataTable dt = new System.Data.DataTable();
        MySqlDataAdapter adapter;
        DataTable tabla = new DataTable();
        public FrmProductos()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "No pueden haber campos vacios");
                return;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbCategoria, "Tiene que seleccionar una opcion");
                return;
            }

            if (txtPrecio.Text == "")
            {
                errorProvider1.SetError(txtPrecio, "No pueden haber campos vacios");
                return;
            }

            if (txtStock.Text == "")
            {
                errorProvider1.SetError(txtStock, "No pueden haber campos vacios");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO productos (nombre_prod, categoria_prod, precio_prod, stock) VALUES (@nombre_prod, @categoria_prod, @precio_prod, @stock)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombre_prod", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@categoria_prod", cmbCategoria.Text);
                    cmd.Parameters.AddWithValue("@precio_prod", txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@stock", txtStock.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto registrado correctamente!");

                    txtNombre.Clear();
                    cmbCategoria.SelectedIndex = -1;
                    txtPrecio.Clear();
                    txtStock.Clear();
                    CargarDatos();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error en la adicion: " + ex.Message);
                }
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                    // Tabla para Productos
                    DataTable dtProductos = new DataTable();
                    string queryProductos = "SELECT * FROM productos";
                    MySqlDataAdapter adapterProd = new MySqlDataAdapter(queryProductos, conn);
                    adapterProd.Fill(dtProductos);

                    dgvProductos.DataSource = dtProductos;

                    dgvProductos.Columns["id"].HeaderText = "ID";
                    dgvProductos.Columns["nombre_prod"].HeaderText = "Producto";
                    dgvProductos.Columns["categoria_prod"].HeaderText = "Categoria";
                    dgvProductos.Columns["precio_prod"].HeaderText = "Precio";
                    dgvProductos.Columns["stock"].HeaderText = "Stock";

                    //Tabla para Categorias
                    DataTable dtCategorias = new DataTable();
                    string queryCategorias = "SELECT * FROM categorias";
                    MySqlDataAdapter adapterCat = new MySqlDataAdapter(queryCategorias, conn);
                    adapterCat.Fill(dtCategorias);

                    cmbCategoria.DataSource = dtCategorias;
                    cmbCategoria.DisplayMember = "nombre_cat";
                    cmbCategoria.ValueMember = "id";
                    cmbCategoria.SelectedIndex = -1;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Hubo un error en la carga de datos: " + ex.Message);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
                    string query = "UPDATE productos SET nombre_prod=@nombre_prod, categoria_prod=@categoria_prod, precio_prod=@precio_prod, stock=@stock WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombre_prod", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@categoria_prod", cmbCategoria.Text);
                    cmd.Parameters.AddWithValue("@precio_prod", txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@stock", txtStock.Text);
                    cmd.Parameters.AddWithValue("@id", idSeleccionado);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto actualizado con exito");

                    txtNombre.Clear();
                    cmbCategoria.SelectedIndex = -1;
                    txtPrecio.Clear();
                    txtStock.Clear();
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Esta seguro de eliminar este producto?",
                "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                        MessageBox.Show("Producto eliminado con exito");

                        txtCodigo.Clear();
                        txtNombre.Clear();
                        cmbCategoria.SelectedIndex = -1;
                        txtPrecio.Clear();
                        CargarDatos();
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
            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["id"].Value);
            txtNombre.Text = fila.Cells["nombre_prod"].Value.ToString();
            cmbCategoria.Text = fila.Cells["categoria_prod"].Value.ToString();
            txtPrecio.Text = fila.Cells["precio_prod"].Value.ToString();
            txtStock.Text = fila.Cells["stock"].Value.ToString();
        }
    }
}
