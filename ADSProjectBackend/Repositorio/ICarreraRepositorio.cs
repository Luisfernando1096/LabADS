using ADSProjectBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProjectBackend.Repositorio
{
    public interface ICarreraRepositorio
    {
        int InsertarCarrera(Carrera carrera);
        List<Carrera> ObtenerListaCarreras();
        Carrera ObtenerCarreraPorId(int idCarrera);
        int ModificarCarrera(int idCarrera, Carrera carrera);
        bool EliminarCarrera(int idCarrera);

    }
}
