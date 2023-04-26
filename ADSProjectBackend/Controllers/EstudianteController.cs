using System.Collections.Generic;
using ADSProjectBackend.Entidades;
using ADSProjectBackend.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ADSProjectBackend.Controllers
{
    [Route("ADSProject/estudiantes")] // [Route("api/[controller]")]
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
        public int InsertarEstudiante([FromBody]Estudiante estudiante)
        {
            return estudianteRepositorio.InsertarEstudiante(estudiante);
        }
        //Obtener lista de estudiantes
        [HttpGet("obtenerListaEstudiantes")]
        public List<Estudiante> ObtenerListaEstudiantes()
        {
            return estudianteRepositorio.ObtenerListaEstudiantes();
        }
        //Obtener lista de estudiantes por id
        [HttpGet("obtenerEstudiante/{idEstudiante}")]
        public Estudiante ObtenerListaEstudiantesPorId(int idEstudiante)
        {
            return estudianteRepositorio.ObtenerEstudiantePorId(idEstudiante);
        }
        //Eliminar estudiante
        [HttpDelete("eliminarEstudiante/{idEstudiante}")]
        public bool EliminarEstudiante(int idEstudiante)
        {
            return estudianteRepositorio.EliminarEstudiante(idEstudiante);
        }
        //Actualizar estudiante
        [HttpPatch("actualizarEstudiante/{idEstudiante}")]
        public int ModificarEstudiante(int idEstudiante, [FromBody]Estudiante estudiante)
        {
            return estudianteRepositorio.ModificarEstudiante(idEstudiante, estudiante);
        }
    }
}
