using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;
using System.IO;
using System.Net.Mail;

namespace ProyectoFinal
{
    
    public partial class FrmCategoria : Form
    {
        public FrmDashboard dashboard;
        string conexion = "server=localhost;database=proyectofinal;uid=root;pwd=1234";
        int idSeleccionado = 0;

        System.Data.DataTable tabla = new System.Data.DataTable();

        public FrmCategoria()
        {
            InitializeComponent();
        }


        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ContarCategorias();
            dashboard.CargarGrafico();
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.ReadOnly = true;
            dgvCategorias.MultiSelect = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreCategoria.Text == "")
            {
                errorProvider1.SetError(txtNombreCategoria, "No pueden haber campos vacios");
                return;
            }


            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO categorias (nombre, descripcion) VALUES (@nombre, @descripcion)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombre", txtNombreCategoria.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcionCat.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoría registrada correctamente!");
                    txtID.Clear();
                    txtNombreCategoria.Clear();
                    txtDescripcionCat.Clear();
                    CargarDatos();
                    ContarCategorias();

                    if (dashboard != null)
                    {
                        dashboard.CargarGrafico();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error en la adición: " + ex.Message);
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

        private void ContarCategorias()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM categorias";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int totalCategorias = Convert.ToInt32(cmd.ExecuteScalar());
                    labelTotCategorias.Text = $"{totalCategorias} categorías registradas";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al contar categorías: " + ex.Message);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una categoría para actualizar");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE categorias SET nombre=@nombre, descripcion=@descripcion WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombre", txtNombreCategoria.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcionCat.Text);
                    cmd.Parameters.AddWithValue("@id", idSeleccionado);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoría actualizada con éxito");
                    txtID.Clear();
                    txtNombreCategoria.Clear();
                    txtDescripcionCat.Clear();
                    CargarDatos();
                    ContarCategorias();

                    if (dashboard != null)
                    {
                        dashboard.CargarGrafico();
                    }
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
                MessageBox.Show("Seleccione una categoría para eliminar");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Esta seguro de eliminar esta categoría?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                        MessageBox.Show("Categoría eliminada con éxito");
                        txtID.Clear();
                        txtNombreCategoria.Clear();
                        txtDescripcionCat.Clear();
                        CargarDatos();
                        ContarCategorias();

                        if (dashboard != null)
                        {
                            dashboard.CargarGrafico();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("¡Esta categoría no puede eliminarse porque tiene productos asociados!", "Error");
                    }
                }
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["id"].Value);
            txtID.Text = idSeleccionado.ToString();
            txtNombreCategoria.Text = fila.Cells["nombre"].Value.ToString();
            txtDescripcionCat.Text = fila.Cells["descripcion"].Value.ToString();
        }

        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombreCategoria.Clear();
            txtDescripcionCat.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = tabla.DefaultView;
                dv.RowFilter = $"nombre LIKE '%{txtBuscar.Text}%' OR descripcion LIKE '%{txtBuscar.Text}%'";
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
                sfd.FileName = "Categorias.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add(dt, "Categorias");
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
    }
}
