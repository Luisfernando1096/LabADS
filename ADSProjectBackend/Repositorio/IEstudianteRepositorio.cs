using System.Collections.Generic;
using ADSProjectBackend.Entidades;

namespace ADSProjectBackend.Repositorio
{
    public interface IEstudianteRepositorio
    {
        int InsertarEstudiante(Estudiante estudiante);
        List<Estudiante> ObtenerListaEstudiantes();
        Estudiante ObtenerEstudiantePorId(int idEstudiante);
        int ModificarEstudiante(int idEstudiante, Estudiante estudiante);
        bool EliminarEstudiante(int idEstudiante);

    }
}
