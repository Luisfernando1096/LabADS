using ADSProjectBackend.Entidades;
using ADSProjectBackend.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProjectBackend.Controllers
{
    [Route("ADSProject/carreras")]
    public class CarreraController : ControllerBase
    {
        private readonly ICarreraRepositorio carreraRepositorio;

        public CarreraController(ICarreraRepositorio carreraRepositorio)
        {
            this.carreraRepositorio = carreraRepositorio;
        }
        [HttpPost("insertarCarrera")]
        public int InsertarCarrera(Carrera carrera)
        {
            return carreraRepositorio.InsertarCarrera(carrera);
        }
        [HttpGet("obtenerListaCarreras")]
        public List<Carrera> ObtenerCarreras()
        {
            return carreraRepositorio.ObtenerListaDeCarreras();
        }
    }
}
