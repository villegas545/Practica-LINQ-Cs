using Microsoft.EntityFrameworkCore;

namespace EFAndLinqPractice_SchoolAPI.Models
{
    public class SchoolContext : DbContext
    {
        //es el contexto de la base de datos, donde dice los modelos, y se envia el que tipo de base de datos se va a usar
        //viene siendo como el archivo de configuracion
        public SchoolContext(DbContextOptions options):base(options){}
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}