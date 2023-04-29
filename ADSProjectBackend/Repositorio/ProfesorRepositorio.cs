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
        public ProfesorRepositorio()
        {
            lstProfesor = new List<Profesor>()
            {
                new Profesor{idProfesor = 1, emailProfesor = "JoseAnselmo@gmail.com", nombresProfesor = "Jose Anselmo", apellidosProfesor = "Jose Anselmo"},
                new Profesor{idProfesor = 2, emailProfesor = "JoseAnselmo@gmail.com", nombresProfesor = "Jose", apellidosProfesor = "Jose Anselmo"}

            };
        }

        public bool EliminarProfesor(int idProfesor)
        {
            try
            {
                lstProfesor.RemoveAt(lstProfesor.FindIndex(tmp => tmp.idProfesor == idProfesor));

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
                // Se valida que la lista contenga elementos
                if (lstProfesor.Count > 0)
                {
                    // Se genera un id incremental a partir del ultimo elemento
                    profesor.idProfesor = lstProfesor.Last().idProfesor + 1;
                }
                else
                {
                    // En caso contrario colocarle 1
                    profesor.idProfesor = 1;
                }
                lstProfesor.Add(profesor);

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
                lstProfesor[lstProfesor.FindIndex(tmp => tmp.idProfesor == idProfesor)] = profesor;
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
                return lstProfesor.FirstOrDefault(tmp => tmp.idProfesor == idProfesor);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public List<Profesor> ObtenerListaProfesores()
        {
            return lstProfesor;
        }
    }
}

