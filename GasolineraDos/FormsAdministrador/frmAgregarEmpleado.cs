using GasolineraDos.Administrador;
using GasolineraDos.Conexion;
using GasolineraDos.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasolinera.FormsAdministrador {
    public partial class frmAgregarEmpleado : Form {

        private int idep;
        public frmAgregarEmpleado() {
            InitializeComponent();
            llenarDataGridView(dataGridView1);
            this.llenarCombo();
            this.llenarTabla();
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

            // Encriptar la contraseña con SHA2_512
            byte[]? contraseniaHash = null;

            using (var sha512 = SHA512.Create())
            {
                contraseniaHash = sha512.ComputeHash(Encoding.UTF8.GetBytes(txtContrasenia.Text.Trim()));
            }
            if (!cmboxCargo.Text.Trim().Equals("---Seleccione una opción--") || txtDUI.Text.Trim().IsNullOrEmpty() || txtContrasenia.Text.IsNullOrEmpty())
            {
                Empleado nuevoEmpleado = new Empleado
                {
                    Dui = txtDUI.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Cargo = cmboxCargo.Text.Trim(),
                    Contrasenia = contraseniaHash
                };

                emp.CrearEmpleado(nuevoEmpleado);
                this.limpiaCampos();
                llenarDataGridView(dataGridView1);
            }
            else {
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

            }
            catch(Exception er)
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
    }
}
