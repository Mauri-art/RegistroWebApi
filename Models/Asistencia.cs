using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AcademicoApp.Models
{
    public class Asistencia
    {
        [Key]
        public int idAsistencia { get; set; }
        public int idMatricula { get; set; }
        public DateTime fecha { get; set; }
        public string estado { get; set; }
    }
}