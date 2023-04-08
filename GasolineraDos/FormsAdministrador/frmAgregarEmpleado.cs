using GasolineraDos.Administrador;
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

        private void lblGalones_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
