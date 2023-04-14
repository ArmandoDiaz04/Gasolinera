using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using GasolineraDos.Models;
using GasolineraDos.Conexion;
using GasolineraDos.Administrador;

using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gasolinera {
    public partial class frmGestionarCliente : Form {
        public frmGestionarCliente() {
            InitializeComponent();
            llenarDataGridView(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =C:\Users\raulv\OneDrive\Escritorio\git\Gasolinera\GasolineraDos\data\gasolinera.mdf; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Crear el comando SQL para actualizar los datos de la fila seleccionada
                string sql = "UPDATE CLIENTE SET  NOMBRE = @nombre, APELLIDO = @apellido, DIRECCION = @direccion, TELEFONO = @telefono, PUNTOS = @puntos WHERE ID_CLIENTE = @id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Agregar los parámetros al comando SQL
                    command.Parameters.AddWithValue("@id", txtDUI.Text);  
                    command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@apellido", txtApellido.Text);
                    command.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    command.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    command.Parameters.AddWithValue("@puntos", txtPuntos.Text);

                    // Ejecutar el comando SQL
                    command.ExecuteNonQuery();
                }

                // Cerrar la conexión
                connection.Close();
            }

            // Actualizar el DataGridView con los datos modificados
            llenarDataGridView(dataGridView1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();

            if ( !string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                Clientes nuevoCliente = new Clientes
                {  
                    //IdCliente = (int)Convert.ToInt64(txtDUI.Text),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Puntos = 0
                };

                cli.CrearClientes(nuevoCliente);
                this.limpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor complete los campos obligatorios.", "Error al crear cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            llenarDataGridView(dataGridView1);

        }
        private void limpiarCampos()
        {
            txtApellido.Text = null;
            txtDUI.Text = null;
            txtDireccion.Text = null;
            txtNombre.Text = null;
            txtTelefono.Text = null;

        }
        public void llenarDataGridView(DataGridView dataGridView)
        {
           // dataGridView1.Rows.Clear(); 
            using (var contexto = new ContextBd())
            {
                List<Clientes> clientes = contexto.Clientes.ToList();
                dataGridView.DataSource = clientes;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                txtDUI.Text = fila.Cells["IDCLIENTE"].Value.ToString();
                
                txtNombre.Text = fila.Cells["NOMBRE"].Value.ToString();
                txtApellido.Text = fila.Cells["APELLIDO"].Value.ToString();
                txtDireccion.Text = fila.Cells["DIRECCION"].Value.ToString();
                txtTelefono.Text = fila.Cells["TELEFONO"].Value.ToString();
                txtPuntos.Text = fila.Cells["PUNTOS"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();

            if (!string.IsNullOrEmpty(txtDUI.Text.Trim()))
            {
                Clientes nuevoCliente = new Clientes();

                cli.EliminarCliente((int)Convert.ToInt64(txtDUI.Text));
                this.limpiarCampos();
                llenarDataGridView(dataGridView1);

            }
            else
            {
                MessageBox.Show("UPS.", "Error al eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
