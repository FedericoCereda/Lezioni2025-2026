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
    }
}