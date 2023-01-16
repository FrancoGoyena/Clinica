using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsClinica
{
    [Table("Habitacion")]
    public class Habitacion
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        [Column(TypeName = "varchar")]//Tipo de datos en SQL Server
        [StringLength(10)]//Long de la cadena
        [Required]//Es obligatorio. No acepta nulos
        public string Estado { get; set; }
        [Column(TypeName = "varchar")]//Tipo de datos en SQL Server
        [StringLength(100)]//Long de la cadena
        public string Descripcion { get; set; }
    }
}
