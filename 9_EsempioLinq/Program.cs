namespace _9_EsempioLinq;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "BIll", "Steve", "James", "Mohan" };
        var dati = from name in names
                where name.Contains('a')
                select name;
        foreach (var item in dati)
        {
            Console.WriteLine(item);
        }
        dati = from nomi in names
               where nomi.Length > 4
               select nomi;
        foreach (var item in dati)
        {   
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
}
