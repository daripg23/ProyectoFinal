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
    public partial class FrmAgregar : Form
    {
        string conexion = "server=localhost;database=inventario;uid=root;pwd=0819200500178";
        public FrmAgregar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                errorProvider1.SetError(txtUsuario, "No pueden registrarse campos vacios");
                return;
            }

            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "No pueden registrarse campos vacios");
                return;
            }

            if (txtPassword2.Text == "")
            {
                errorProvider1.SetError(txtPassword2, "No pueden registrarse campos vacios");
                return;
            }

            if (txtPassword2.Text != txtPassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO usuarios (usuario, password) VALUES (@usuario, @password)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
