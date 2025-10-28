namespace _18_ESPreverifica;

class Program
{
    static List<Artista> listaArtisti;
    static List<Album> listaAlbums;
    static List<Canzone> listaCanzoni;
    static void Main(string[] args)
    {
        InitListe();
        //Q1("Electronic");
        //Q2(1980);
        //Q3("Pink Floyd");
        //Q4("Italia");
        //Q5();
        //Q6("Rock Progressivo");
        
        Console.ReadKey();
    }
    static void Q6(string s)
    {
        var AlbumDIArtista = listaArtisti.Where(a => a.GenereMusicale == s).Join
        (listaAlbums,

        a => a.ArtistaId,

        A => A.ArtistaId,

        (a, A) => new
        {
            A.Titolo,
            A.AlbumId
        }
        ).ToList();
         var AlbumDIArtistaF = AlbumDIArtista.Join(listaCanzoni,
        a => a.AlbumId,
        c => c.AlbumId,
        (a, c) => new
        {
            c.Titolo
        }).ToList();
        
  
        foreach (var item in AlbumDIArtistaF)
        {
            Console.WriteLine($"{item.Titolo}");
            
        }
    }
    static void Q5()
    {
        var BranPre1990 = listaAlbums.Where(a=>a.AnnoUscita<1990).Join
        (listaCanzoni,

        a => a.AlbumId,

        c => c.AlbumId,

        (a, c) => new
        {
            c.Titolo
        }
        );
        foreach (var item in BranPre1990)
        {
            Console.WriteLine($"{item.Titolo}");
            
        }
    }
    static void Q4 (string Nazionalità)
    {
        var NumeroOrigine = listaArtisti.Where(a=>a.PaeseOrigine==Nazionalità).Join
        (listaAlbums,

        a => a.ArtistaId,

        A => A.ArtistaId,

        (a, A) => new
        {
            A.Titolo
        }
        );
        Console.WriteLine($"{NumeroOrigine.Count()}");
        
    }
    static void Q3 (string NomeArte)
    {
        var AlbumDIArtista = listaArtisti.Where(a=>a.NomeArte==NomeArte).Join
        (listaAlbums,

        a => a.ArtistaId,

        A => A.ArtistaId,

        (a, A) => new
        {
            A.Titolo
        }
        );
        foreach (var item in AlbumDIArtista)
        {
            Console.WriteLine($"{item.Titolo}");
            
        }
    }
    static void Q2 (int anno)
    {
        var DopoAnnox = listaAlbums.Where(a => a.AnnoUscita > anno).ToList();
        foreach (var item in DopoAnnox)
        {
            Console.WriteLine($"{item.Titolo}");
            
        }
    }
    static void Q1(string gen)
    {
        var NomiEpaesi = listaArtisti.Where(a => a.GenereMusicale == gen).ToList();
        foreach (var artista in NomiEpaesi)
        {
            Console.WriteLine($"Nome D'arte: {artista.NomeArte}; Paese D'origine: {artista.PaeseOrigine}");
            
        }
    }
    static void InitListe()
{
   listaArtisti = new List<Artista>
        {
            new Artista { ArtistaId = 1, NomeArte = "Daft Punk", GenereMusicale = "Electronic", PaeseOrigine = "Francia" },
            new Artista { ArtistaId = 2, NomeArte = "Fabrizio De André", GenereMusicale = "Cantautore", PaeseOrigine = "Italia" },
            new Artista { ArtistaId = 3, NomeArte = "Pink Floyd", GenereMusicale = "Rock Progressivo", PaeseOrigine = "Regno Unito" },
            new Artista { ArtistaId = 4, NomeArte = "Bob Marley", GenereMusicale = "Reggae", PaeseOrigine = "Giamaica" },
            new Artista { ArtistaId = 5, NomeArte = "Lucio Battisti", GenereMusicale = "Cantautore", PaeseOrigine = "Italia" }
        };

        listaAlbums = new List<Album>
        {
            new Album { AlbumId = 1, Titolo = "Discovery", AnnoUscita = 2001, ArtistaId = 1 },
            new Album { AlbumId = 2, Titolo = "Random Access Memories", AnnoUscita = 2013, ArtistaId = 1 },
            new Album { AlbumId = 3, Titolo = "Creuza de ma", AnnoUscita = 1984, ArtistaId = 2 },
            new Album { AlbumId = 4, Titolo = "The Dark Side of the Moon", AnnoUscita = 1973, ArtistaId = 3 },
            new Album { AlbumId = 5, Titolo = "Exodus", AnnoUscita = 1977, ArtistaId = 4 },
            new Album { AlbumId = 6, Titolo = "Una donna per amico", AnnoUscita = 1978, ArtistaId = 5 },
            new Album { AlbumId = 7, Titolo = "The Wall", AnnoUscita = 1979, ArtistaId = 3 }
        };
        listaCanzoni = new List<Canzone>
        {
            new Canzone { CanzoneId = 1, Titolo = "One More Time", DurataMinuti = 5.33, AlbumId = 1 },
            new Canzone { CanzoneId = 2, Titolo = "Harder, Better, Faster, Stronger", DurataMinuti = 3.73, AlbumId = 1 },
            new Canzone { CanzoneId = 3, Titolo = "Get Lucky", DurataMinuti = 6.15, AlbumId = 2 },
            new Canzone { CanzoneId = 4, Titolo = "Jamming", DurataMinuti = 3.50, AlbumId = 5 },
            new Canzone { CanzoneId = 5, Titolo = "Time", DurataMinuti = 7.08, AlbumId = 4 },
            new Canzone { CanzoneId = 6, Titolo = "Money", DurataMinuti = 6.36, AlbumId = 4 },
            new Canzone { CanzoneId = 7, Titolo = "Another Brick in the Wall, Part 2", DurataMinuti = 3.98, AlbumId = 7 },
            new Canzone { CanzoneId = 8, Titolo = "Sinan Capudan Pascià", DurataMinuti = 5.53, AlbumId = 3 },
            new Canzone { CanzoneId = 9, Titolo = "Una donna per amico", DurataMinuti = 5.20, AlbumId = 6 },
            new Canzone { CanzoneId = 10, Titolo = "Nessun dolore", DurataMinuti = 6.10, AlbumId = 6 }
        };
}
}
