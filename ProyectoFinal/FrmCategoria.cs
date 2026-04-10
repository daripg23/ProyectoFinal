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
    public partial class FrmCategoria : Form
    {
        string conexion = "server=localhost;database=inventario;uid=root;pwd=0819200500178";
        int idSeleccionado = 0;

        System.Data.DataTable dt = new System.Data.DataTable();
        MySqlDataAdapter adapter;
        DataTable tabla = new DataTable();
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreCategoria.Text == "")
            {
                errorProvider1.SetError(txtNombreCategoria, "No pueden haber campos vacios");
                return;
            }

            if (txtDescripcionCat.Text == "")
            {
                errorProvider1.SetError(txtDescripcionCat, "No pueden haber campos vacios");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO categorias (nombre_cat, descripcion_cat) VALUES (@nombre_cat, @descripcion_cat)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombre_cat", txtNombreCategoria.Text);
                    cmd.Parameters.AddWithValue("@descripcion_cat", txtDescripcionCat.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoria registrada correctamente!");

                    txtNombreCategoria.Clear();
                    txtDescripcionCat.Clear();
                    CargarDatos();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error en la adicion: " + ex.Message);
                }
            }
        }
        private void CargarDatos()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM categorias";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    tabla.Clear();
                    adapter.Fill(tabla);
                    dgvCategorias.DataSource = tabla;
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
                MessageBox.Show("Seleccione una categoria para actualizar");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE categorias SET nombre_cat=@nombre_cat, descripcion_cat=@descripcion_cat WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombre_cat", txtNombreCategoria.Text);
                    cmd.Parameters.AddWithValue("@rtn_prov", txtDescripcionCat.Text);
                    cmd.Parameters.AddWithValue("@id", idSeleccionado);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoria actualizada con exito");

                    txtNombreCategoria.Clear();
                    txtDescripcionCat.Clear();
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
                MessageBox.Show("Seleccione una categoria para eliminar");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Esta seguro de eliminar esta categoria?",
                "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM categorias WHERE id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", idSeleccionado);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Categoria eliminada con exito");

                        txtNombreCategoria.Clear();
                        txtDescripcionCat.Clear();
                        CargarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["id"].Value);
            txtNombreCategoria.Text = fila.Cells["nombre_cat"].Value.ToString();
            txtDescripcionCat.Text = fila.Cells["descripcion_cat"].Value.ToString();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.ReadOnly = true;
            dgvCategorias.MultiSelect = false;
        }
    }
}
