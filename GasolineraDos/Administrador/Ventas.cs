using System;
using System.Collections.Generic;
using System.Linq;
using GasolineraDos.Models;
using GasolineraDos.Conexion;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

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

               

                // Insertar el detalleVenta y guardar los cambios
                contexto.DetallesVenta.Add(detalleVenta);
                int idVenta = venta.IdVenta;

                var idVentaParam = new SqlParameter("@id_venta", Convert.ToInt32(venta.IdVenta));
                var montoOutParam = new SqlParameter("@monto_out", Convert.ToDouble(venta.Total));

                contexto.Database.ExecuteSqlRaw("EXEC RegistrarTransaccion @id_venta, @monto_out", idVentaParam, montoOutParam);

                contexto.SaveChanges();
                //resgistro en trsansaccion
              

                MessageBox.Show("Venta Exitosa!!");


            }
        }
        public void ReducirCantidadGasolina(int idBomba, decimal cantidadAReducir)
        {
            using (var contexto = new ContextBd()) // Reemplaza "TuContexto" con el nombre de tu clase de contexto de Entity Framework
            {
                var bomba = contexto.Bombas.FirstOrDefault(b => b.ID_BOMBA == idBomba);

                if (bomba != null)
                {
                    // Verificar si hay suficiente cantidad de gasolina en la bomba
                    if (bomba.CantidadGalones >= cantidadAReducir)
                    {
                        bomba.CantidadGalones -= cantidadAReducir;
                        contexto.SaveChanges();
                        Console.WriteLine("Cantidad de gasolina reducida con éxito en la bomba.");
                    }
                    else
                    {
                        Console.WriteLine("No hay suficiente cantidad de gasolina en la bomba.");
                    }
                }
                else
                {
                    Console.WriteLine("No se encontró la bomba con el ID especificado.");
                }
            }
        }

    }
}
