﻿using Microsoft.EntityFrameworkCore;
using WordOnline.Models;

namespace WordOnline.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Documento> Documentos { get; set; }
}