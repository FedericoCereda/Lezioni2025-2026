using System;

namespace _19_EsercizioCorretto.Model;

public class Studente
{
    public int StudenteId { get; set; }
    public string Cognome { get; set; } = null!;
    public string Nome { get; set; } = null!;
    public int Eta { get; set; }
    public string Citta { get; set; } = null!;
    
    
}
