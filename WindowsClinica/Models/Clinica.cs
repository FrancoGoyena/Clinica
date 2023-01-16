using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsClinica
{
    [Table("Clinica")]
    public class Clinica
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar")]//Tipo de datos en SQL Server
        [StringLength(50)]//Long de la cadena
        [Required]//Es obligatorio. No acepta nulos
        public string Nombre { get; set; }   
        public DateTime FechaInicioActividades { get; set; }

    }
}
