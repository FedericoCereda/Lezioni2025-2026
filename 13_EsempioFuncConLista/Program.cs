namespace _13_EsempioFuncConLista;

class Program
{
    static void Main(string[] args)
    {
        IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };
        Func<Student, bool> studentiMinori = (s) => s.Age < 20;
        var listaStudentiMin20 = studentList.Where(studentiMinori);
        foreach (var item in listaStudentiMin20)
        {
            Console.WriteLine(item);

        }
        listaStudentiMin20 = from s in studentList
                             where studentiMinori(s)
                             select s;
        foreach (var item in listaStudentiMin20)
        {
            Console.WriteLine(item);
        }
        studentList.Where(s => s.Age < 20).ToList().ForEach(s => Console.WriteLine(s));
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
