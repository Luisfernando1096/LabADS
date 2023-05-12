using ADSProjectBackend.Entidades;
using ADSProjectBackend.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProjectBackend.Controllers
{
    [Route("ADSProject/profesores")] // [Route("api/[controller]")]
    public class ProfesorController : ControllerBase
    {
        private readonly IProfesorRepositorio profesorRepositorio;

        public ProfesorController(IProfesorRepositorio profesorRepositorio)
        {
            this.profesorRepositorio = profesorRepositorio;
        }
        //Insertar
        [HttpPost("insertarProfesor")]
        //El FromBody sirve para traer el objeto carrera desde una variable body que esta en carrera.service.ts
        public ActionResult<int> InsertarProfesor([FromBody] Profesor profesor)
        {
            int valor = this.profesorRepositorio.InsertarProfesor(profesor);
            if (valor > 0)
            {
                return Ok(valor);
            }
            else
            {
                return BadRequest("Error al insertar profesor");
            }
        }
        //Obtener lista
        [HttpGet("obtenerListaProfesores")]
        public ActionResult<List<Profesor>> ObtenerListaProfesores()
        {
            var lstProfesor = this.profesorRepositorio.ObtenerListaProfesores();
            if (lstProfesor.Count > 0)
            {
                return Ok(lstProfesor);
            }
            else
            {
                return BadRequest("Error al obtener lista de profesor");
            }
        }
        //Obtener lista por id
        [HttpGet("obtenerProfesor/{idProfesor}")]
        public ActionResult<Profesor> ObtenerListaProfesoresPorId(int idProfesor)
        {
            var profesor = this.profesorRepositorio.ObtenerProfesorPorId(idProfesor);
            if (profesor != null)
            {
                return Ok(profesor);
            }
            else
            {
                return BadRequest("Error al obtener profesor");
            }
        }
        //Eliminar
        [HttpDelete("eliminarProfesor/{idProfesor}")]
        public ActionResult<bool> EliminarProfesor(int idProfesor)
        {
            if (this.profesorRepositorio.ObtenerProfesorPorId(idProfesor) != null)
            {
                return Ok(this.profesorRepositorio.EliminarProfesor(idProfesor));
            }
            else
            {
                return BadRequest("Error al eliminar estudiante");
            }
        }
        //Actualizar
        [HttpPatch("actualizarProfesor/{idProfesor}")]
        public ActionResult<int> ModificarProfesor(int idProfesor, [FromBody] Profesor profesor)
        {
            int valor = this.profesorRepositorio.ModificarProfesor(idProfesor, profesor);
            if (valor > 0)
            {
                return Ok(valor);
            }
            else
            {
                return BadRequest("Error al actualizar profesor");
            }
        }
    }
}