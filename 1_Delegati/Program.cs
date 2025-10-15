namespace _1_Delegati;

class Program
{
    public delegate void Print(int value);
    static void Main(string[] args)
    {
        Print printde1 = PrintNumber;
        printde1(20);
        printde1(2000);
        printde1 = PrintMoney;
        printde1(3000);
        Print printde2 = new Print(PrintMoney);
    }
    public static void PrintNumber(int num)
    {
        Console.WriteLine($"Il valore di num è = {num} ");
    }
    public static void PrintMoney(int money)
    {
        Console.WriteLine("money {0:C}",money);
        
    }
}
