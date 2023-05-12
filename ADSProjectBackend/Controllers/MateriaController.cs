using ADSProjectBackend.Entidades;
using ADSProjectBackend.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProjectBackend.Controllers
{
    [Route("ADSProject/materias")] // [Route("api/[controller]")]
    public class MateriaController : ControllerBase
    {
        private readonly IMateriaRepositorio materiaRepositorio;

        public MateriaController(IMateriaRepositorio materiaRepositorio)
        {
            this.materiaRepositorio = materiaRepositorio;
        }
        //Insertar
        [HttpPost("insertarMateria")]
        //El FromBody sirve para traer el objeto carrera desde una variable body que esta en carrera.service.ts
        public ActionResult<int> InsertarMateria([FromBody] Materia materia)
        {
            int valor = this.materiaRepositorio.InsertarMateria(materia);
            if (valor > 0)
            {
                return Ok(valor);
            }
            else
            {
                return BadRequest("Error al insertar materia");
            }
        }
        //Obtener lista
        [HttpGet("obtenerListaMaterias")]
        public ActionResult<List<Materia>> ObtenerListaMaterias()
        {
            var lstMateria = this.materiaRepositorio.ObtenerListaMaterias();
            if (lstMateria.Count > 0)
            {
                return Ok(lstMateria);
            }
            else
            {
                return BadRequest("Error al obtener lista de materias");
            }
        }
        //Obtener lista por id
        [HttpGet("obtenerMateria/{idMateria}")]
        public ActionResult<Materia> ObtenerListaMateriasPorId(int idMateria)
        {
            var materia = this.materiaRepositorio.ObtenerMateriaPorId(idMateria);
            if (materia != null)
            {
                return Ok(materia);
            }
            else
            {
                return BadRequest("Error al obtener materia");
            }
        }
        //Eliminar Carrera
        [HttpDelete("eliminarMateria/{idMateria}")]
        public ActionResult<bool> EliminarMateria(int idMateria)
        {
            if (this.materiaRepositorio.ObtenerMateriaPorId(idMateria) != null)
            {
                return Ok(this.materiaRepositorio.EliminarMateria(idMateria));
            }
            else
            {
                return BadRequest("Error al eliminar materia");
            }
        }
        //Actualizar Carrera
        [HttpPatch("actualizarMateria/{idMateria}")]
        public ActionResult<int> ModificarMateria(int idMateria, [FromBody] Materia materia)
        {
            int valor = this.materiaRepositorio.ModificarMateria(idMateria, materia);
            if (valor > 0)
            {
                return Ok(valor);
            }
            else
            {
                return BadRequest("Error al actualizar materia");
            }
        }
    }
}
