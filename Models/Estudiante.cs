using System;
using System.ComponentModel.DataAnnotations;

namespace AcademicoApp.Models
{
    public class Estudiante
    {
        [Key]
        public int idEstudiante { get; set; }
        public string codigoEstudiante { get; set; }
        public string nombreEstudiante { get; set; }
        public string apellidoEstudiante{ get; set; }


    }
}