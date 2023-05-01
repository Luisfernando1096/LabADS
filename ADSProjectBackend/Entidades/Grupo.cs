using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProjectBackend.Entidades
{
    public class Grupo
    {
        public int idGrupo { get; set; }
        public int idCarrera { get; set; }
        public int idMateria { get; set; }
        public int idProfesor { get; set; }
        public int ciclo { get; set; }
        public int anio { get; set; }

    }
}
