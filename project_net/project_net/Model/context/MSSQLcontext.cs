using Microsoft.EntityFrameworkCore;

namespace project_net.Model.context
{
    public class MSSQLcontext : DbContext
    {
        private ModelBuilder? modelBuilder;

        public MSSQLcontext(DbContextOptions<MSSQLcontext> options) : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; } = null!;
    }
}
