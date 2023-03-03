using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class ElementContext : DbContext
{
    public ElementContext(DbContextOptions<ElementContext> options)
        : base(options)
    {
    }

    public DbSet<Element> Elements { get; set; } = null!;
}