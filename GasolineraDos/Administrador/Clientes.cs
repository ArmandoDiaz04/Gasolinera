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

    }
}
