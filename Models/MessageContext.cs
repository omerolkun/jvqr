using Microsoft.EntityFrameworkCore;

namespace junkveganqr.Models;

public class MessageContext: DbContext
{
    public MessageContext(DbContextOptions<MessageContext> options)
        : base(options)
    {
    }

    public DbSet<Message> Messages{ get; set; } = null!;
}
