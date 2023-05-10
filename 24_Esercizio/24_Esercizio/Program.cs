using System.Net;
using _24_Esercizio.Data;
using _24_Esercizio.Model;

namespace _24_Esercizio;

class Program
{
    static void Main(string[] args)
    {
        var db = new AutoreLibroContext();
        Crealiste();
        
    }
    static void StampaListe()
    {
        
    }
    static void Crealiste()
    {
         List<Autore> autori = new List<Autore>
        {
            new Autore { AutoreId = "A1", Nome = "Italo", Cognome = "Calvino", DataDiNascita = new DateOnly(1923, 10, 15) },
            new Autore { AutoreId = "A2", Nome = "Umberto", Cognome = "Eco", DataDiNascita = new DateOnly(1932, 1, 5) },
            new Autore { AutoreId = "A3", Nome = "Elena", Cognome = "Ferrante", DataDiNascita = new DateOnly(1943, 10, 5) },
            new Autore { AutoreId = "A4", Nome = "Andrea", Cognome = "Camilleri", DataDiNascita = new DateOnly(1925, 9, 6) }
        };

        // Lista Libri
        
        {
            new Libro { LibroID = "L1", Titolo = "Il barone rampante", Anno = 1957, Pagine = 320, AutoreId = "A1" },
            new Libro { LibroID = "L2", Titolo = "Le città invisibili", Anno = 1972, Pagine = 180, AutoreId = "A1" },
            new Libro { LibroID = "L3", Titolo = "Il nome della rosa", Anno = 1980, Pagine = 530, AutoreId = "A2" },
            new Libro { LibroID = "L4", Titolo = "L’isola del giorno prima", Anno = 1994, Pagine = 480, AutoreId = "A2" },
            new Libro { LibroID = "L5", Titolo = "L’amica geniale", Anno = 2011, Pagine = 400, AutoreId = "A3" },
            new Libro { LibroID = "L6", Titolo = "Storia del nuovo cognome", Anno = 2012, Pagine = 480, AutoreId = "A3" },
            new Libro { LibroID = "L7", Titolo = "La forma dell’acqua", Anno = 1994, Pagine = 280, AutoreId = "A4" },
            new Libro { LibroID = "L8", Titolo = "Il cane di terracotta", Anno = 1996, Pagine = 300, AutoreId = "A4" }
        };
        var db = new AutoreLibroContext();
        db.Add();
        db.Add(autori);
        db.SaveChanges();
       

    }
}
