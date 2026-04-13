using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using System.Net.Mail;

namespace ProyectoFinal
{
    public partial class FrmProveedores : Form
    {
        string conexion = "server=localhost;database=proyectofinal;uid=root;pwd=1234";
        int idSeleccionado = 0;

        System.Data.DataTable tabla = new System.Data.DataTable();

        public FrmProveedores()
        {
            InitializeComponent();
        }


        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ContarProveedores();
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.ReadOnly = true;
            dgvProveedores.MultiSelect = false;
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
                    string query = "SELECT * FROM proveedores";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    tabla.Clear();
                    adapter.Fill(tabla);
                    dgvProveedores.DataSource = tabla;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Hubo un error en la carga de datos: " + ex.Message);
                }
            }
        }

        private void ContarProveedores()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM proveedores";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    labelTotProveedores.Text = count.ToString() + " proveedores registrados";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al contar proveedores: " + ex.Message);
                }
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text == "")
            {
                errorProvider1.SetError(txtNombreProveedor, "No pueden haber campos vacíos");
                return;
            }

            if (txtContacto.Text == "")
            {
                errorProvider1.SetError(txtContacto, "No pueden haber campos vacíos");
                return;
            }

            if (txtTelefono.Text == "")
            {
                errorProvider1.SetError(txtTelefono, "No pueden haber campos vacíos");
                return;
            }

            if (txtCorreo.Text == "")
            {
                errorProvider1.SetError(txtCorreo, "No pueden haber campos vacios");
                return;
            }

            if (txtDireccion.Text == "")
            {
                errorProvider1.SetError(txtDireccion, "No pueden haber campos vacíos");
                return;
            }

            if (txtProductos.Text == "")
            {
                errorProvider1.SetError(txtProductos, "No pueden haber campos vacíos");
                return;
            }

            if(labelTelefono.Text == "Formato inválido")
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
                    string query = "INSERT INTO proveedores (nombre_empresa, contacto, telefono, correo, direccion, productos_suministra) VALUES (@nombre_empresa, @contacto, @telefono, @correo, @direccion, @productos_suministra)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombre_empresa", txtNombreProveedor.Text);
                    cmd.Parameters.AddWithValue("@contacto", txtContacto.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@productos_suministra", txtProductos.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proveedor registrado correctamente!");

                    txtID.Clear();
                    txtNombreProveedor.Clear();
                    txtContacto.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                    txtDireccion.Clear();
                    txtProductos.Clear();
                    CargarDatos();
                    ContarProveedores();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error en la adicion: " + ex.Message);
                }
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor para actualizar");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE proveedores SET nombre_empresa=@nombre_empresa, contacto=@contacto, telefono=@telefono, correo=@correo, direccion=@direccion, productos_suministra=@productos_suministra WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre_empresa", txtNombreProveedor.Text);
                    cmd.Parameters.AddWithValue("@contacto", txtContacto.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@productos_suministra", txtProductos.Text);
                    cmd.Parameters.AddWithValue("@id", idSeleccionado);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proveedor actualizado con éxito");
                    txtID.Clear();
                    txtNombreProveedor.Clear();
                    txtContacto.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                    txtDireccion.Clear();
                    txtProductos.Clear();
                    CargarDatos();
                    ContarProveedores();
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
                MessageBox.Show("Seleccione un proveedor para eliminar");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Esta seguro de eliminar este proveedor?",
                "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM proveedores WHERE id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", idSeleccionado);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Proveedor eliminado con éxito");
                        txtID.Clear();
                        txtNombreProveedor.Clear();
                        txtContacto.Clear();
                        txtTelefono.Clear();
                        txtCorreo.Clear();
                        txtDireccion.Clear();
                        txtProductos.Clear();
                        CargarDatos();
                        ContarProveedores();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["id"].Value);
            txtID.Text = idSeleccionado.ToString();
            txtNombreProveedor.Text = fila.Cells["nombre_empresa"].Value.ToString();
            txtContacto.Text = fila.Cells["contacto"].Value.ToString();
            txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
            txtCorreo.Text = fila.Cells["correo"].Value.ToString();
            txtDireccion.Text = fila.Cells["direccion"].Value.ToString();
            txtProductos.Text = fila.Cells["productos_suministra"].Value.ToString();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
            {
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = tabla.DefaultView;
                dv.RowFilter = $"nombre_empresa LIKE '%{txtBuscar.Text}%' OR contacto LIKE '%{txtBuscar.Text}%' OR telefono LIKE '%{txtBuscar.Text}%' OR correo LIKE '%{txtBuscar.Text}%' OR direccion LIKE '%{txtBuscar.Text}%' OR productos_suministra LIKE '%{txtBuscar.Text}%'";
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
                sfd.FileName = "Proveedores.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add(dt, "Proveedores");
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
            txtNombreProveedor.Clear();
            txtContacto.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtProductos.Clear();
            labelTelefono.Text = "";
            labelCorreo.Text = "";
        }
    }
}
