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
        public frmAgregarEmpleado() {
            InitializeComponent();
            
            this.llenarCombo();
            this.llenarTabla();
        }
        private void limpiaCampos() {
            txtContraseña.Text = null;
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
                contraseniaHash = sha512.ComputeHash(Encoding.UTF8.GetBytes(txtContraseña.Text.Trim()));
            }
            if (!cmboxCargo.Text.Trim().Equals("---Seleccione una opción--") || txtDUI.Text.Trim().IsNullOrEmpty() || txtContraseña.Text.IsNullOrEmpty())
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
            }
            else {
                MessageBox.Show("Por favor complete los campos", "Error al crear empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
           
           
            this.llenarCombo();
        }

        public void llenarCombo() {
            string[] elementos = { "---Seleccione una opción--", "Administrador", "Vendedor" };
            cmboxCargo.Items.AddRange(elementos);
            cmboxCargo.SelectedIndex = 0;
        }

        public void llenarTabla() {
            dataGridView1.Rows.Clear();
            List<Empleado> empleados = new();
            using (var bdEmp = new ContextBd())
            {
                empleados = bdEmp.Empleados.ToList();
            }
            foreach (var empleado in empleados)
            {
                string[] row = new string[] { empleado.Dui.ToString(), empleado.Nombre.ToString()
                                             , empleado.Cargo.ToString(),empleado.Telefono.ToString()};
                dataGridView1.Rows.Add(row);
            }

            //dataGridView1
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var valor = "";
            if (e.RowIndex >= 0) // Asegurarse de que se haya seleccionado una fila válida
            {
                valor = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); // Obtener el valor de la primera celda de la fila seleccionada
            }

            using (var bdEmp = new ContextBd())
            {
                var empleados = bdEmp.Empleados.ToList();
                var empleado = empleados.FirstOrDefault(e => e.Dui.Equals(valor)); // idEmpleado es el id del empleado que desea obtener

                txtDUI.Text = empleado.Dui.ToString();
                txtNombre.Text = empleado.Nombre.ToString();
                txtTelefono.Text = empleado.Telefono.ToString();

             
                txtContraseña.Text = empleado.Contrasenia.ToString();
            }
        }
    }
}
