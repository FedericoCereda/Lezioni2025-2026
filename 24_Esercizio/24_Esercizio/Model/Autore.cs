using System;

namespace _24_Esercizio.Model;

public class Autore
{
    public string AutoreId { get; set; }= null!;
    public string Nome { get; set; } = null!;
    public string Cognome { get; set; } = null!;
    public DateOnly DataDiNascita{get;set;} 

}
