using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolineraDos.Models
{
    [Table("VENTA")]
    public class Venta
    {
        [Key]
        [Column("ID_VENTA")]
        public int IdVenta { get; set; }

        [Column("ID_EMPLEADO")]
        public int IdEmpleado { get; set; }

        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }

        [Column("PRECIO")]
        public double Precio { get; set; }

        [Column("IMPUENTO_F")]
        public double ImpuestoF { get; set; }

        [Column("IVA")]
        public double IVA { get; set; }

        [Column("TOTAL")]
        public double Total { get; set; }

        [ForeignKey("IdEmpleado")]
        public virtual Empleado Empleado { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Clientes Cliente { get; set; }

        public virtual DetalleVenta DetalleVenta { get; set; }
    }
}
