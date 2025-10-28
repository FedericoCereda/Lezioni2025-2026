using System;

namespace _18_ESPreverifica;

public class Canzone
{
    public int CanzoneId { get; set; }
    public string Titolo { get; set; }
    public double DurataMinuti { get; set; } // Durata in minuti (es. 3.5)
    public int AlbumId { get; set; }      // Chiave esterna
}
