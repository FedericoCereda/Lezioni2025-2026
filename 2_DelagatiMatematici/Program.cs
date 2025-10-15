namespace _2_DelagatiMatematici;

class Program
{
    public delegate double MathDelegate(double n1, double n2);
    static void Main(string[] args)
    {
        MathDelegate mathDelegate = Add;
        Console.WriteLine($"Inserisci il primo valore");
        double v1 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Inserisci il secondo valore");
        double v2 = double.Parse(Console.ReadLine());
        Console.WriteLine(mathDelegate(v1,v2));
        mathDelegate = Subtract;
        Console.WriteLine(mathDelegate(v1,v2));


    }
    public static double Add(double value1, double value2)
    {
        return value1 + value2;
    }
    public static double Subtract(double value1, double value2)
    {
        return value1 - value2;
    }

}
