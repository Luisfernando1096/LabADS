using ADSProjectBackend.Entidades;
using ADSProjectBackend.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProjectBackend.Controllers
{
    [Route("ADSProject/carreras")] // [Route("api/[controller]")]

    [ApiController]
    public class CarreraController : ControllerBase
    {
        private readonly ICarreraRepositorio carreraRepositorio;

        public CarreraController(ICarreraRepositorio carreraRepositorio)
        {
            this.carreraRepositorio = carreraRepositorio;
        }
        //Insertar carrera
        [HttpPost("insertarCarrera")]
        //El FromBody sirve para traer el objeto carrera desde una variable body que esta en carrera.service.ts
        public ActionResult<int> InsertarCarrera([FromBody]Carrera carrera)
        {
            int valor = this.carreraRepositorio.InsertarCarrera(carrera);
            if (valor > 0)
            {
                return Ok(valor);
            }
            else
            {
                return BadRequest("Error al insertar carrera");
            }
        }
        //Obtener lista de carreras
        [HttpGet("obtenerListaCarreras")]
        public ActionResult<List<Carrera>> ObtenerListaCarreras()
        {
            var lstCarreras = this.carreraRepositorio.ObtenerListaCarreras();
            if (lstCarreras.Count > 0)
            {
                return Ok(lstCarreras);
            }
            else
            {
                return BadRequest("Error al obtener lista de carreras");
            }
        }
        //Obtener lista de Carreras por id
        [HttpGet("obtenerCarrera/{idCarrera}")]
        public ActionResult<Carrera> ObtenerListaCarrerasPorId(int idCarrera)
        {
            var carrera = this.carreraRepositorio.ObtenerCarreraPorId(idCarrera);
            if (carrera != null)
            {
                return Ok(carrera);
            }
            else
            {
                return BadRequest("Error al obtener carrera");
            }
        }
        //Eliminar Carrera
        [HttpDelete("eliminarCarrera/{idCarrera}")]
        public ActionResult<bool> EliminarCarrera(int idCarrera)
        {
            if (this.carreraRepositorio.ObtenerCarreraPorId(idCarrera) != null)
            {
                return Ok(this.carreraRepositorio.EliminarCarrera(idCarrera));
            }
            else
            {
                return BadRequest("Error al eliminar carrera");
            }
        }
        //Actualizar Carrera
        [HttpPatch("actualizarCarrera/{idCarrera}")]
        public ActionResult<int> ModificarCarrera(int idCarrera, [FromBody] Carrera carrera)
        {
            int valor = this.carreraRepositorio.ModificarCarrera(idCarrera, carrera);
            if (valor > 0)
            {
                return Ok(valor);
            }
            else
            {
                return BadRequest("Error al actualizar carrera");
            }
        }
    }
}
