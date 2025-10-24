namespace _2025
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IList<Autore> autori = new List<Autore>()
            {
                new Autore { AutoreID = 1, Nome = "Alessandro", Cognome = "Manzoni", Nazionalita = "Italiana", AnnoNascita = 1785 },
                new Autore { AutoreID = 2, Nome = "Dante", Cognome = "Alighieri", Nazionalita = "Italiana", AnnoNascita = 1265 },
                new Autore { AutoreID = 3, Nome = "Gabriel", Cognome = "García Márquez", Nazionalita = "Colombiana", AnnoNascita = 1927 },
                new Autore { AutoreID = 4, Nome = "George", Cognome = "Orwell", Nazionalita = "Britannica", AnnoNascita = 1903 },
                new Autore { AutoreID = 5, Nome = "Jane", Cognome = "Austen", Nazionalita = "Britannica", AnnoNascita = 1775 },
                new Autore { AutoreID = 6, Nome = "Umberto", Cognome = "Eco", Nazionalita = "Italiana", AnnoNascita = 1932 },
                new Autore { AutoreID = 7, Nome = "Ernest", Cognome = "Hemingway", Nazionalita = "Americana", AnnoNascita = 1899 }
            };

            IList<Libro> libri = new List<Libro>()
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

            IList<Prestito> prestiti = new List<Prestito>()
            {
                new Prestito { PrestitoID = 1, LibroID = 2, NomeUtente = "Mario Rossi", DataPrestito = new DateTime(2025, 9, 15), DataRestituzione = null },
                new Prestito { PrestitoID = 2, LibroID = 6, NomeUtente = "Laura Bianchi", DataPrestito = new DateTime(2025, 10, 1), DataRestituzione = null },
                new Prestito { PrestitoID = 3, LibroID = 9, NomeUtente = "Giuseppe Verdi", DataPrestito = new DateTime(2025, 10, 5), DataRestituzione = null },
                new Prestito { PrestitoID = 4, LibroID = 1, NomeUtente = "Anna Neri", DataPrestito = new DateTime(2025, 8, 20), DataRestituzione = new DateTime(2025, 9, 10) },
                new Prestito { PrestitoID = 5, LibroID = 4, NomeUtente = "Mario Rossi", DataPrestito = new DateTime(2025, 9, 1), DataRestituzione = new DateTime(2025, 9, 25) },
                new Prestito { PrestitoID = 6, LibroID = 7, NomeUtente = "Laura Bianchi", DataPrestito = new DateTime(2025, 7, 15), DataRestituzione = new DateTime(2025, 8, 5) },
                new Prestito { PrestitoID = 7, LibroID = 3, NomeUtente = "Giuseppe Verdi", DataPrestito = new DateTime(2025, 6, 10), DataRestituzione = new DateTime(2025, 7, 1) }
            };

            Console.WriteLine($"Totale autori: {autori.Count}");
            Console.WriteLine($"Totale libri: {libri.Count}");
            Console.WriteLine($"Totale prestiti: {prestiti.Count}");
            //1.1
            Console.WriteLine($"Libri publicati dopo il 1900 che costano meno di 15£");
            libri.
            Where(l => l.Prezzo < 15 && l.AnnoPubblicazione > 1900).
            ToList().
            ForEach(l => Console.WriteLine($"{l.Titolo} - {l.AnnoPubblicazione} - €{l.Prezzo}"));
            //1.2
            autori.
            Where(a => a.Nazionalita == "Italiana" && a.AnnoNascita < 1900).
            ToList().
            ForEach(a => Console.WriteLine($"{a.Nome} - {a.Cognome} - €{a.AnnoNascita}"));
            //1.3
            prestiti.
            Where(p => p.DataRestituzione == null && p.NomeUtente == "Mario Rossi").
            ToList().
            ForEach(p => Console.WriteLine(p.PrestitoID ));
            //2.1
            libri.
            OrderBy(l => l.Genere).
            ThenByDescending(l => l.Prezzo).
            ToList().
            ForEach(l => Console.WriteLine(l.Titolo + " " + l.Genere + " " + l.Prezzo));
            //2.2
            autori.
            OrderBy(l => l.Cognome).
            ToList().
            ForEach(l => Console.WriteLine(l.Cognome));
            //3.1
            var groupGenere = libri.GroupBy(l => l.Genere);
            foreach (var item in groupGenere)
            {
                Console.WriteLine($"Genere: " + item.Key);

                foreach (var Libro in item)
                {
                    Console.WriteLine($"Numero totale: " + item.Count());
                    Console.WriteLine($"Prezzo medio: " + item.Average(s => s.Prezzo));
                    Console.WriteLine($"Il numero di pagine massimo: " + item.Max(s => s.NumeroPagine));
                    Console.WriteLine();
                }
            }
            //3.2
            var groupNazionalità = autori.GroupBy(a => a.Nazionalita).ToList();
            foreach (var item in groupNazionalità)
            {
                Console.WriteLine($"Nazionalità: " + item.Key);
                Console.WriteLine($"Numero di autore: " + item.Count());
                Console.WriteLine();
            }
            //3.3
            var groupAutore = libri.GroupBy(l => l.AutoreID).ToList();

            foreach (var item in groupAutore)
            {
                Console.WriteLine($"Autore: " + item.Key);
                Console.WriteLine($"Libri Scritti " + item.Count());
                Console.WriteLine($"Ultimo libro " + item.Min(l => l.AnnoPubblicazione));
                Console.WriteLine();
            }
            //3.4
            var groupPrestiti = prestiti.GroupBy(p => p.NomeUtente).ToList();
            foreach (var item in groupPrestiti)
            {
                Console.WriteLine($"Utente: " + item.Key);
                Console.WriteLine($"Prestiti effettuati: " + item.Count());
                Console.WriteLine($"Prestiti attivi: " + item.Count(p => p.DataRestituzione == null));
                Console.WriteLine($"Prestiti possibili: " + item.Count(p => p.DataRestituzione != null));

            }
            //4.1
            var JoinLibriAutori = libri.Join(autori,
            l => l.LibroID,
            a => a.AutoreID,
            (l, a) => new { Titolo = l.Titolo, NomeCompleto = a.Nome + a.Cognome, Nazionalità = a.Nazionalita, Publicazione = l.AnnoPubblicazione , Disponibilità = l.Disponibile , LibroID = l.LibroID , Cognome = a.Cognome , Prezzo= l.Prezzo});
            foreach (var item in JoinLibriAutori)
            {
                if (item.Disponibilità != null)
                {
                    Console.WriteLine($"Titolo: {item.Titolo} Nome completo: {item.NomeCompleto} Nazionalità: {item.Nazionalità} Data di publicazione: {item.Publicazione}");
                    System.Console.WriteLine();
                }
            }
            //4.2
            var JounTutto = JoinLibriAutori.Join(prestiti,
            lb => lb.LibroID,
            t => t.LibroID,
            (lb, t) => new { NomeUtente = lb.NomeCompleto, Titolo = lb.Titolo, CognomeAutore = lb.Cognome, DataPrestito = t.DataPrestito, Disponibile=t.DataRestituzione });
            JounTutto = JounTutto.Where(j => j.Disponibile == null).ToList();
            foreach (var item in JounTutto)
            {
                Console.WriteLine($"Nome Utente: " + item.NomeUtente + " Titolo libro: " + item.Titolo + " Cognome Autore: " + item.CognomeAutore + " Data prestito: " + item.DataPrestito + " Giorni trascorsi: " + DateTime.Now.Subtract(item.DataPrestito));
                System.Console.WriteLine();
            }
            //4.3
            JoinLibriAutori = JoinLibriAutori.Where(j => j.Nazionalità == "Americana" || j.Nazionalità == "Britannica").Where(j => j.Publicazione > 1940).OrderBy(j => j.Publicazione).ToList();
            foreach (var item in JoinLibriAutori)
            {
                Console.WriteLine($"Titolo: "+item.Titolo+" Cognome: "+item.Cognome+" Nazionalità: "+item.Nazionalità+" Anno di publicazione: "+item.Publicazione+" Prezzo: "+item.Prezzo);
                
            }
            Console.ReadKey();

        }
    }

    public class Libro
    {
        public int LibroID { get; set; }
        public string Titolo { get; set; }
        public int AutoreID { get; set; }
        public string Genere { get; set; }
        public int AnnoPubblicazione { get; set; }
        public int NumeroPagine { get; set; }
        public decimal Prezzo { get; set; }
        public bool Disponibile { get; set; }
    }

    public class Autore
    {
        public int AutoreID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Nazionalita { get; set; }
        public int AnnoNascita { get; set; }
    }

    public class Prestito
    {
        public int PrestitoID { get; set; }
        public int LibroID { get; set; }
        public string NomeUtente { get; set; }
        public DateTime DataPrestito { get; set; }
        public DateTime? DataRestituzione { get; set; }
    }
}
