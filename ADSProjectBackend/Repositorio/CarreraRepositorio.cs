using ADSProjectBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProjectBackend.Repositorio
{
    public class CarreraRepositorio : ICarreraRepositorio
    {
        private List<Carrera> lstCarreras;
        public CarreraRepositorio()
        {
            lstCarreras = new List<Carrera>()
            {
                new Carrera
                {
                    idCarrera = 1,
                    codigoCarrera = 1,
                    nombreCarrera = "Sistemas"
                }
            };
        }

        public int InsertarCarrera(Carrera carrera)
        {
            try
            {
                if (lstCarreras.Count > 0)
                {
                    carrera.idCarrera = lstCarreras.Last().idCarrera + 1;
                }
                else
                {
                    carrera.idCarrera = 1;
                }
                lstCarreras.Add(carrera);
            }
            catch (Exception)
            {
                throw;
            }
            return carrera.idCarrera;
        }

        public List<Carrera> ObtenerListaDeCarreras()
        {
            return lstCarreras;
        }

        public Carrera ObtenerListaDeCarrerasPorId(int id)
        {
            try
            {
                return lstCarreras.FirstOrDefault(temp => temp.idCarrera == id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
