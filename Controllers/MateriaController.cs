using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using AcademicoApp.Models;

namespace AcademicoApp.Controllers
{
    public class MateriaController:ControllerBase
    {
            private readonly AcademicoAppContext _contexto;

            public MateriaController(AcademicoAppContext  micontextoEnStartup)
            {
                this._contexto =micontextoEnStartup;
            }

            [HttpGet]
            [Route("api/listadoMateria")]
            public IEnumerable<Materia> getListadoMateria()
            {
                IEnumerable<Materia> listadoMateria = _contexto.Materia;
                return listadoMateria;    
            }

    }
}