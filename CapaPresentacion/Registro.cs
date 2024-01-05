using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Registro : Form
    {
        private string connString = "Data Source=DESKTOP-Q84FOHK\\SQLEXPRESS;Initial Catalog=Gestor_Inventario;Integrated Security=True";
        private SqlConnection conn;

        public Registro()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (usuario, contraseña, rol) VALUES (@usuario, @contraseña, @rol)", conn);
            cmd.Parameters.AddWithValue("@usuario", usuario1.Text);
            cmd.Parameters.AddWithValue("@contraseña", contraseña1.Text);
            cmd.Parameters.AddWithValue("@rol", "normal");
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Registro exitoso. Inicia sesión para continuar.");
            this.Hide();
            Login inicioSesionForm = new Login();
            inicioSesionForm.Show();
        }

        private void Cerrar1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
