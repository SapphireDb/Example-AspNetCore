using Microsoft.EntityFrameworkCore;
using SapphireDb;
using SapphireDb_Example.Data.Chat.Models;

namespace SapphireDb_Example.Data.Chat
{
    public class ChatContext : SapphireDbContext
    {
        public ChatContext(DbContextOptions<ChatContext> options, SapphireDatabaseNotifier notifier) : base(options, notifier)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Message> Messages { get; set; }
    }
}