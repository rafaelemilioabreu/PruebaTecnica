using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Models
{
    public class Personas
    {
     



        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Apellido Obligatorio")]

        public string Apellido { get; set; }

        [Required(ErrorMessage = "Fecha de nacimiento Obligatoria")]

        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Pasaporte Obligatorio")]

        public string Pasaporte { get; set; }

        [Required(ErrorMessage = "Direccion Obligatorio")]

        public string Direccion { get; set; }

        [Required(ErrorMessage = "Sexo Obligatorio")]

        public string Sexo { get; set; }
    }
}
