// File: Model.cs
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFStudenteApp;

public class StudenteContext : DbContext
{
    public DbSet<Studente> Studenti { get; set; } = null!;

    public string DbPath { get; }

    public StudenteContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "studente.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

public class Studente
{
    public int StudenteId { get; set; }
    public string Cognome { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty;
    public int Eta { get; set; }
    public string Citta { get; set; } = string.Empty;
}
