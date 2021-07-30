using PruebaTecnica.Data;
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

        [Required(ErrorMessage = "PersonaId Obligatorio")]
        [ForeignKey("Personas")]

        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Estado Obligatorio")]

        public string Estado { get; set; }

        [Required(ErrorMessage = "Fecha de creacion Obligatoria")]

        public DateTime FechaCreacion { get; set; }

     

    }
}
