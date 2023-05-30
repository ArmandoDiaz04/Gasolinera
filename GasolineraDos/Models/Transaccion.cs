using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolineraDos.Models
{
    [Table("TRANSACCION")]
    public class Transaccion
    {
        [Key]
        [Column("ID_TRAN")]
        public int Id { get; set; }
               
        [Column("MONTO_IN")]
        public decimal MontoIn { get; set; }

        [Column("MONTO_OUT")]
        public decimal MontoOut { get; set; }

        [ForeignKey("Venta")]
        [Column("ID_VENTA")]
        public int? VentaId { get; set; }
        public virtual Venta Venta { get; set; }

        [Column("fecha_venta")]
        public DateTime FechaVenta { get; set; }
    }
}
