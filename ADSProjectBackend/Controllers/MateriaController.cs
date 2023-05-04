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
        public int InsertarMateria([FromBody] Materia materia)
        {
            return materiaRepositorio.InsertarMateria(materia);
        }
        //Obtener lista
        [HttpGet("obtenerListaMaterias")]
        public List<Materia> ObtenerListaMaterias()
        {
            return materiaRepositorio.ObtenerListaMaterias();
        }
        //Obtener lista por id
        [HttpGet("obtenerMateria/{idMateria}")]
        public Materia ObtenerListaMateriasPorId(int idMateria)
        {
            return materiaRepositorio.ObtenerMateriaPorId(idMateria);
        }
        //Eliminar Carrera
        [HttpDelete("eliminarMateria/{idMateria}")]
        public bool EliminarMateria(int idMateria)
        {
            return materiaRepositorio.EliminarMateria(idMateria);
        }
        //Actualizar Carrera
        [HttpPatch("actualizarMateria/{idMateria}")]
        public int ModificarMateria(int idMateria, [FromBody] Materia materia)
        {
            return materiaRepositorio.ModificarMateria(idMateria, materia);
        }
    }
}
