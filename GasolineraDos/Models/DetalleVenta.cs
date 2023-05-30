using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolineraDos.Models
{
    [Table("DETALLE_VENTA")]
    public class DetalleVenta
    {
        [Key]
        [Column("ID_DETALLE")]
        public int Id { get; set; }
        [ForeignKey("Bomba")]
        [Column("ID_BOMBA")]
        public int ID_BOMBA { get; set; }
        public virtual Bomba? Bomba { get; set; }

        [ForeignKey("Venta")]
        [Column("ID_VENTA")]
        public int VentaId { get; set; }
        public virtual Venta? Venta { get; set; }

        [Column("CANTIDAD")]
        public double Cantidad { get; set; }

        [Column("DESCUENTO")]
        public double Descuento { get; set; }

        [Column("PRECIO")]
        public double Precio { get; set; }

    }
}
