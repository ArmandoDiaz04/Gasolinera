using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolineraDos.Models
{
    [Table("BOMBA")]
    public class Bomba
    {
        [Key]
        [Column("ID_BOMBA")]
        public int ID_BOMBA { get; set; }

        [Column("CANTIDAD_GALON")]
        public float CantidadGalones { get; set; }

        [ForeignKey("Gasolina")]
        [Column("ID_GASOLINA")]
        public int GasolinaId { get; set; }
        public virtual Gasolina? Gasolina { get; set; }

        [ForeignKey("Proveedor")]
        [Column("ID_PROVEEDOR")]
        public int ProveedorId { get; set; }
        public virtual Proveedor Proveedor { get; set; }

        [Column("PRECIO")]
        public float? Precio { get; set; }
    }

}
