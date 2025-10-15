internal class Program
{
    public delegate void del(string s);
    public static void Hello(string s)
    {
        Console.WriteLine($"Hello {s}");
    }
    public static void Goobye (string s)
    {
        Console.WriteLine($"Goobye {s}");
    }
    private static void Main(string[] args)
    {
        del a, b, c, d, k;
        a = new del(Hello);
        b = Goobye;
        c = a + b;
        k = null;
        k += b;
        k += a;
        d = c - a;
        Console.WriteLine($"Il nuovo delegato di a");
        a("A");
        Console.WriteLine($"Il nuovo delegato di b");
        b("B");
        Console.WriteLine($"Il nuovo delegato di c");
        c("C");
        Console.WriteLine($"Il nuovo delegato di d");
        d("D");
        Console.WriteLine($"Il nuovo delegato di k");
        k("K");
        Console.ReadKey();
        
    }
}