using System;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace CapaPresentacion
{
    public partial class Login : Form
    {
        private string connString = "Data Source=DESKTOP-Q84FOHK\\SQLEXPRESS;Initial Catalog=Gestor_Inventario;Integrated Security=True";
        private SqlConnection conn;

        public Login()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT id FROM Usuarios WHERE usuario=@usuario AND contraseña=@contraseña", conn);
            cmd.Parameters.AddWithValue("@usuario", usuario.Text);
            cmd.Parameters.AddWithValue("@contraseña", con.Text);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                this.Hide();
                Gestor_inventario gestor_inventarioForm = new Gestor_inventario();
                gestor_inventarioForm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro registroForm = new Registro();
            registroForm.Show();
        }

    }
}

