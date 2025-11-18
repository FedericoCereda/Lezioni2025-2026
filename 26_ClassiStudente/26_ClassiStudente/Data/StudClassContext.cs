using System;
using _26_ClassiStudente.Model;
using Microsoft.EntityFrameworkCore;

namespace _26_ClassiStudente.Data;

public class StudClassContext:DbContext
{
    public DbSet<Classe> Classe { get; set;}
    public DbSet<Studente> Studente { get; set;}
    string path;
    public StudClassContext()
    {
        var folder = AppContext.BaseDirectory;
        path = Path.Combine(folder, "../../../StudClasse.db");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={path}");
    }
}
