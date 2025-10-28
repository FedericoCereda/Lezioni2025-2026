using System;

namespace _18_ESPreverifica;

public class Album
{
    public int AlbumId { get; set; }
    public string Titolo { get; set; }
    public int AnnoUscita { get; set; }
    public int ArtistaId { get; set; } // Chiave esterna
}
