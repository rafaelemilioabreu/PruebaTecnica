using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Models
{
    public class Solicitud
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La persona id es Obligatorio")]
        [ForeignKey("Personas")]
        public Personas PersonaId { get; set; }

        [Required(ErrorMessage = "Estado Obligatorio")]

        public string Estado { get; set; }

        [Required(ErrorMessage = "Fecha de creacion Obligatoria")]

        public DateTime FechaCreacion { get; set; }

     

      

    }
}
