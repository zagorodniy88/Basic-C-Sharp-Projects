namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main()
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
                Console.WriteLine(stud.StudentName + " successfully added");
                Console.ReadLine();
            }
        }
    }
}