using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class PageContext : DbContext
{
    public PageContext(DbContextOptions<PageContext> options)
        : base(options)
    {
    }

    public DbSet<Page> Pages { get; set; } = null!;
}