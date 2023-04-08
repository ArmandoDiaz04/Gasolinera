using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace GasolineraDos.Conexion
{
    internal class ContextBd : DbContext
    {
        public ContextBd() : base(GetOptions())
        {
        }

        private static DbContextOptions GetOptions()
        {
            var builder = new DbContextOptionsBuilder<ContextBd>();
            builder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=..\Data\gasolinera.mdf;Integrated Security=True");

            return builder.Options;
        }
        public DbSet<MyEntity> MyEntities { get; set; }

    }

    public class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }



}
