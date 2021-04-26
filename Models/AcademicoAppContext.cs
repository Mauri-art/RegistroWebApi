using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace AcademicoApp.Models
{
    public  class AcademicoAppContext : DbContext
    {
        public AcademicoAppContext(DbContextOptions<AcademicoAppContext> options):base(options)
        {

        }

        //Tabla Estudiantes
        public DbSet<Estudiante> Estudiante {get;set;}

        //Tabla Materia
        public DbSet<Materia> Materia {get;set;}

        //Tabla Asistencia
        public DbSet<Asistencia> Asistencia {get;set;}
        //Tabla Matricula 
        public DbSet<Matricula> Matricula {get;set;}
        
    }
}