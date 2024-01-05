using CapaEntidad;
using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Gestor_inventario : Form
    {
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocio objneg = new ClaseNegocio();

        public Gestor_inventario()
        {
            InitializeComponent();
        }

        void mantenimiento(String accion)
        {
            objent.codigo = txtid.Text;
            objent.nombre = txtNombre.Text;
            objent.descripcion = txtDescri.Text;
            objent.precio = Convert.ToDecimal(txtPrecio.Text);
            objent.cantidad = Convert.ToInt32((txtCan.Text));
            objent.accion = accion;
            String men = objneg.N_Mantenimiento_Articulos(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            txtid.Text = "";
            txtNombre.Text = "";
            txtDescri.Text = "";
            txtPrecio.Text = "";
            txtCan.Text = "";
            dataGridView1.DataSource = objneg.N_Lista_Articulos();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cierre de sesión exitoso.");
            this.Hide();
            Login inicioSesionForm = new Login();
            inicioSesionForm.Show();
        }

        private void Gestor_inventario_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_Lista_Articulos();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a " + txtNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    limpiar();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a " + txtNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + txtNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }

        private void txtBusqueda_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                objent.nombre = txtBusqueda.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_Busqueda_Articulos(objent);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objneg.N_Lista_Articulos();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtid.Text = dataGridView1[0, fila].Value.ToString();
            txtNombre.Text = dataGridView1[1, fila].Value.ToString();
            txtDescri.Text = dataGridView1[2, fila].Value.ToString();
            txtPrecio.Text = dataGridView1[3, fila].Value.ToString();
            txtCan.Text = dataGridView1[4, fila].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }


    }
}
