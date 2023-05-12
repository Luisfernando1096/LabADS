using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ADSProjectBackend.Entidades
{
    public class Materia
    {
        public int idMateria { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El campo {0} debe estar entre 2 y 50 caracteres")]
        public String nombreMateria { get; set; }
    }
}
