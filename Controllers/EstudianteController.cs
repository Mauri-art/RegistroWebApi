using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
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

        [HttpGet]
        [Route("api/Estudiante/{_codigoEstudiante}")]
        public Estudiante getEstudiante(string _codigoEstudiante)
        {                   
            Estudiante Estudiante = (from est in _contexto.Estudiante
                                where est.codigoEstudiante == _codigoEstudiante
                                select est).First(); 
            return Estudiante;            
        }

        [HttpPost]
        [Route("api/guardarEstudiante/")]
        public Estudiante AgregarEstudiante(Estudiante _nuevoEstudiante){
            _contexto.Estudiante.Add(_nuevoEstudiante);
            _contexto.SaveChanges();
            return _nuevoEstudiante;
        }

    }
}