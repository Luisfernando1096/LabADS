using ADSProjectBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProjectBackend.Repositorio
{
    public interface IGrupoRepositorio
    {
        int InsertarGrupo(Grupo grupo);
        List<Grupo> ObtenerListaGrupos();
        Grupo ObtenerGrupoPorId(int idGrupo);
        int ModificarGrupo(int idGrupo, Grupo grupo);
        bool EliminarGrupo(int idGrupo);
    }
}
