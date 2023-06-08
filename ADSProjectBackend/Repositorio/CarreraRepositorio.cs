using ADSProjectBackend.DBContext;
using ADSProjectBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProjectBackend.Repositorio
{
    public class CarreraRepositorio : ICarreraRepositorio
    {
        private List<Carrera> lstCarrera;
        private ApplicationDbContext applicationDbContext;
        public CarreraRepositorio(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public bool EliminarCarrera(int idCarrera)
        {
            try
            {
                var item = applicationDbContext.Carreras.SingleOrDefault(x => x.idCarrera == idCarrera);
                applicationDbContext.Carreras.Remove(item);
                applicationDbContext.SaveChanges();

                return true;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public int InsertarCarrera(Carrera carrera)
        {
            try
            {
                applicationDbContext.Carreras.Add(carrera);
                applicationDbContext.SaveChanges();

                return carrera.idCarrera;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public int ModificarCarrera(int idCarrera, Carrera carrera)
        {
            try
            {
                var item = applicationDbContext.Carreras.SingleOrDefault(x => x.idCarrera == idCarrera);
                applicationDbContext.Entry(item).CurrentValues.SetValues(carrera);
                applicationDbContext.SaveChanges();
                return carrera.idCarrera;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public Carrera ObtenerCarreraPorId(int idCarrera)
        {
            try
            {
                return applicationDbContext.Carreras.FirstOrDefault(x => x.idCarrera == idCarrera);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public List<Carrera> ObtenerListaCarreras()
        {
            return applicationDbContext.Carreras.ToList();
        }
    }
}
