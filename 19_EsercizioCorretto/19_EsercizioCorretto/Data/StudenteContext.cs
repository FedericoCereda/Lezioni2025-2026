using System;
using _19_EsercizioCorretto.Model;
using Microsoft.EntityFrameworkCore;

namespace _19_EsercizioCorretto.Data;

public class StudenteContext:DbContext
{
    public DbSet<Studente> studentes { get; set; }
    public string DbPath { get; }
    public StudenteContext()
    {
        var folder = AppContext.BaseDirectory;
        var path = Path.Combine(folder, "../../../studente.db");
        DbPath = path;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
    
    
}   
