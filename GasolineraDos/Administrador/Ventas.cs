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

        public void CrearVenta(Venta venta)
        {
            contexto.Ventas.Add(venta);
            contexto.SaveChanges();
        }


    }
}
