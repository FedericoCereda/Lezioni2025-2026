namespace _4_EsempiLamba;

class Program
{
    public delegate double MathDelegate(double n1, double n2);
    static void Main(string[] args)
    {
        MathDelegate mathDelegate = (x, y) => x + y;
        double result = mathDelegate(4, 5);
        mathDelegate = (x, y) => x - y;
        double result2 = mathDelegate(4, 5);
        Console.WriteLine(result);
        Console.WriteLine(result2);
        mathDelegate = (x, y) =>
        {
            Console.WriteLine($"Sto eseguendo il prodotto");
            return x * y;
        };
        result = mathDelegate(4, 5);
        Console.WriteLine(result);
        mathDelegate = (a, b) =>
        {
            if (b == 0)
            {
                return 1;
            }
            else return Math.Pow(a, b);
        };
        Console.WriteLine(mathDelegate (2,3));
        Console.ReadKey();
    }
}
