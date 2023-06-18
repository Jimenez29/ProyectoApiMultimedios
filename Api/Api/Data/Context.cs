using Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<User> user { get; set; }

        public DbSet<Auditoria> auditoria { get; set; }

        public DbSet<Error> error { get; set; }
    }
}
