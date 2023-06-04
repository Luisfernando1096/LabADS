using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProjectBackend.Entidades
{
    public class Carrera
    {
        public int idCarrera { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, 9999, ErrorMessage = "El campo {0} debe estar entre 1 y 9999")]
        public int codigoCarrera { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "El campo {0} debe estar entre 5 y 20 caracteres")]
        public String nombreCarrera { get; set; }
    }
}
