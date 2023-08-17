using System;
using System.Data.Entity;

namespace CodeFirstNewDatabaseSample2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            using (var db = new SchoolContext())
            {
                //create and save a new student
                Console.WriteLine("Enter a name for a new student: ");
                var name = Console.ReadLine();
                Console.WriteLine("Enter the student's Birthday: ");
                var dateOfBirth = Console.ReadLine();

                var student = new Student { Name = name, DateOfBirth = dateOfBirth };
                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Insert a new student successfully");
                Console.ReadLine();
            }
        }

       
    }
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
