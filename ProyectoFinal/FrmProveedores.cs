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
    public partial class FrmProveedores : Form
    {
        string conexion = "server=localhost;database=proyectofinal;uid=root;pwd=1234";
        int idSeleccionado = 0;

        System.Data.DataTable dt = new System.Data.DataTable();
        MySqlDataAdapter adapter;
        DataTable tabla = new DataTable();
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

            if(txtProductos.Text == "")
            {
                errorProvider1.SetError(txtProductos, "No pueden haber campos vacíos");
                return;
            }


            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO proveedores (nombre_prov, rtn_prov, telefono_prov, correo_prov) VALUES (@nombre_prov, @rtn_prov, @telefono_prov, @correo_prov)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombre_prov", txtNombreProveedor.Text);
                    //cmd.Parameters.AddWithValue("@rtn_prov", txtRTN.Text);
                    cmd.Parameters.AddWithValue("@telefono_prov", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@correo_prov", txtCorreo.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proveedor registrado correctamente!");

                    txtNombreProveedor.Clear();
                    //txtRTN.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
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

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.ReadOnly = true;
            dgvProveedores.MultiSelect = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
                    string query = "UPDATE proveedores SET nombre_prov=@nombre_prov, rtn_prov=@rtn_prov, telefono_prov=@telefono_prov, correo_prov=@correo_prov WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombre_prov", txtNombreProveedor.Text);
                   //cmd.Parameters.AddWithValue("@rtn_prov", txtRTN.Text);
                    cmd.Parameters.AddWithValue("@telefono_prov", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@correo_prov", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@id", idSeleccionado);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proveedor actualizado con éxito");

                    txtNombreProveedor.Clear();
                    //txtRTN.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
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
                        MessageBox.Show("Proveedor eliminado con exito");

                        txtNombreProveedor.Clear();
                        //txtRTN.Clear();
                        txtTelefono.Clear();
                        txtCorreo.Clear();
                        CargarDatos();
                    }
                    catch (Exception ex)
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
            txtNombreProveedor.Text = fila.Cells["nombre_prov"].Value.ToString();
            //txtRTN.Text = fila.Cells["rtn_prov"].Value.ToString();
            txtTelefono.Text = fila.Cells["telefono_prov"].Value.ToString();
            txtCorreo.Text = fila.Cells["correo_prov"].Value.ToString();
        }
    }
}
