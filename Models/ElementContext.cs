using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class PageContext : DbContext
{
    public PageContext(DbContextOptions<PageContext> options)
        : base(options)
    {
    }

    public DbSet<Page> Elements { get; set; } = null!;
}