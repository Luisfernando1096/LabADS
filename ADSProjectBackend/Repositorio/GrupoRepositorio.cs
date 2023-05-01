using ADSProjectBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProjectBackend.Repositorio
{
    public class GrupoRepositorio : IGrupoRepositorio
    {
        private List<Grupo> lstGrupo;
        public GrupoRepositorio()
        {
            lstGrupo = new List<Grupo>()
            {
                new Grupo{idGrupo = 1, idMateria = 1, idProfesor = 1, idCarrera = 2, anio = 2023, ciclo = 01}

            };
        }
        public bool EliminarGrupo(int idGrupo)
        {
            try
            {
                lstGrupo.RemoveAt(lstGrupo.FindIndex(tmp => tmp.idGrupo == idGrupo));

                return true;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public int InsertarGrupo(Grupo grupo)
        {
            try
            {
                // Se valida que la lista contenga elementos
                if (lstGrupo.Count > 0)
                {
                    // Se genera un id incremental a partir del ultimo elemento
                    grupo.idGrupo = lstGrupo.Last().idGrupo + 1;
                }
                else
                {
                    // En caso contrario colocarle 1
                    grupo.idGrupo = 1;
                }
                lstGrupo.Add(grupo);

                return grupo.idGrupo;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public int ModificarGrupo(int idGrupo, Grupo grupo)
        {
            try
            {
                lstGrupo[lstGrupo.FindIndex(tmp => tmp.idGrupo == idGrupo)] = grupo;
                return grupo.idGrupo;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public Grupo ObtenerGrupoPorId(int idGrupo)
        {
            try
            {
                return lstGrupo.FirstOrDefault(tmp => tmp.idGrupo == idGrupo);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public List<Grupo> ObtenerListaGrupos()
        {
            return lstGrupo;
        }
    }
}
