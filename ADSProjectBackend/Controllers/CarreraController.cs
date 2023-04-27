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
        public int InsertarCarrera([FromBody] Carrera carrera)
        {
            return carreraRepositorio.InsertarCarrera(carrera);
        }
        //Obtener lista de carreras
        [HttpGet("obtenerListaCarreras")]
        public List<Carrera> ObtenerListaCarreras()
        {
            return carreraRepositorio.ObtenerListaCarreras();
        }
        //Obtener lista de Carreras por id
        [HttpGet("obtenerCarrera/{idCarrera}")]
        public Carrera ObtenerListaCarrerasPorId(int idCarrera)
        {
            return carreraRepositorio.ObtenerCarreraPorId(idCarrera);
        }
        //Eliminar Carrera
        [HttpDelete("eliminarCarrera/{idCarrera}")]
        public bool EliminarCarrera(int idCarrera)
        {
            return carreraRepositorio.EliminarCarrera(idCarrera);
        }
        //Actualizar Carrera
        [HttpPatch("actualizarCarrera/{idCarrera}")]
        public int ModificarCarrera(int idCarrera, [FromBody] Carrera carrera)
        {
            return carreraRepositorio.ModificarCarrera(idCarrera, carrera);
        }
    }
}
