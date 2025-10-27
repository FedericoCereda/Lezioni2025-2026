using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace _16_RiassuntoPerVerifica;

class Program
{
    static List<Autore> ListaAutori;
    static List<Libro> ListaLibri;
    static List<Prestito> ListaPrestiti;
    public delegate void NomeCognome(string nome, string Cognome);
    delegate string NomeCognome2(string nome, string cognome);

    public delegate void MathDelegate(decimal valore);
    static void Main(string[] args)
    {
        InitializeList();
        //EsempioDelegate();
        esempioLamda();
        Console.ReadKey();
    }
    static void esempioLamda()
    {
        NomeCognome2 Unisci = (x, y) => string.Concat(x ?? "", " ", y ?? "");
        // o per operazione piu complicate 
        NomeCognome2 Controllo = (x, y) =>
        {
            if (x == null)
            {
                System.Console.WriteLine("Nome Mancante");
            }
            else if (y == null)
            {
                System.Console.WriteLine("Cognome Mancante");
            }
            else
            {
                System.Console.WriteLine("Nome e Cognome Presente");
            }
            foreach (var Autore in ListaAutori)
            {
                string Uniti = Unisci(Autore.Nome, Autore.Cognome);
                System.Console.WriteLine(Uniti);
            }
            return null;
        };
    }
    static void EsempioDelegate()
    {
        System.Console.WriteLine("--------------------------------------------");
        System.Console.WriteLine("Nome e Cognome Autori e prezzo scontato\n");
        NomeCognome nomeCognome = StampaNomeCognome;
        MathDelegate mathDelegate = Sconto10;
        foreach (var Autore in ListaAutori)
        {
            nomeCognome(Autore.Nome, Autore.Cognome);
        }
        foreach (var Libro in ListaLibri)
        {
            mathDelegate(Libro.Prezzo);
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Cognome e Nomi Autori e prezzo aumentato\n");
        NomeCognome CognomeNome = StampaCognomeNome;
        MathDelegate mathDelegateMeno = Aumento10;
        foreach (var Autore in ListaAutori)
        {
            CognomeNome(Autore.Nome, Autore.Cognome);
        }
        foreach (var Libro in ListaLibri)
        {
            mathDelegateMeno(Libro.Prezzo);
        }
        System.Console.WriteLine("--------------------------------------------");
        // si possono chiamare i delegati anche cosi
        MathDelegate a, b,c,d,k;
        a = Sconto10;
        b = new MathDelegate(Aumento10);
        // o si possono sommare o sottrarre tra di loro o aggiungere successivamente
        c = a + b;
        d = c - a;
        k = null;
        k += a;
    }
    static void Sconto10(decimal valore)
    {
        Console.WriteLine($"Somma: {valore - (valore / 10)}");
    }
    static void Aumento10(decimal valore)
    {
        Console.WriteLine($"Somma: {valore+(valore/10)}" );
    }
    
    static void StampaNomeCognome(string nome, string Cognome)
    {
        Console.WriteLine($"Nome:" + nome + "; Congome:" + Cognome);
    }
    static void StampaCognomeNome(string nome,string Cognome)
    {
        Console.WriteLine($"Congome:"+Cognome+"; Nome:"+nome);
    }
    static void InitializeList()
    {
        ListaAutori = new List<Autore>()
        {
            new Autore { AutoreID = 1, Nome = "Alessandro", Cognome = "Manzoni", Nazionalita = "Italiana", AnnoNascita = 1785 },
            new Autore { AutoreID = 2, Nome = "Dante", Cognome = "Alighieri", Nazionalita = "Italiana", AnnoNascita = 1265 },
            new Autore { AutoreID = 3, Nome = "Gabriel", Cognome = "García Márquez", Nazionalita = "Colombiana", AnnoNascita = 1927 },
            new Autore { AutoreID = 4, Nome = "George", Cognome = "Orwell", Nazionalita = "Britannica", AnnoNascita = 1903 },
            new Autore { AutoreID = 5, Nome = "Jane", Cognome = "Austen", Nazionalita = "Britannica", AnnoNascita = 1775 },
            new Autore { AutoreID = 6, Nome = "Umberto", Cognome = "Eco", Nazionalita = "Italiana", AnnoNascita = 1932 },
            new Autore { AutoreID = 7, Nome = "Ernest", Cognome = "Hemingway", Nazionalita = "Americana", AnnoNascita = 1899 }
        };
        ListaLibri = new List<Libro>()
        {
            new Libro { LibroID = 1, Titolo = "I Promessi Sposi", AutoreID = 1, Genere = "Romanzo Storico", AnnoPubblicazione = 1840, NumeroPagine = 720, Prezzo = 12.50m, Disponibile = true },
            new Libro { LibroID = 2, Titolo = "La Divina Commedia", AutoreID = 2, Genere = "Poesia Epica", AnnoPubblicazione = 1320, NumeroPagine = 798, Prezzo = 15.00m, Disponibile = false },
            new Libro { LibroID = 3, Titolo = "Cent'anni di solitudine", AutoreID = 3, Genere = "Realismo Magico", AnnoPubblicazione = 1967, NumeroPagine = 417, Prezzo = 18.90m, Disponibile = true },
            new Libro { LibroID = 4, Titolo = "1984", AutoreID = 4, Genere = "Distopia", AnnoPubblicazione = 1949, NumeroPagine = 328, Prezzo = 14.50m, Disponibile = true },
            new Libro { LibroID = 5, Titolo = "La fattoria degli animali", AutoreID = 4, Genere = "Satira", AnnoPubblicazione = 1945, NumeroPagine = 112, Prezzo = 9.90m, Disponibile = true },
            new Libro { LibroID = 6, Titolo = "Orgoglio e Pregiudizio", AutoreID = 5, Genere = "Romanzo", AnnoPubblicazione = 1813, NumeroPagine = 432, Prezzo = 11.00m, Disponibile = false },
            new Libro { LibroID = 7, Titolo = "Il nome della rosa", AutoreID = 6, Genere = "Giallo Storico", AnnoPubblicazione = 1980, NumeroPagine = 503, Prezzo = 16.50m, Disponibile = true },
            new Libro { LibroID = 8, Titolo = "Il pendolo di Foucault", AutoreID = 6, Genere = "Romanzo", AnnoPubblicazione = 1988, NumeroPagine = 623, Prezzo = 19.00m, Disponibile = true },
            new Libro { LibroID = 9, Titolo = "Il vecchio e il mare", AutoreID = 7, Genere = "Novella", AnnoPubblicazione = 1952, NumeroPagine = 127, Prezzo = 10.50m, Disponibile = false },
            new Libro { LibroID = 10, Titolo = "Per chi suona la campana", AutoreID = 7, Genere = "Romanzo di Guerra", AnnoPubblicazione = 1940, NumeroPagine = 471, Prezzo = 17.00m, Disponibile = true }
        };
        ListaPrestiti = new List<Prestito>()
        {
            new Prestito { PrestitoID = 1, LibroID = 2, NomeUtente = "Mario Rossi", DataPrestito = new DateTime(2025, 9, 15), DataRestituzione = null },
            new Prestito { PrestitoID = 2, LibroID = 6, NomeUtente = "Laura Bianchi", DataPrestito = new DateTime(2025, 10, 1), DataRestituzione = null },
            new Prestito { PrestitoID = 3, LibroID = 9, NomeUtente = "Giuseppe Verdi", DataPrestito = new DateTime(2025, 10, 5), DataRestituzione = null },
            new Prestito { PrestitoID = 4, LibroID = 1, NomeUtente = "Anna Neri", DataPrestito = new DateTime(2025, 8, 20), DataRestituzione = new DateTime(2025, 9, 10) },
            new Prestito { PrestitoID = 5, LibroID = 4, NomeUtente = "Mario Rossi", DataPrestito = new DateTime(2025, 9, 1), DataRestituzione = new DateTime(2025, 9, 25) },
            new Prestito { PrestitoID = 6, LibroID = 7, NomeUtente = "Laura Bianchi", DataPrestito = new DateTime(2025, 7, 15), DataRestituzione = new DateTime(2025, 8, 5) },
            new Prestito { PrestitoID = 7, LibroID = 3, NomeUtente = "Giuseppe Verdi", DataPrestito = new DateTime(2025, 6, 10), DataRestituzione = new DateTime(2025, 7, 1) }
        };
    }
    
}
