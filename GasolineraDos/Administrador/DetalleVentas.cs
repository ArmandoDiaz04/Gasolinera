using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GasolineraDos.Conexion;
using System.Threading.Tasks;
using GasolineraDos.Models;
using System.Data.SqlClient;

namespace GasolineraDos.Administrador
{
    public class DetalleVentas
    {
        private ContextBd contexto;

        public DetalleVentas()
        {
            this.contexto = new ContextBd();
        }

        //public void CrearVenta(DetalleVenta venta)
        //{
        //    contexto.DetallesVentas.Add(venta);
        //    contexto.SaveChanges();
        //}
        //public void InsertarDetalleVenta(int idBomba, int idVenta, double cantidad, double descuento, double precio)
        //{
        //    string insertSql = "INSERT INTO DETALLE_VENTA (ID_BOMBA, ID_VENTA, CANTIDAD, DESCUENTO, PRECIO) " +
        //                       "VALUES (@idBomba, @idVenta, @cantidad, @descuento, @precio)";

        //    using (var context = new ContextBd()) // Reemplaza "TuContexto" con el nombre de tu clase de contexto de Entity Framework
        //    {
        //            context.DetallesVentas.(insertSql,
        //                                               new SqlParameter("@idBomba", idBomba),
        //                                               new SqlParameter("@idVenta", idVenta),
        //                                               new SqlParameter("@cantidad", cantidad),
        //                                               new SqlParameter("@descuento", descuento),
        //                                               new SqlParameter("@precio", precio));
        //    }
        //}


    }
}
