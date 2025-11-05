using System.Data.Common;
using _19_EsercizioCorretto.Data;
using _19_EsercizioCorretto.Model;

namespace _19_EsercizioCorretto;

class Program
{
    static void Caricadati()
    {
        StudenteContext db = new();
        db.Add(new Studente { StudenteId = 1, Cognome = "Rossi", Nome = "Dario", Eta = 19, Citta = "Milano" });
        db.Add(new Studente { StudenteId = 2, Cognome = "da", Nome = "c", Eta = 19, Citta = "Milano" });
        db.SaveChanges();
    }
    static void Main(string[] args)
    {
        //Caricadati();
        StudenteContext db = new();
        db.studentes.ToList().ForEach(studente => Console.WriteLine(studente.Cognome+" "+studente.Nome));
        Console.ReadKey();
    }
}
