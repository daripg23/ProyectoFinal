using MySql.Data.MySqlClient;
namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        string conexion = "server=localhost;database=inventario;uid=root;pwd=0819200500178";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                errorProvider1.SetError(txtUsuario, "No pueden haber campos vacios");
                return;
            }

            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "No pueden haber campos vacios");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM usuarios WHERE usuario=@usuario AND password=@password";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        FrmDashboard dash = new FrmDashboard();
                        dash.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario y/o contraseña son incorrectos");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error en la conexión: " + ex.Message);
                }
            }
        }
    }
}
