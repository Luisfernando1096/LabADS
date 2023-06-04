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
        [StringLength(20, MinimumLength = 5, ErrorMessage = "El campo {0} debe estar entre 5 y 20 caracteres")]
        public String nombreMateria { get; set; }
    }
}
