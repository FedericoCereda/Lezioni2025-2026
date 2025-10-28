# Esercizio Album Musicali

## Date le seguenti classi

```csharp
// Classe per l'artista
public class Artista
{
    public int ArtistaId { get; set; }
    public string NomeArte { get; set; }
    public string GenereMusicale { get; set; }
    public string PaeseOrigine { get; set; }
}

// Classe per l'album
public class Album
{
    public int AlbumId { get; set; }
    public string Titolo { get; set; }
    public int AnnoUscita { get; set; }
    public int ArtistaId { get; set; } // Chiave esterna
}

// Classe per la canzone
public class Canzone
{
    public int CanzoneId { get; set; }
    public string Titolo { get; set; }
    public double DurataMinuti { get; set; } // Durata in minuti (es. 3.5)
    public int AlbumId { get; set; }      // Chiave esterna
}
```
## Le liste con i dati 

```csharp
static List<Artista> listaArtisti;
static List<Album> listaAlbums;
static List<Canzone> listaCanzoni;
```

```csharp
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

```
---

## sviluppare le seguenti Query

### Q1: Creare un metodo che prende in input un genere musicale (es. "Cantautore") e stampa il nome d'arte e il paese d'origine di tutti gli artisti di quel genere.

### Q2: Creare un metodo che prende in input un anno (es. 1980) e stampa il titolo e l'anno di uscita di tutti gli album pubblicati dopo quell'anno.

### Q3: Creare un metodo che prende in input il nome d'arte di un artista (es. "Pink Floyd") e stampa i titoli di tutti i suoi album.

### Q4: Creare un metodo che per ogni paese d'origine (es. "Italia") stampa il numero totale di album presenti nella lista relativi ad artisti di quel paese.

### Q5: Creare un metodo che stampa il titolo di tutte le canzoni presenti in album pubblicati prima del 1990.

### Q6: Creare un metodo che prende in input un genere musicale (es. "Rock Progressivo") e stampa i titoli di tutte le canzoni di artisti appartenenti a quel genere.

### Q7: Creare un metodo che stampa il titolo della canzone con la durata maggiore
