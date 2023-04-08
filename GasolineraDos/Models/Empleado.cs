using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolineraDos.Models
{
    [Table("EMPLEADO")]
    public class Empleado
    {
        [Key]
        [Column("ID_EMPLEADO")]
        public int IdEmpleado { get; set; }

        [Column("DUI_EMPLEADO")]
        public string Dui { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("CARGO")]
        public string Cargo { get; set; }

        [Column("TELEFONO")]
        public string? Telefono { get; set; }

        [Column("CONTRASENIA")]
        public byte[] Contrasenia { get; set; }
       
    }

}
