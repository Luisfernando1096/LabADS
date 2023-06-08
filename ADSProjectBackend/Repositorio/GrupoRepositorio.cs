using ADSProjectBackend.DBContext;
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
        private ApplicationDbContext applicationDbContext;
        public GrupoRepositorio(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public bool EliminarGrupo(int idGrupo)
        {
            try
            {
                var item = applicationDbContext.Grupos.SingleOrDefault(x => x.idGrupo == idGrupo);
                applicationDbContext.Grupos.Remove(item);
                applicationDbContext.SaveChanges();
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
                applicationDbContext.Grupos.Add(grupo);
                applicationDbContext.SaveChanges();

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
                var item = applicationDbContext.Grupos.SingleOrDefault(x => x.idGrupo == idGrupo);
                applicationDbContext.Entry(item).CurrentValues.SetValues(grupo);
                applicationDbContext.SaveChanges();
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
                return applicationDbContext.Grupos.FirstOrDefault(x => x.idGrupo == idGrupo);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public List<Grupo> ObtenerListaGrupos()
        {
            return applicationDbContext.Grupos.ToList();
        }
    }
}
