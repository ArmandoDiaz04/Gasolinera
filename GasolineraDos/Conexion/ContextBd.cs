using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using GasolineraDos.Models;
using Microsoft.EntityFrameworkCore;

namespace GasolineraDos.Conexion
{
    public class ContextBd : DbContext
    {
        public ContextBd() : base(GetOptions())
        {
        }

        private static DbContextOptions GetOptions()
        {
            var builder = new DbContextOptionsBuilder<ContextBd>();

            //builder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juan\Documents\Mis archivos\Metodologias_Agiles\Gasolinera\GasolineraDos\data\gasolinera.mdf;Integrated Security=True;");
            builder.UseSqlServer(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\raulv\OneDrive\Escritorio\git\Gasolinera\GasolineraDos\data\gasolinera.mdf;Integrated Security=True;");
            return builder.Options;
        }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Gasolina> Gasolinas { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Bomba> Bombas { get; set; }
        public DbSet<DetalleVenta> DetallesVentas { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }

    }





}
