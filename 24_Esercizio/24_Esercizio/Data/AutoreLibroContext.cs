using System;
using _24_Esercizio.Model;
using Microsoft.EntityFrameworkCore;

namespace _24_Esercizio.Data;

public class AutoreLibroContext:DbContext
{
    public string dbPath;
    public DbSet<Libro> Libri { get; set; }
    public DbSet<Autore> Autori { get; set; }

    public AutoreLibroContext()
    {
        var folder = AppContext.BaseDirectory;
        var path = Path.Combine(folder, "../../../AutoreLibro.db");
        dbPath = path;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={dbPath}");
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Libro>().HasKey(c=>new {c.LibroID,c.AutoreId});
    }
}
