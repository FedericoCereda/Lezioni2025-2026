namespace _12_EsempioFluent;

class Program
{
    static void Main(string[] args)
    {

        IList<string> stringList = new List<string>() {
            "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++",
            "MVC Tutorials" ,
            "Java"
        };
        IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };
        var tutorials = stringList.Where(s => s.Contains("Tutorials"));
        foreach (var item in tutorials)
        {
            Console.WriteLine(item);

        }
        List<Student> students = studentList.Where(s => s.Age < 20).ToList<Student>();

        foreach (var item in students)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
    class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return String.Format($"[StudentID = {StudentID}, StudentName = {StudentName},Age = {Age}]");
        }
    }
}
