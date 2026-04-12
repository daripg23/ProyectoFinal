using MySql.Data.MySqlClient;
namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        string conexion = "server=localhost;database=proyectofinal;uid=root;pwd=1234";
        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
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
                    string query = "SELECT COUNT(*) FROM usuarios WHERE usuario=@usuario AND contrasena=@contrasena";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@contrasena", txtPassword.Text);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        FrmDashboard dash = new FrmDashboard();
                        MessageBox.Show("Bienvenido, " + txtUsuario.Text);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrar.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            FrmAgregar agregar = new FrmAgregar();
            agregar.Show();
            this.Hide();
        }
    }
}
