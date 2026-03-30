using Microsoft.EntityFrameworkCore;

namespace MentorApp.Data;

public class MentorAppDbContext:DbContext
{
    public MentorAppDbContext(DbContextOptions<MentorAppDbContext> options) : base(options)
    {
        
    }
    
}