using ADSProjectBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProjectBackend.Repositorio
{
    public interface IMateriaRepositorio
    {
        int InsertarMateria(Materia materia);
        List<Materia> ObtenerListaMaterias();
        Materia ObtenerMateriaPorId(int idMateria);
        int ModificarMateria(int idMateria, Materia materia);
        bool EliminarMateria(int idMateria);
    }
}
