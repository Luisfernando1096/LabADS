using System.ComponentModel.DataAnnotations;

namespace ADSProjectBackend.Entidades
{
    public class Grupo
    {
        [Key]
        public int idGrupo { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int idCarrera { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int idMateria { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int idProfesor { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, 2, ErrorMessage = "El campo {0} debe estar entre 1 y 2")]
        public int ciclo { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, 99999, ErrorMessage = "El campo {0} debe estar entre 1 y 99999")]
        public int anio { get; set; }

    }
}
