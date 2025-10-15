namespace _7_EsempioFunc;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program
{
    //public delegate double MathDelegate(double n1, double n2);

    static void Main(string[] args)
    {
        Func<double, double, double> Mathdelegate = (x, y) => x + y;
        Console.WriteLine(Mathdelegate(4, 5));
        Func<Student, bool> isTeeAger = S => S.Age > 12;
        Console.ReadKey();
        
    }
}
