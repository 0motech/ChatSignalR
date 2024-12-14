using ChatSignalR.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatSignalR.Context
{
    public class ChatDbContext : DbContext
    {
        public ChatDbContext(DbContextOptions<ChatDbContext> options) :base(options) 
        {
            
        }

        public DbSet<Message> Messages { get; set; }
    }
}
