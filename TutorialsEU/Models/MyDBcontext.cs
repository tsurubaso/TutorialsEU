using Microsoft.EntityFrameworkCore;

namespace TutorialsEU.Models
{
    public class MyDBcontext : DbContext
    {

        public DbSet<Person> People { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDB");
        }



    }
}
