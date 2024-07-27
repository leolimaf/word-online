using Microsoft.EntityFrameworkCore;
using OnlineTextEditor.Models;

namespace OnlineTextEditor.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Documento> Documentos { get; set; }
}