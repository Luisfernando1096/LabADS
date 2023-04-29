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
        public int InsertarProfesor([FromBody] Profesor profesor)
        {
            return profesorRepositorio.InsertarProfesor(profesor);
        }
        //Obtener lista
        [HttpGet("obtenerListaProfesores")]
        public List<Profesor> ObtenerListaProfesores()
        {
            return profesorRepositorio.ObtenerListaProfesores();
        }
        //Obtener lista por id
        [HttpGet("obtenerProfesor/{idProfesor}")]
        public Profesor ObtenerListaProfesoresPorId(int idProfesor)
        {
            return profesorRepositorio.ObtenerProfesorPorId(idProfesor);
        }
        //Eliminar
        [HttpDelete("eliminarProfesor/{idProfesor}")]
        public bool EliminarProfesor(int idProfesor)
        {
            return profesorRepositorio.EliminarProfesor(idProfesor);
        }
        //Actualizar
        [HttpPatch("actualizarProfesor/{idProfesor}")]
        public int ModificarProfesor(int idProfesor, [FromBody] Profesor profesor)
        {
            return profesorRepositorio.ModificarProfesor(idProfesor, profesor);
        }
    }
}