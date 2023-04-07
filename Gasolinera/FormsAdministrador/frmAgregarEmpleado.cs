using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gasolinera;

namespace Gasolinera.FormsAdministrador {
    public partial class frmAgregarEmpleado : Form {

        private readonly string cadenaConexion = "Data Source=localhost;Initial Catalog=gasolinera;User ID=sa;Password=sopa;";
        public frmAgregarEmpleado() {
            InitializeComponent();
            ProbarConexion();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //int idEmpleado = int.Parse(this.txtDUI.Text);
            //string nombre = this.txtNombre.Text;
            //string cargo = this.txtEmail.Text;
            //string telefono = txtTelefono.Text;

            //this.button1.Text = idEmpleado.ToString() + '-' + nombre + '-' + cargo + '-' + telefono;


            //string consulta = "INSERT INTO EMPLEADO (ID_EMPLEADO, NOMBRE, CARGO, TELEFONO)" +
            //    " VALUES (@idEmpleado, @nombre, @cargo, @telefono)";

            //using (var conexion = new Conexion(cadenaConexion))
            //{
            //    try
            //    {
            //        conexion.ObtenerConexion();

            //        if (conexion.ObtenerConexion().State != ConnectionState.Open)
            //        {
            //            conexion.ObtenerConexion().Open();
            //        }

            //        var command = new SqlCommand(consulta, conexion.ObtenerConexion());
            //        command.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            //        command.Parameters.AddWithValue("@nombre", nombre);
            //        command.Parameters.AddWithValue("@cargo", cargo);
            //        command.Parameters.AddWithValue("@telefono", telefono);
            //        command.ExecuteNonQuery();

            //        MessageBox.Show("Empleado agregado correctamente.");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error al agregar el empleado: {ex.Message}");
            //    }
            //}

        }

        public void ProbarConexion()
        {
            string consulta = "SELECT COUNT(*) FROM EMPLEADO";
            using (var conexion = new Conexion(cadenaConexion))
            {
                try
                {
                    conexion.ObtenerConexion();

                    if (conexion.ObtenerConexion().State != ConnectionState.Open)
                    {
                        conexion.ObtenerConexion().Open();
                    }

                    var command = new SqlCommand(consulta, conexion.ObtenerConexion());
                    int count = (int)command.ExecuteScalar();
                    MessageBox.Show($"La conexión funciona correctamente. Hay {count} empleados registrados.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}");
                }
            }
        }

    }
}
