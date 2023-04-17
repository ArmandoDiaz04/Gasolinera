using GasolineraDos.Administrador;
using GasolineraDos.Conexion;
using GasolineraDos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Windows.Forms;

namespace Gasolinera
{
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
         
        }

       
        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados();
            try
            {
                var usuario = textBox1.Text.Trim();
                var password = textBox2.Text.Trim();

                if (!usuario.IsNullOrEmpty() || !password.IsNullOrEmpty())
                {
                    
                    if (!emp.inicioSesion(usuario, password).IsNullOrEmpty())
                    {
                      
                        this.Hide();
                        new frmBienvenida().ShowDialog();
                    }
                }
                else {
                    MessageBox.Show("Por favor complete los campos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }
    }
}
