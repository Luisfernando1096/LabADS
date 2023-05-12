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

    [ApiController]
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
        public ActionResult<int> InsertarGrupo([FromBody] Grupo grupo)
        {
            int valor = this.grupoRepositorio.InsertarGrupo(grupo);
            if (valor > 0)
            {
                return Ok(valor);
            }
            else
            {
                return BadRequest("Error al insertar grupo");
            }
        }
        //Obtener lista de Grupos
        [HttpGet("obtenerListaGrupos")]
        public ActionResult<List<Grupo>> ObtenerListaGrupos()
        {
            var lstGrupos = this.grupoRepositorio.ObtenerListaGrupos();
            if (lstGrupos.Count > 0)
            {
                return Ok(lstGrupos);
            }
            else
            {
                return BadRequest("Error al obtener lista de grupos");
            }
        }
        //Obtener lista de Grupos por id
        [HttpGet("obtenerGrupo/{idGrupo}")]
        public ActionResult<Grupo>  ObtenerListaGruposPorId(int idGrupo)
        {
            var grupo = this.grupoRepositorio.ObtenerGrupoPorId(idGrupo);
            if (grupo != null)
            {
                return Ok(grupo);
            }
            else
            {
                return BadRequest("Error al obtener grupo");
            }
        }
        //Eliminar Grupo
        [HttpDelete("eliminarGrupo/{idGrupo}")]
        public ActionResult<bool> EliminarGrupo(int idGrupo)
        {
            if (this.grupoRepositorio.ObtenerGrupoPorId(idGrupo) != null)
            {
                return Ok(this.grupoRepositorio.EliminarGrupo(idGrupo));
            }
            else
            {
                return BadRequest("Error al eliminar grupo");
            }
        }
        //Actualizar Grupo
        [HttpPatch("actualizarGrupo/{idGrupo}")]
        public ActionResult<int> ModificarGrupo(int idGrupo, [FromBody] Grupo grupo)
        {
            int valor = this.grupoRepositorio.ModificarGrupo(idGrupo, grupo);
            if (valor > 0)
            {
                return Ok(valor);
            }
            else
            {
                return BadRequest("Error al actualizar grupo");
            }
        }
    }
}
