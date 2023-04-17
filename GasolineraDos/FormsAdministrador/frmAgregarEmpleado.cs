using GasolineraDos.Administrador;
using GasolineraDos.Conexion;
using GasolineraDos.Models;
using Microsoft.IdentityModel.Tokens;
using GasolineraDos;

namespace Gasolinera.FormsAdministrador
{
    public partial class frmAgregarEmpleado : Form {

      
        private int idep;
        private ContextBd contexto;
      
        public frmAgregarEmpleado() {
            InitializeComponent();
            llenarDataGridView(dataGridView1);
            this.llenarCombo();
            this.contexto = new ContextBd();
            this.button2.Enabled = false;
            this.button3.Enabled =false;



        }
        private void limpiaCampos() {
            txtContrasenia.Text = null;
            txtDUI.Text = null;
            txtNombre.Text = null;
            txtTelefono.Text = null;
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados();
         // Clave secreta para el cifrado

            if (!cmboxCargo.Text.Trim().Equals("---Seleccione una opción--") || txtDUI.Text.Trim().IsNullOrEmpty() || txtContrasenia.Text.IsNullOrEmpty())
            {

                // Cifrar la contraseña
                //byte[] contraseniaCifrada = Empleados.Encriptar(txtDUI.Text.Trim(), txtContrasenia.Text.Trim(), user.Default.cargo);
                byte[] contraseniaCifrada = Empleados.Encriptar( txtContrasenia.Text.Trim());

                Empleado nuevoEmpleado = new Empleado
                {
                    Dui = txtDUI.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Cargo = cmboxCargo.Text.Trim(),
                    Contrasenia = contraseniaCifrada 
                };

                emp.CrearEmpleado(nuevoEmpleado);
                this.limpiaCampos();
                llenarDataGridView(dataGridView1);
            }
            else
            {
                MessageBox.Show("Por favor complete los campos", "Error al crear empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.llenarCombo();
        }

        public void llenarDataGridView(DataGridView dataGridView)
        {
            // dataGridView1.Rows.Clear(); 
            using (var contexto = new ContextBd())
            {
                List<Empleado> emp = contexto.Empleados.ToList();
                dataGridView.DataSource = emp;
            }
        }

        public void llenarCombo() {
            string[] elementos = { "---Seleccione una opción--", "Administrador", "Vendedor" };
            cmboxCargo.Items.AddRange(elementos);
            cmboxCargo.SelectedIndex = 0;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                    idep =(int) fila.Cells["IDEMPLEADO"].Value;
                    txtDUI.Text = fila.Cells["DUI"].Value.ToString();
                    txtNombre.Text = fila.Cells["NOMBRE"].Value.ToString();
                    txtContrasenia.Text = fila.Cells["CONTRASENIA"].Value.ToString();
                    txtTelefono.Text = fila.Cells["TELEFONO"].Value.ToString();
                    cmboxCargo.Text = fila.Cells["CARGO"].Value.ToString();                   
                }



                Empleado empleado = contexto.Empleados.SingleOrDefault(e => e.Dui.Equals(txtDUI.Text.Trim()));

                if (empleado != null)
                {
                    string contrasenia = Empleados.Desencriptar(empleado.Contrasenia);
                    MessageBox.Show(contrasenia);
                    this.button2.Enabled = true;
                    this.button3.Enabled = true;
                    this.button1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún empleado con ese DUI.");
                }


                //string contrasenia = Empleados.Desencriptar(empleado.Contrasenia);
                //MessageBox.Show(contrasenia);
                //this.button2.Enabled = true;
                //this.button3.Enabled = true;
                //this.button1.Enabled = false;

            }
            catch (Exception er)
            {
                MessageBox.Show("Error:"+er, "Error al eliminar empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(er.Message);
            }
           
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is ArgumentException)
            {
                // Mostrar mensaje de error personalizado
                //MessageBox.Show("Error al cargar la imagen: " + e.Exception.Message);
                //e.ThrowException = false;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleados cli = new Empleados();

            if (idep != null)
            {
               
                DialogResult result = MessageBox.Show($"¿Está seguro que desea eliminar a {txtNombre.Text} ({txtNombre.Text})?", "Eliminar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cli.EliminarEmpleado(idep);
                    llenarDataGridView(dataGridView1);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un empleado", "Error al eliminar empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleados cli = new Empleados();
            cli.EditarEmpleado(idep, txtNombre.Text, cmboxCargo.Text);
            llenarDataGridView(dataGridView1);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.button2.Enabled = false;
            this.button3.Enabled = false;

            //idep = 0;
            txtDUI.Text = "";
            txtNombre.Text ="";
            txtContrasenia.Text ="";
            txtTelefono.Text ="";
            cmboxCargo.SelectedIndex =0;

        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtDUI_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(txtDUI, "Ingrese su numero de DUI sin guion.");
        }

        private void txtDUI_TextChanged(object sender, EventArgs e)
        {
            if (txtDUI.Text.Length == 8)
            {
                txtDUI.Text += "-";
                txtDUI.SelectionStart = txtDUI.Text.Length;
            }
            else if (txtDUI.Text.Length > 10)
            {
                txtDUI.Text = txtDUI.Text.Substring(0, 9);
                txtDUI.SelectionStart = txtDUI.Text.Length;


            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtDUI.Text.Length == 4)
            {
                txtDUI.Text += "-";
                txtDUI.SelectionStart = txtDUI.Text.Length;
            }
        }
    }
}
