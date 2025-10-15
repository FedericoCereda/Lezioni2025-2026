namespace _6_EsempioStudente2;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program
{
    public delegate bool IsYougerThan(Student s, int youngAge);
    static void Main(string[] args)
    {
        IsYougerThan isYougerThan = (stud, youngAge) => stud.Age < youngAge;
        Student s = new Student() { Age = 20 };
        Console.WriteLine(isYougerThan(s, 23));
        IsYougerThan isYougerThan1 = (stud, età) =>
        {
            if (stud.Name.Equals("Marco") && stud.Age < età)
            {
                return true;
            }
            else return false;
        };
        Student s1 = new() { Age = 21 };
        Console.WriteLine(isYougerThan(s1, 21));
        Console.ReadKey();
    }
}
