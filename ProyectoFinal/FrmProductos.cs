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
        string conexion = "server=localhost;database=proyectofinal;uid=root;pwd=1234";
        int idSeleccionado = 0;

        System.Data.DataTable dt = new System.Data.DataTable();
        MySqlDataAdapter adapter;
        DataTable tabla = new DataTable();
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.id, p.nombre, p.id_categoria, c.nombre AS categoria, p.precio, p.stock
                    FROM productos p
                    INNER JOIN categorias c ON p.id_categoria = c.id";
                    adapter = new MySqlDataAdapter(query, conn);
                    tabla.Clear();
                    adapter.Fill(tabla);
                    dgvProductos.DataSource = tabla;
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

                    MessageBox.Show("Producto registrado correctamente!");

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


        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarCategorias();
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.ReadOnly = true;
            dgvProductos.MultiSelect = false;
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
                    string query = "UPDATE productos SET nombre=@nombre, id_categoria=@id_categoria, precio=@precio, stock=@stock WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@id_categoria", cmbCategoria.SelectedValue);
                    cmd.Parameters.AddWithValue("@precio", txtPrecio.Text);
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

        
    }
}
