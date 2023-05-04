using ADSProjectBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProjectBackend.Repositorio
{
    public class MateriaRepositorio : IMateriaRepositorio
    {
        private List<Materia> lstMateria;
        public MateriaRepositorio()
        {
            lstMateria = new List<Materia>()
            {
                new Materia{idMateria = 1, nombreMateria = "Fisica" },
                new Materia{idMateria = 2, nombreMateria = "Programacion" }

            };
        }

        public bool EliminarMateria(int idMateria)
        {
            try
            {
                lstMateria.RemoveAt(lstMateria.FindIndex(tmp => tmp.idMateria == idMateria));

                return true;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public int InsertarMateria(Materia materia)
        {
            try
            {
                // Se valida que la lista contenga elementos
                if (lstMateria.Count > 0)
                {
                    // Se genera un id incremental a partir del ultimo elemento
                    materia.idMateria = lstMateria.Last().idMateria + 1;
                }
                else
                {
                    // En caso contrario colocarle 1
                    materia.idMateria = 1;
                }
                lstMateria.Add(materia);

                return materia.idMateria;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public int ModificarMateria(int idMateria, Materia materia)
        {
            try
            {
                lstMateria[lstMateria.FindIndex(tmp => tmp.idMateria == idMateria)] = materia;
                return materia.idMateria;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public Materia ObtenerMateriaPorId(int idMateria)
        {
            try
            {
                return lstMateria.FirstOrDefault(tmp => tmp.idMateria == idMateria);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public List<Materia> ObtenerListaMaterias()
        {
            return lstMateria;
        }
    }
}
