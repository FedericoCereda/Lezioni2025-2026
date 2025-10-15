namespace _5_EsempioStudente;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program
{
    public delegate bool isTeenager(Student student);
    static void Main(string[] args)
    {
        isTeenager isTeenager = delegate (Student student) { return student.Age > 12 && student.Age < 20; };
        Student student = new();
        student.Age = 12;
        Console.WriteLine(isTeenager(student));
        
        Console.ReadKey();
    }
}
