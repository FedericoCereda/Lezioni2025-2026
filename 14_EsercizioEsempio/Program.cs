namespace _14_EsercizioEsempio;
class Student
{
    public int StudentID { get; set; }
    public String StudentName { get; set; }
    public int Age { get; set; }
    public double MediaVoti { get; set; }

    public override string ToString()
    {
    return String.Format($"[StudentID = {StudentID}, StudentName = {StudentName}, Age = {Age}, MediaVoti = { MediaVoti}]"); 
    }
}
class Assenza
{
    public int ID { get; set; }
    public DateTime Giorno { get; set; }
    public int StudentID { get; set; }
}
class Persona
{
    public string Nome { get; set; }
    public int Eta { get; set; }

    public override string ToString()
    {
        return String.Format($"[Nome = {Nome}, Età = {Eta}]");
    }
}

class Program
{
    static List<Student> studentList;
    static List<Student> InitLista()
    {
        List<Student> elencoStudenti = new(){
            new() { StudentID = 1, StudentName = "John", Age = 18, MediaVoti = 6.5 },
            new() { StudentID = 2, StudentName = "Steve", Age = 21, MediaVoti = 8 },
            new() { StudentID = 3, StudentName = "Bill", Age = 25, MediaVoti = 7.4 },
            new() { StudentID = 4, StudentName = "Ram", Age = 20, MediaVoti = 10 },
            new() { StudentID = 5, StudentName = "Ron", Age = 31, MediaVoti = 9 },
            new() { StudentID = 6, StudentName = "Chris", Age = 17, MediaVoti = 8.4 },
            new() { StudentID = 7, StudentName = "Rob", Age = 19, MediaVoti = 7.7 },
            new() { StudentID = 8, StudentName = "Robert", Age = 22, MediaVoti = 8.1 },
            new() { StudentID = 9, StudentName = "Alexander", Age = 18, MediaVoti = 4 },
            new() { StudentID = 10, StudentName = "John", Age = 18, MediaVoti = 6 },
            new() { StudentID = 11, StudentName = "John", Age = 21, MediaVoti = 8.5 },
            new() { StudentID = 12, StudentName = "Bill", Age = 25, MediaVoti = 7 },
            new() { StudentID = 13, StudentName = "Ram" , Age = 20, MediaVoti = 9 } ,
            new() { StudentID = 14, StudentName = "Ron" , Age = 31, MediaVoti = 9.5 } ,
            new() { StudentID = 15, StudentName = "Chris",  Age = 17, MediaVoti = 8 } ,
            new() { StudentID = 16, StudentName = "Rob2",Age = 19  , MediaVoti=7} ,
            new() { StudentID = 17, StudentName = "Robert2",Age = 22, MediaVoti=8 } ,
            new() { StudentID = 18, StudentName = "Alexander2",Age = 18, MediaVoti=9 } ,
            };
        return elencoStudenti;
    }
    static void QueryWhere()
    {
      
        Console.WriteLine("seleziona solo gli studenti che tra 18 e 25 anni che occupano una posizione pari nella lista ");
        List<Student> studentResultList = studentList.Where(
            (s, i) => (s.Age >= 18 && s.Age <= 25) && i % 2 == 0).ToList();
        Console.WriteLine("stampa su list");
        studentResultList.
        ForEach(s => Console.WriteLine(s.StudentName + " age = " + s.Age));

        //E' possibile anche far applicare più volte la where per ottenere filtraggi multipli 
        Console.WriteLine("doppia where: quelli che verificano la condizione e che hanno ID>3");

        studentResultList = studentList.
            Where(s => s.Age >= 18 && s.Age <= 25).
            Where(s => s.StudentID > 3).ToList();

        studentResultList.
                 ForEach(s => Console.WriteLine(s.StudentName + " age = " + s.Age + " ID = " + s.StudentID));

        // oppure così
        //studentResultList = studentList.
        // Where(s => s.Age >= 18 && s.Age <= 25 && s.StudentID > 3).ToList();
        Console.WriteLine("Studenti con età > di 25 anni. Stampa direttamente sena passare la lista al foreach");
        studentList.
            Where(s => s.Age > 25).ToList().
            ForEach(s => Console.WriteLine(s.StudentName + " " + s.Age));
    }
    static void QueryOrdinamento()
    {
        Console.WriteLine("Ordinamento in base all'età");

        List<Student> studentResultList = studentList.OrderBy(s => s.Age).ToList();
        Console.WriteLine("\nstampa su list");

        studentResultList.
            ForEach(s => Console.WriteLine(s.StudentName + " age = " + s.Age));

        Console.WriteLine("Ordinamento discendente");
        studentList = studentList.OrderByDescending(s => s.Age).ToList();
        foreach (var item in studentList)
        {
            Console.WriteLine(item.StudentName + " Età: " + item.Age);
        }

        Console.WriteLine("\nClausola select - LINQ method");
        Console.WriteLine("\nUso di tipi anonimi");
        studentList.
               Select(s => new { Nome = s.StudentName, Eta = s.Age }).
               ToList().
               ForEach(p => Console.WriteLine(p.Nome));
        Console.WriteLine("\nUso di tipi diversi");

        List<Persona> personaResultList =
                   studentList.
                   Select(s => new Persona() { Nome = s.StudentName, Eta = s.Age }).
                   ToList();
        personaResultList.ForEach(p => Console.WriteLine(p));
        // trovare gli stuednti con media dei voti compresa tra 7 e 9 ordinati per età decrescente e stampo nel formato seguente: NomeStud,EtàStud,MediaStud
        Console.WriteLine("Studenti con la media tra 7 e 9");
        studentList.Where(s => s.MediaVoti >= 7 && s.MediaVoti <= 9).
        Select(s => new { NomeStud = s.StudentName, EtaStud = s.Age, MediaStud = s.MediaVoti }).
        OrderByDescending(s => s.MediaStud).
        ToList()
        .ForEach(info => Console.WriteLine(info.NomeStud + "," + info.EtaStud + ";" + info.MediaStud));
        Console.WriteLine("Ordinati su due fattori");
        studentList.OrderBy(s => s.Age).
        ThenByDescending(s => s.MediaVoti).
        ToList().
        ForEach((s) => Console.WriteLine(s));

    }
    static void QueryGroupBy()
    {
        Console.WriteLine("Raggruppamenti con GroupBy ");
        //Group By 
        var groupedResult = studentList.GroupBy(s => s.Age);

        foreach (var group in groupedResult)
        {
            Console.WriteLine("Group key(Age) = {0}", group.Key);
            foreach (var student in group)
            {
                Console.WriteLine("Student = {0}", student);
            }
            //calcoliamo una funzione di gruppo: min, max, avg, count 
            // funzione count: quanti studenti con la stessa età 
            Console.WriteLine("Numero studenti con la stessa età nel gruppo = {0}", group.Count());
            Console.WriteLine("Valore medio dei voti = {0}", group.Average(s => s.MediaVoti));
            Console.WriteLine("Voto massimo nel gruppo = {0}", group.Max(s => s.MediaVoti));
            Console.WriteLine("Voto minimo nel gruppo = {0}", group.Min(s => s.MediaVoti));
        }

        Console.WriteLine("STAMPA RAGGRUPPAMENTO PER NOME");
        var groupedResult2 = studentList.GroupBy(s => s.StudentName);

        foreach (var group in groupedResult2)
        {
            Console.WriteLine("Chiave di raggruppamento (Nome) = " + group.Key);
            foreach (var student in group)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("Numero studenti omonimi: " + group.Count());
            Console.WriteLine("Voto medio degli omonimi: " + group.Average(s => s.MediaVoti));

        }
    }
    static void QueryJoin()
    {
        List<Assenza> assenzeList = new()
        {
            new() { ID = 1, Giorno = DateTime.Today, StudentID = 1 },
            new Assenza() { ID = 2, Giorno = DateTime.Today.AddDays(-1), StudentID = 1 },
            new Assenza() { ID = 3, Giorno = DateTime.Today.AddDays(-3), StudentID = 1 },
            new Assenza(){ID = 4, Giorno = new DateTime(2020,11,30), StudentID = 2 },
            new Assenza(){ID = 5, Giorno = new DateTime(2020,11,8), StudentID = 3 }
        };
        //intersezione tra due collection - Join 
        //vogliamo riportare il nome dello studente e le date delle sue assenze  
        //facciamo una join tra la lista degli studenti e la lista 
        // delle assenze degli studenti e poi facciamo la proiezione 
        // del risultato su un nuovo oggetto
        var innerJoinStudentiAssenze = studentList.Join(assenzeList,
            s => s.StudentID,
            a => a.StudentID,
            (s, a) => new { ID = s.StudentID, Nome = s.StudentName, GiornoAssenza = a.Giorno });

        foreach (var obj in innerJoinStudentiAssenze)
        {
            Console.WriteLine($"ID = {obj.ID}, Nome = {obj.Nome}, GiornoAssenza = {obj.GiornoAssenza.ToShortDateString()}");
        }
        ;
    }
    static void Main(string[] args)
    {
        studentList = InitLista();
        //QueryWhere();
        QueryOrdinamento();
        //QueryGroupBy();
        //QueryJoin();
        Console.ReadKey();
    }
}