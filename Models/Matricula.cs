using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AcademicoApp.Models
{
    public class Matricula
    {
        [Key]
        public int idMatricula { get; set; }
        public int idMateria { get; set; }
        public int idEstudiante { get; set; }
        public DateTime fechaMatricula { get; set; }
    }
}
