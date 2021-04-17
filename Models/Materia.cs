using System;
using System.ComponentModel.DataAnnotations;
namespace AcademicoApp.Models
{
    public class Materia
    {
        [Key]
        public int idMateria { get; set; }
        public string nombreMateria { get; set; }
    }
    
}