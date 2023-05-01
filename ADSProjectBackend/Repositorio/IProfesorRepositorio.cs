using System.Collections.Generic;
using ADSProjectBackend.Entidades;

namespace ADSProjectBackend.Repositorio
{
    public interface IProfesorRepositorio
    {
        int InsertarProfesor(Profesor profesor);
        List<Profesor> ObtenerListaProfesores();
        Profesor ObtenerProfesorPorId(int idProfesor);
        int ModificarProfesor(int idProfesor, Profesor profesor);
        bool EliminarProfesor(int idProfesor);
    }
}
