using System;
using Microsoft.EntityFrameworkCore;

namespace _20_Esercizio.Data;

public class FattureClientiContext:DbContext
{
    public DbSet<Fattura> Fatture { get; set; } = null!; 
    public DbSet<Cliente> Clienti { get; set; } = null!; 
    public string DbPath { get; }

    public FattureClientiContext()
    {
        var folder = AppContext.BaseDirectory;
        var path = Path.Combine(folder, "../../../Fatture.db");
        DbPath = path;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}

