using System;

namespace _24_Esercizio.Model;

public class Libro
{
    public string LibroID { get; set; }= null!;
    public string Titolo { get; set;}= null!;
    public int Anno { get; set; }
    public int Pagine { get; set;}
    public string AutoreId { get; set; }=null!;
}
