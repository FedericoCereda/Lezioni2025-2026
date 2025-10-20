namespace _8_EsempioAction;

class Program
{
    static void Main(string[] args)
    {
        Action<string, string> stampa = (cognome, nome) =>
        {
            Console.WriteLine($"{cognome} {nome}");
        };
        stampa("Rossi", "Mario");
        Action<string, string> concatena = (congnome, nome) => Console.WriteLine(congnome + " " + nome);
        concatena("Neri", "Luca");
        Action<Student> stampaStud = s =>
        {
            if (s.Age >= 18)
            {
                Console.WriteLine($"Studente maggiorenne");

            }
            else Console.WriteLine($"Studente minorenne");

        };
        Student s = new() { Name = "Mario", Age = 18 };
    stampaStud (s);
        Console.ReadKey();
    }
    public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
}
