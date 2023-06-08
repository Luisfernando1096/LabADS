using ADSProjectBackend.DBContext;
using ADSProjectBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProjectBackend.Repositorio
{
    public class ProfesorRepositorio : IProfesorRepositorio
    {
        private List<Profesor> lstProfesor;
        private ApplicationDbContext applicationDbContext;
        public ProfesorRepositorio(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public bool EliminarProfesor(int idProfesor)
        {
            try
            {
                var item = applicationDbContext.Profesores.SingleOrDefault(x => x.idProfesor == idProfesor);
                applicationDbContext.Profesores.Remove(item);
                applicationDbContext.SaveChanges();

                return true;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public int InsertarProfesor(Profesor profesor)
        {
            try
            {
                applicationDbContext.Profesores.Add(profesor);
                applicationDbContext.SaveChanges();

                return profesor.idProfesor;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public int ModificarProfesor(int idProfesor, Profesor profesor)
        {
            try
            {
                var item = applicationDbContext.Profesores.SingleOrDefault(x => x.idProfesor == idProfesor);
                applicationDbContext.Entry(item).CurrentValues.SetValues(profesor);
                applicationDbContext.SaveChanges();
                return profesor.idProfesor;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public Profesor ObtenerProfesorPorId(int idProfesor)
        {
            try
            {
                return applicationDbContext.Profesores.FirstOrDefault(x => x.idProfesor == idProfesor);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public List<Profesor> ObtenerListaProfesores()
        {
            return applicationDbContext.Profesores.ToList();
        }
    }
}

