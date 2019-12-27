using Microsoft.EntityFrameworkCore;
using SapphireDb;
using SapphireDb_Example.Data.Models;

namespace SapphireDb_Example.Data
{
    public class TodoContext : SapphireDbContext
    {
        public TodoContext(DbContextOptions options, SapphireDatabaseNotifier notifier) : base(options, notifier)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Notice> Notices { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}