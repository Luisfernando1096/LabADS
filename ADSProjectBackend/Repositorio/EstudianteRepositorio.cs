using System.Collections.Generic;
using System.Linq;
using ADSProjectBackend.Entidades;

namespace ADSProjectBackend.Repositorio
{
    public class EstudianteRepositorio : IEstudianteRepositorio
    {
        private List<Estudiante> lstEstudiante;
        public EstudianteRepositorio()
        {
            lstEstudiante = new List<Estudiante>()
            {
                new Estudiante{Id = 1, Nombres = "Jose Anselmo",
                Apellidos = "Perez Martinez", Codigo = "CG21I04001",
                Email =  "CG21I04001@usonsonate.edu.sv"},
                new Estudiante{Id = 2, Nombres = "Jose Manuel",
                Apellidos = "Ruiz Martinez", Codigo = "CG21I04001",
                Email =  "RM21I04001@usonsonate.edu.sv"}
            };
        }

        public bool EliminarEstudiante(int idEstudiante)
        {
            try
            {
                lstEstudiante.RemoveAt(lstEstudiante.FindIndex(tmp => tmp.Id == idEstudiante));
                
                return true;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public int InsertarEstudiante(Estudiante estudiante)
        {
            try
            {
                // Se valida que la lista contenga elementos
                if(lstEstudiante.Count > 0)
                {
                    // Se genera un id incremental a partir del ultimo elemento
                    estudiante.Id = lstEstudiante.Last().Id + 1;
                } else
                {
                    // En caso contrario colocarle 1
                    estudiante.Id = 1;
                }
                lstEstudiante.Add(estudiante);

                return estudiante.Id;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public int ModificarEstudiante(int idEstudiante, Estudiante estudiante)
        {
            try
            {
                lstEstudiante[lstEstudiante.FindIndex(tmp => tmp.Id == idEstudiante)] = estudiante;
                return estudiante.Id;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public Estudiante ObtenerEstudiantePorId(int idEstudiante)
        {
            try
            {
                return lstEstudiante.FirstOrDefault(tmp => tmp.Id == idEstudiante);
                }
            catch (System.Exception)
            {

                throw;
            }
        }

        public List<Estudiante> ObtenerListaEstudiantes()
        {
            return lstEstudiante;
        }
    }
}
