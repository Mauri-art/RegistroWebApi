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

        public DbSet<Estudiante> Estudiante {get;set;}
    }
}