using GasolineraDos.Models;
using GasolineraDos.Conexion;
using GasolineraDos.Administrador;

namespace Gasolinera
{
    public partial class frmGestionarCliente : Form {
        public frmGestionarCliente() {
            InitializeComponent();
            llenarDataGridView(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear el contexto de base de datos
            using (var db = new ContextBd())
            {
                // Obtener el cliente correspondiente al ID
                var cliente = db.Clientes.FirstOrDefault(c => c.IdCliente == int.Parse(txtDUI.Text));

                // Actualizar las propiedades del cliente
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Puntos = int.Parse(txtPuntos.Text);

                // Guardar los cambios en la base de datos
                db.SaveChanges();
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

        

        private void txtDUI_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.Show("Ingrese su numero de DUI sin guiones.", txtDUI, 0, -25, 5000);


        }

        
    }
}
