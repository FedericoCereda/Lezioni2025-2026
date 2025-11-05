
using System;
using System.Linq;
using EFStudenteApp;

class Program
{
    static void Main()
    {
        using var db = new StudenteContext();

        Console.WriteLine($"Database path: {db.DbPath}");
        Console.WriteLine("Creazione database (se non esiste)...");

        db.Database.EnsureCreated();

        if (!db.Studenti.Any())
        {
            CaricaDati(db);
        }

        Console.WriteLine("\nTutti gli studenti nel database:");
        Stampa(db);

        Console.WriteLine("\nStudenti di Milano:");
        Studenti(db, "Milano");

    }

    static void CaricaDati(StudenteContext db)
    {
        Console.WriteLine("Caricamento dati...");
        var studenti = new[]
        {
            new Studente { Cognome="Rossi", Nome="Mario", Eta=20, Citta="Milano" },
            new Studente { Cognome="Bianchi", Nome="Luca", Eta=22, Citta="Roma" },
            new Studente { Cognome="Verdi", Nome="Anna", Eta=19, Citta="Milano" },
            new Studente { Cognome="Neri", Nome="Giulia", Eta=21, Citta="Torino" },
        };

        db.Studenti.AddRange(studenti);
        db.SaveChanges();
    }

    static void Stampa(StudenteContext db)
    {
        var studenti = db.Studenti.ToList();
        foreach (var s in studenti)
        {
            Console.WriteLine($"{s.StudenteId}: {s.Cognome} {s.Nome}, Età: {s.Eta}, Città: {s.Citta}");
        }
    }

    static void Studenti(StudenteContext db, string citta)
    {
        var studenti = db.Studenti
            .Where(s => s.Citta == citta)
            .ToList();

        if (studenti.Count == 0)
        {
            Console.WriteLine($"Nessuno studente trovato a {citta}");
            return;
        }

        foreach (var s in studenti)
        {
            Console.WriteLine($"{s.Cognome} {s.Nome}, Età: {s.Eta}");
        }
    }
    
}
