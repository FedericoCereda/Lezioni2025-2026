using System.Globalization;
using System.Net;

namespace _17_EsercizioLinq;

class Program
{
    static List<Autore> ListaAutori;
    static List<Romanzo> ListaRomanzi;
    static List<Personaggio> ListaPersonaggi;

    static void Main(string[] args)
    {

        InizializeList();
        /*Console.WriteLine($"Inserisci Nazionalità:");
        InputNazionalità(Console.ReadLine());
        Console.WriteLine("Inserisci nome:");
        string Nome = Console.ReadLine();
        Console.WriteLine("Inserisci cognome:\n");
        string Cognome = Console.ReadLine();
        StampaRomanzi(Nome, Cognome);
        Console.WriteLine($"Inserisci una nazionalità:\n");
        StampaNazionalità(Console.ReadLine());*/
        Console.WriteLine($"Inserisci una nazionalità:\n");
        ContaNazionalità(Console.ReadLine());
        Console.WriteLine($"Inserisci una nazionalità:\n");
        StampaPersonaggi(Console.ReadLine());
        Console.ReadKey();
    }
    static List<Personaggio> personaggiConNAzionalità (string nazionalità)
    {
        List<Autore> NListaAutori = ListaAutori.Where(a => a.Nazionalita == nazionalità).ToList();
        List<Personaggio> personaggis = new List<Personaggio>();

        return personaggis;
    }
    static void StampaPersonaggi (string nazionalità)
    {
        var Olistaautori = ListaAutori.Where(a => a.Nazionalita == nazionalità).Join(ListaRomanzi,
        a => a.AutoreId,
        r => r.AutoreID,
        (a, r) => new
        {
            a.Nazionalita,
            r.RomanzoID

        }).Join(ListaPersonaggi, r => r.RomanzoID, p => p.RomanzoId,
        (r, p) => new
        {
            p.Nome
        });
        foreach (var item in Olistaautori)
        {
            Console.WriteLine(item.Nome);
            
        }
    
        
    }
    static void ContaNazionalità(string Nazionalita)
    {
        var TListaAutori = ListaAutori.Where(a => a.Nazionalita == Nazionalita).Join(ListaRomanzi,
        a => a.AutoreId,
        r => r.AutoreID,
        (a, r) => new
        {
            a.Nazionalita,
            a.Nome
        });
        int cont=0;
        foreach (var item in TListaAutori)
        {
            cont++;
        }System.Console.WriteLine(cont);
 
    }
    static void StampaNazionalità (string Nazionalita)
    {
        var TEListaAutori = ListaAutori.Where(a => a.Nazionalita == Nazionalita).Join
        (ListaRomanzi,
        a => a.AutoreId,
        r => r.AutoreID,
        (a, r) => new
        {
            r.Titolo,
            a.Nome,
            a.Cognome
        });
        foreach (var item in TEListaAutori)
        {
            Console.WriteLine(item.Titolo+item.Nome+ item.Cognome);
        }
        
    }
    static void StampaRomanzi(string AutNom, string AutCog)
    {
        var TEMPListaAutori = ListaAutori.Where(a => a.Nome == AutNom && a.Cognome == AutCog).Join
        (ListaRomanzi,
        a => a.AutoreId,
        r => r.AutoreID,
        (a, r) => new
        {
            Romanzo = r
        }
        );
        foreach (var item in TEMPListaAutori)
        {
            System.Console.WriteLine(item.Romanzo.Titolo);
        }
        
    }
    static void InputNazionalità(string Nazionalita)
    {
        List <Autore> TMListaAutori = ListaAutori.OrderBy(a => a.Nazionalita).ToList();
        foreach (var Autore in TMListaAutori)
        {
            if (Autore.Nazionalita== Nazionalita)
            {
                System.Console.WriteLine("Nome: "+Autore.Nome+"; Cognome: "+Autore.Cognome);
            }
        }
    }
    static void InizializeList()
    {
        ListaAutori = new List<Autore>
        {
            new Autore { AutoreId = 1, Cognome = "Levi", Nome = "Primo", Nazionalita ="Italiana" },
            new Autore { AutoreId = 2, Cognome = "Eco", Nome = "Umberto", Nazionalita = "Italiana" },
            new Autore { AutoreId = 3, Cognome = "Calvino", Nome = "Italo", Nazionalita = "Italiana" },
            new Autore { AutoreId = 4, Cognome = "Moravia", Nome = "Alberto", Nazionalita = "Italiana" },
            new Autore { AutoreId = 5, Cognome = "Pirandello", Nome = "Luigi", Nazionalita = "Italiana" }
        };
        ListaRomanzi = new List<Romanzo>{
            new Romanzo {RomanzoID = 1, Titolo = "Se questo è un uomo",AnnoPublicazione = 1947, AutoreID =1},
            new Romanzo {RomanzoID = 2, Titolo = "Il nome della rosa",AnnoPublicazione = 1980, AutoreID = 2},
            new Romanzo {RomanzoID = 3, Titolo = "Il barone rampante",AnnoPublicazione = 1957, AutoreID = 3 },
            new Romanzo { RomanzoID = 4, Titolo = "Gli indifferenti", AnnoPublicazione= 1929, AutoreID = 4 },
            new Romanzo { RomanzoID = 5, Titolo = "Uno, nessuno e centomila",AnnoPublicazione = 1926, AutoreID = 5 },
            new Romanzo { RomanzoID = 6, Titolo = "La giornata di uno scrutatore",AnnoPublicazione = 1963, AutoreID = 3 },
            new Romanzo { RomanzoID = 7, Titolo = "La coscienza di Zeno",AnnoPublicazione = 1923, AutoreID = 4 }
        }; 
        ListaPersonaggi = new List<Personaggio> 
        { 
            new Personaggio { PersonaggioId = 1, Nome = "Jean Valjean", Ruolo ="Protagonista", Sesso = "M", RomanzoId = 1 }, 
            new Personaggio { PersonaggioId = 2, Nome = "Cosette", Ruolo ="Protagonista", Sesso = "F", RomanzoId = 1 }, 
            new Personaggio { PersonaggioId = 3, Nome = "Guglielmo da Baskerville",Ruolo = "Protagonista", Sesso = "M", RomanzoId = 2 }, 
            new Personaggio { PersonaggioId = 4, Nome = "Adso da Melk", Ruolo ="Protagonista", Sesso = "M", RomanzoId = 2 }, 
            new Personaggio { PersonaggioId = 5, Nome = "Cosimo Piovasco di Rondò",Ruolo = "Protagonista", Sesso = "M", RomanzoId = 3 }, 
            new Personaggio { PersonaggioId = 6, Nome = "Marcello", Ruolo ="Protagonista", Sesso = "M", RomanzoId = 4 }, 
            new Personaggio { PersonaggioId = 7, Nome = "Vitangelo Moscarda", Ruolo ="Protagonista", Sesso = "M", RomanzoId = 5 }, 
            new Personaggio { PersonaggioId = 8, Nome = "Amerigo Ormea", Ruolo ="Protagonista", Sesso = "M", RomanzoId = 6 }, 
            new Personaggio { PersonaggioId = 9, Nome = "Zeno Cosini", Ruolo ="Protagonista", Sesso = "M", RomanzoId = 7 }, 
            new Personaggio { PersonaggioId = 10, Nome = "Augusta", Ruolo ="Protagonista", Sesso = "F", RomanzoId = 7 } 
        }; 

    }
}
