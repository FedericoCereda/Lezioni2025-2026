using System.Data;

namespace _11_EsempioRicercaConLinq;

class Program
{
    static void Main(string[] args)
    {
        Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve", Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill", Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram", Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron", Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris", Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob", Age = 19 },
        };
        Student[] teeAgersStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
        foreach (var item in teeAgersStudents)
        {
            Console.WriteLine(item);
        }
        Student sBill = studentArray.Where(s => s.StudentName.Equals("BIll")).FirstOrDefault();
        Console.WriteLine(sBill);

        var teeAger = from s in studentArray where s.Age > 12 && s.Age <= 20 select s;
        foreach (var item in teeAger)
        {
            Console.WriteLine(item);
        }

        teeAger = studentArray.Where(s => s.Age>12 && s.Age < 20).ToArray();
    }
    
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
