using System.Collections.Generic;
using System.Linq;
using ADSProjectBackend.DBContext;
using ADSProjectBackend.Entidades;

namespace ADSProjectBackend.Repositorio
{

    public class EstudianteRepositorio : IEstudianteRepositorio
    {
        private List<Estudiante> lstEstudiante;
        private ApplicationDbContext applicationDbContext;
        public EstudianteRepositorio(ApplicationDbContext applicationDbContext)
        {
            
            this.applicationDbContext = applicationDbContext;
        }

        public bool EliminarEstudiante(int idEstudiante)
        {
            try
            {
                /*lstEstudiante.RemoveAt(lstEstudiante.FindIndex(tmp => tmp.Id == idEstudiante));*/
                var item = applicationDbContext.Estudiantes.SingleOrDefault(x => x.Id == idEstudiante);
                applicationDbContext.Estudiantes.Remove(item);
                applicationDbContext.SaveChanges();
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
                /*// Se valida que la lista contenga elementos
                if(lstEstudiante.Count > 0)
                {
                    // Se genera un id incremental a partir del ultimo elemento
                    estudiante.Id = lstEstudiante.Last().Id + 1;
                } else
                {
                    // En caso contrario colocarle 1
                    estudiante.Id = 1;
                }
                lstEstudiante.Add(estudiante);*/

                applicationDbContext.Estudiantes.Add(estudiante);
                applicationDbContext.SaveChanges();
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
                /*lstEstudiante[lstEstudiante.FindIndex(tmp => tmp.Id == idEstudiante)] = estudiante;*/
                var item = applicationDbContext.Estudiantes.SingleOrDefault(x => x.Id == idEstudiante);
                applicationDbContext.Entry(item).CurrentValues.SetValues(estudiante);
                applicationDbContext.SaveChanges();
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
                /*return lstEstudiante.FirstOrDefault(tmp => tmp.Id == idEstudiante);*/
                return applicationDbContext.Estudiantes.FirstOrDefault(x => x.Id == idEstudiante);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public List<Estudiante> ObtenerListaEstudiantes()
        {
            /*return lstEstudiante;*/
            return applicationDbContext.Estudiantes.ToList();
        }
    }
}
