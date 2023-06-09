﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ADSProjectBackend.Entidades
{
    public class Profesor
    {
        public int idProfesor { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo valido")]
        public String emailProfesor { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El campo {0} debe estar entre 2 y 50 caracteres")]
        public String nombresProfesor { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El campo {0} debe estar entre 2 y 50 caracteres")]
        public String apellidosProfesor { get; set; }
    }
}
