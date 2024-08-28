using Microsoft.EntityFrameworkCore;
using MVC_Study.Models;

namespace MVC_Study.Context
{
    public class StudentContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=StudentDB;Trusted_Connection=True;Encrypt=False");

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
    }
}
