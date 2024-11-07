using Microsoft.EntityFrameworkCore;
using modeltest.Interfaces;
using modeltest.Models;

namespace modeltest.Database
{
    public class DatabaseContext:DbContext,Idbcontext
    {
        public DbSet<testmodel> Testmodels { get; set; }


        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
