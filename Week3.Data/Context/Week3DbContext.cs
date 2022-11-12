using Microsoft.EntityFrameworkCore;
using Week3.Domain.Entities;

namespace Week3.Data.Context
{
    public class Week3DbContext : DbContext
    {
        public Week3DbContext(DbContextOptions<Week3DbContext> options) : base(options) { }


        public DbSet<Product> Product { get; set; }
    }
}
