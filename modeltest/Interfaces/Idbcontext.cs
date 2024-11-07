using Microsoft.EntityFrameworkCore;
using modeltest.Models;

namespace modeltest.Interfaces
{
    public interface Idbcontext
    {
        DbSet<testmodel> Testmodels { get; set; }

        int SaveChanges();
    }
}
