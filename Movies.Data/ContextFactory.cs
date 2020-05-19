using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Movies.Data
{
    public class ContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
              var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
              optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=Movies;Integrated Security=true;MultipleActiveResultSets=True");

            return new DatabaseContext(optionsBuilder.Options);
         
        }
    }
}
