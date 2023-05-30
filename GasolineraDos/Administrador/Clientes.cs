using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gasolinera.FormsAdministrador;
using GasolineraDos.Conexion;
using GasolineraDos.Models;
using System.Threading.Tasks;

namespace GasolineraDos.Administrador
{
    public class Cliente
    {
        private ContextBd contexto;

        public Cliente()
        {
            this.contexto = new ContextBd();
        }
        public void ObtenerPuntosYNombreCliente(int idCliente)
        {
            using (var db = new ContextBd())
            {
                var cliente = db.Clientes.FirstOrDefault(c => c.IdCliente == idCliente);
                if (cliente != null)
                {
                    int puntos = (int)cliente.Puntos;
                    string nombre = cliente.Nombre;

                    // Realiza la lógica que necesites con los puntos y el nombre obtenidos
                    // Puedes mostrarlos en un MessageBox, asignarlos a controles de formulario, etc.
                    MessageBox.Show($"El cliente {nombre} tiene {puntos} puntos.");
                }
                else
                {
                    // Si no se encuentra el cliente con el ID especificado
                    MessageBox.Show("No se encontró el cliente con el ID especificado.");
                }
            }
        }


        public void CrearClientes(Clientes clientes)
        {
            try
            {
                contexto.Clientes.Add(clientes);
                contexto.SaveChanges();

            }
            catch(Exception E)
            {
                MessageBox.Show("ERROR EN EL INSERT."+E, "Error al crear cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        public bool EliminarCliente(int idCliente)
        {
            using (var context = new ContextBd())
            {
                var clienteAEliminar = context.Clientes.Find(idCliente);
                if (clienteAEliminar != null)
                {
                    context.Clientes.Remove(clienteAEliminar);                   
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //public void ActualizarCliente(int dui,string nombre,string)
        //{
           
        //        // Obtener el objeto correspondiente a la entidad CLIENTE
        //        var cliente = dbContext.CLIENTE.Find(dui);

        //        // Actualizar las propiedades del objeto recuperado
        //        cliente.NOMBRE = nombre;
        //        cliente.APELLIDO = txtApellido.Text;
        //        cliente.DIRECCION = txtDireccion.Text;
        //        cliente.TELEFONO = txtTelefono.Text;
        //        cliente.PUNTOS = int.Parse(txtPuntos.Text);

        //        // Guardar los cambios en la base de datos
        //        contexto.SaveChanges();
           

           
        //}
    }
}
