using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolineraDos.Models
{
    [Table("CLIENTE")]
    public class Clientes
    {
        [Key]
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        //[Column("DUI_CLIENTE")]
        //public string duiCLiente { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("APELLIDO")]
        public string? Apellido { get; set; }

        [Column("DIRECCION")]
        public string? Direccion { get; set; }

        [Column("TELEFONO")]
        public string? Telefono { get; set; }

        [Column("PUNTOS")]
        public int? Puntos { get; set; }
    }
}
