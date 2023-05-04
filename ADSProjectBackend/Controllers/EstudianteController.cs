using System.Collections.Generic;
using ADSProjectBackend.Entidades;
using ADSProjectBackend.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ADSProjectBackend.Controllers
{
    [Route("ADSProject/estudiantes")] // [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteRepositorio estudianteRepositorio;

        public EstudianteController(IEstudianteRepositorio estudianteRepositorio)
        {
            this.estudianteRepositorio = estudianteRepositorio;
        }
        //Insertar estudiante
        [HttpPost("insertarEstudiante")]
        //El FromBody sirve para traer el objeto estudiante desde una variable body que esta en estudiante.service.ts
        public ActionResult<int> InsertarEstudiante([FromBody]Estudiante estudiante)
        {
            int valor = this.estudianteRepositorio.InsertarEstudiante(estudiante);
            if (valor > 0)
            {
                return Ok(valor);
            }
            else
            {
                return BadRequest("Error al insertar estudiante");
            }
        }
        //Obtener lista de estudiantes
        [HttpGet("obtenerListaEstudiantes")]
        public ActionResult<List<Estudiante>> ObtenerListaEstudiantes()
        {
            var lstEstudiante = this.estudianteRepositorio.ObtenerListaEstudiantes();
            if (lstEstudiante.Count > 0)
            {
                return Ok(lstEstudiante);
            }
            else
            {
                return BadRequest("Error al obtener lista de estudiantes");
            }
        }
        //Obtener lista de estudiantes por id
        [HttpGet("obtenerEstudiante/{idEstudiante}")]
        public ActionResult<Estudiante> ObtenerListaEstudiantesPorId(int idEstudiante)
        {
            var estudiante = this.estudianteRepositorio.ObtenerEstudiantePorId(idEstudiante);
            if (estudiante != null)
            {
                return Ok(estudiante);
            }
            else
            {
                return BadRequest("Error al obtener estudiante");
            }
        }
        //Eliminar estudiante
        [HttpDelete("eliminarEstudiante/{idEstudiante}")]
        public ActionResult<bool> EliminarEstudiante(int idEstudiante)
        {
            if(this.estudianteRepositorio.ObtenerEstudiantePorId(idEstudiante) != null)
            {
                return Ok(this.estudianteRepositorio.EliminarEstudiante(idEstudiante));
            }
            else
            {
                return BadRequest("Error al eliminar estudiante");
            }
        }
        //Actualizar estudiante
        [HttpPatch("actualizarEstudiante/{idEstudiante}")]
        public ActionResult<int> ModificarEstudiante(int idEstudiante, [FromBody]Estudiante estudiante)
        {
            int valor = this.estudianteRepositorio.ModificarEstudiante(idEstudiante, estudiante);
            if (valor > 0)
            {
                return Ok(valor);
            }
            else
            {
                return BadRequest("Error al actualizar estudiante");
            }
        }
    }
}
