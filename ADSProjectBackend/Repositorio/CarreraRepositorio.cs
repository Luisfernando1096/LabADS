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
        public CarreraRepositorio()
        {
            lstCarrera = new List<Carrera>()
            {
                new Carrera{idCarrera = 1, nombreCarrera = "Jose Anselmo", codigoCarrera = 1 }
                
            };
        }

        public bool EliminarCarrera(int idCarrera)
        {
            try
            {
                lstCarrera.RemoveAt(lstCarrera.FindIndex(tmp => tmp.idCarrera == idCarrera));

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
                // Se valida que la lista contenga elementos
                if (lstCarrera.Count > 0)
                {
                    // Se genera un id incremental a partir del ultimo elemento
                    carrera.idCarrera = lstCarrera.Last().idCarrera + 1;
                }
                else
                {
                    // En caso contrario colocarle 1
                    carrera.idCarrera = 1;
                }
                lstCarrera.Add(carrera);

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
                lstCarrera[lstCarrera.FindIndex(tmp => tmp.idCarrera == idCarrera)] = carrera;
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
                return lstCarrera.FirstOrDefault(tmp => tmp.idCarrera == idCarrera);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public List<Carrera> ObtenerListaCarreras()
        {
            return lstCarrera;
        }
    }
}
