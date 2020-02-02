using Microsoft.EntityFrameworkCore;
using SapphireDb;
using SapphireDb_Example.Data.Basic.Models;

namespace SapphireDb_Example.Data.Basic
{
    public class BasicContext : SapphireDbContext
    {
        public BasicContext(DbContextOptions<BasicContext> options, SapphireDatabaseNotifier notifier) : base(options, notifier)
        {
        }

        public DbSet<Example> Examples { get; set; }
    }
}