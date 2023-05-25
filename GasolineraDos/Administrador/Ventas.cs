using System;
using System.Collections.Generic;
using System.Linq;
using GasolineraDos.Models;
using GasolineraDos.Conexion;
using System.Text;
using System.Threading.Tasks;

namespace GasolineraDos.Administrador
{
    public class Ventas
    {
        private ContextBd contexto;

        public Ventas()
        {
            this.contexto = new ContextBd();
        }

        public void CrearVenta(Venta venta, DetalleVenta detalleVenta)
        {

            using (var contexto = new ContextBd()) // Reemplaza "TuContexto" con el nombre de tu clase de contexto de Entity Framework
            {
                contexto.Ventas.Add(venta);
                contexto.SaveChanges();

                // Asignar la venta al detalleVenta
                detalleVenta.VentaId = venta.IdVenta;
                detalleVenta.Venta = venta;

                MessageBox.Show("ff" + venta.IdVenta);

                // Insertar el detalleVenta y guardar los cambios
                contexto.DetallesVenta.Add(detalleVenta);
                contexto.SaveChanges();

            }
        }

    }
}
