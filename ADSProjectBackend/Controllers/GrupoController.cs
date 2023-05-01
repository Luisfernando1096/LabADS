using ADSProjectBackend.Entidades;
using ADSProjectBackend.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProjectBackend.Controllers
{
    [Route("ADSProject/grupos")] // [Route("api/[controller]")]
    public class GrupoController : ControllerBase
    {
        private readonly IGrupoRepositorio grupoRepositorio;

        public GrupoController(IGrupoRepositorio grupoRepositorio)
        {
            this.grupoRepositorio = grupoRepositorio;
        }
        //Insertar Grupo
        [HttpPost("insertarGrupo")]
        //El FromBody sirve para traer el objeto Grupo desde una variable body que esta en grupo.service.ts
        public int InsertarGrupo([FromBody] Grupo grupo)
        {
            return grupoRepositorio.InsertarGrupo(grupo);
        }
        //Obtener lista de Grupos
        [HttpGet("obtenerListaGrupos")]
        public List<Grupo> ObtenerListaGrupos()
        {
            return grupoRepositorio.ObtenerListaGrupos();
        }
        //Obtener lista de Grupos por id
        [HttpGet("obtenerGrupo/{idGrupo}")]
        public Grupo ObtenerListaGruposPorId(int idGrupo)
        {
            return grupoRepositorio.ObtenerGrupoPorId(idGrupo);
        }
        //Eliminar Grupo
        [HttpDelete("eliminarGrupo/{idGrupo}")]
        public bool EliminarGrupo(int idGrupo)
        {
            return grupoRepositorio.EliminarGrupo(idGrupo);
        }
        //Actualizar Grupo
        [HttpPatch("actualizarGrupo/{idGrupo}")]
        public int ModificarGrupo(int idGrupo, [FromBody] Grupo grupo)
        {
            return grupoRepositorio.ModificarGrupo(idGrupo, grupo);
        }
    }
}
