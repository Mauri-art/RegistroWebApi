using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AcademicoApp.Models;

namespace AcademicoApp.Controllers
{
    [ApiController]
    public class EstudianteController :ControllerBase
    {
        private readonly AcademicoAppContext _contexto;

        public EstudianteController(AcademicoAppContext micontextoEnStartup) {
            this._contexto = micontextoEnStartup;
        }

        [HttpGet]
        [Route("api/listadoEstudiante")]
        public IEnumerable<Estudiante> getListadoEstudiante()
        {                   
            IEnumerable<Estudiante> listadoEstudiante = _contexto.Estudiante;
            return listadoEstudiante;            
        }

    }
}