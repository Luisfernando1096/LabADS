using ADSProjectBackend.DBContext;
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
        private ApplicationDbContext applicationDbContext;
        public MateriaRepositorio(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public bool EliminarMateria(int idMateria)
        {
            try
            {
                var item = applicationDbContext.Materias.SingleOrDefault(x => x.idMateria == idMateria);
                applicationDbContext.Materias.Remove(item);

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
                applicationDbContext.Materias.Add(materia);
                applicationDbContext.SaveChanges();

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
                var item = applicationDbContext.Materias.SingleOrDefault(x => x.idMateria == idMateria);
                applicationDbContext.Entry(item).CurrentValues.SetValues(materia);
                applicationDbContext.SaveChanges();
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
                return applicationDbContext.Materias.FirstOrDefault(x => x.idMateria == idMateria);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public List<Materia> ObtenerListaMaterias()
        {
            return applicationDbContext.Materias.ToList();
        }
    }
}
