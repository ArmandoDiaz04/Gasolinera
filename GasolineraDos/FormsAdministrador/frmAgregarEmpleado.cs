using GasolineraDos.Administrador;
using GasolineraDos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasolinera.FormsAdministrador {
    public partial class frmAgregarEmpleado : Form {
        public frmAgregarEmpleado() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados();

            // Encriptar la contraseña con SHA2_512
            byte[] contraseniaHash = null;
            using (var sha512 = new System.Security.Cryptography.SHA512Managed())
            {
                contraseniaHash = sha512.ComputeHash(Encoding.UTF8.GetBytes(txtContraseña.Text.Trim()));
            }

            Empleado nuevoEmpleado = new Empleado
            {
                Dui = txtDUI.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Cargo = cmboxCargo.Text.Trim(),
                Contrasenia = contraseniaHash
            };
            emp.CrearEmpleado(nuevoEmpleado);
        }

    }
}
