using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ToDoSolution.Models;

namespace ToDoSolution.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) { }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Todo> todos { get; set; }
        public DbSet<Category> categories { get; set; }

    }
}
