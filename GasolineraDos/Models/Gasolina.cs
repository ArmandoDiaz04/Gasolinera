using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolineraDos.Models
{
    [Table("GASOLINA")]
    public class Gasolina
    {
        [Key]
        [Column("ID_GASOLINA")]
        public int IdGasolina { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }
    }
}
