using Microsoft.EntityFrameworkCore;

namespace RESTdr.Models
{
    public class RecordsDbContext : DbContext
    {
        public RecordsDbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }
        public DbSet<Record> Records { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
