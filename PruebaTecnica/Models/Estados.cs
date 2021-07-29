using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Models
{
    public class Estados
    {
        [Key]
        [Required(ErrorMessage = "Estado Obligatorio")]
        public string Estado { get; set; }
    }
}
