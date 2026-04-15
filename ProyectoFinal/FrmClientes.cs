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
    public partial class FrmClientes : Form
    {
        string conexion = "server=localhost;database=proyectofinal;uid=root;pwd=1234";
        int idSeleccionado = 0;

        System.Data.DataTable tabla = new System.Data.DataTable();

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ContarClientes();
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ReadOnly = true;
            dgvClientes.MultiSelect = false;
            labelTelefono.Text = "";
            labelCorreo.Text = "";
        }

        private void CargarDatos()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM clientes";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    tabla.Clear();
                    adapter.Fill(tabla);
                    dgvClientes.DataSource = tabla;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Hubo un error en la carga de datos: " + ex.Message);
                }
            }
        }

        private void ContarClientes()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM clientes";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    labelTotClientes.Text = count.ToString() + " clientes registrados";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al contar clientes: " + ex.Message);
                }
            }
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "No pueden haber campos vacíos");
                return;
            }

            if (txtTelefono.Text == "")
            {
                errorProvider1.SetError(txtTelefono, "No pueden haber campos vacíos");
                return;
            }

            if (txtCorreo.Text == "")
            {
                errorProvider1.SetError(txtCorreo, "No pueden haber campos vacíos");
                return;
            }

            if (txtDireccion.Text == "")
            {
                errorProvider1.SetError(txtDireccion, "No pueden haber campos vacíos");
                return;
            }

            if (labelTelefono.Text == "Formato inválido")
            {
                errorProvider1.SetError(txtTelefono, "Formato de teléfono inválido");
                return;
            }

            if(labelCorreo.Text == "Correo inválido - Falta @dominio.com")
            {
                errorProvider1.SetError(txtCorreo, "Formato de correo inválido");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO clientes (nombre, telefono, correo, direccion) VALUES (@nombre, @telefono, @correo, @direccion)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente registrado correctamente!");
                    
                    txtID.Clear();
                    txtNombre.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                    txtDireccion.Clear();
                    CargarDatos();
                    ContarClientes();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error en la adición: " + ex.Message);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente para actualizar");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE clientes SET nombre=@nombre, telefono=@telefono, correo=@correo, direccion=@direccion WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@id", idSeleccionado);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente actualizado correctamente!");
                    txtID.Clear();
                    txtNombre.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                    txtDireccion.Clear();
                    idSeleccionado = 0;
                    CargarDatos();
                    ContarClientes();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error en la actualización: " + ex.Message);
                }
            }

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("No se permiten letras en el teléfono", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            string telefono = txtTelefono.Text;

            
            if (System.Text.RegularExpressions.Regex.IsMatch(telefono, @"^\d{4}-\d{4}$"))
            {
                labelTelefono.Text = "Formato válido";
                labelTelefono.ForeColor = Color.Green;
            }
            else
            {
                labelTelefono.Text = "Formato inválido";
                labelTelefono.ForeColor = Color.Red;
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;

            if (correo.Contains("@") && correo.Contains("."))
            {
                labelCorreo.Text = "Correo válido";
                labelCorreo.ForeColor = Color.Green;
            }
            else
            {
                labelCorreo.Text = "Correo inválido - Falta @dominio.com";
                labelCorreo.ForeColor = Color.Red;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente para eliminar");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar este cliente?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM clientes WHERE id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", idSeleccionado);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente eliminado correctamente!");
                        txtID.Clear();
                        txtNombre.Clear();
                        txtTelefono.Clear();
                        txtCorreo.Clear();
                        txtDireccion.Clear();
                        idSeleccionado = 0;
                        CargarDatos();
                        ContarClientes();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error en la eliminación: " + ex.Message);
                    }
                }

            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["id"].Value);
            txtID.Text = idSeleccionado.ToString();
            txtNombre.Text = fila.Cells["nombre"].Value.ToString();
            txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
            txtCorreo.Text = fila.Cells["correo"].Value.ToString();
            txtDireccion.Text = fila.Cells["direccion"].Value.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = tabla.DefaultView;
                dv.RowFilter = $"nombre LIKE '%{txtBuscar.Text}%' OR telefono LIKE '%{txtBuscar.Text}%' OR correo LIKE '%{txtBuscar.Text}%' OR direccion LIKE '%{txtBuscar.Text}%'";
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
                sfd.FileName = "Clientes.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add(dt, "Clientes");
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtBuscar.Clear();
            labelTelefono.Text = "";
            labelCorreo.Text = "";
        }
    }
}
