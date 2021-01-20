using Classes.Exercice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Exercice
{
    public class SchoolData
    {
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }
        public List<Class> Classes { get; set; }

        public SchoolData()
        {
            // Initialize with test data
            Students.AddRange(new List<Student>
            { 
                new Student("Whiteford", "Thomas", DateTime.Parse("05/25/2000")),
                new Student("Parks", "Erick", DateTime.Parse("07/11/2000")),
                new Student("Lee", "Mathew", DateTime.Parse("01/03/2001")),
                new Student("Smith", "Alice", DateTime.Parse("08/30/1995")),
                new Student("Hill", "Anna", DateTime.Parse("05/31/1999")),
                new Student("Weldon", "Max", DateTime.Parse("12/05/1998"))
            });
            Subject subject = new Subject("Maths");
            Classes.Add(new Class("Calculus 1", "Mr. Brown", subject, Students.Take(3).ToList()));
            Classes.Add(new Class("Calculus 2", "Mr. Monroe", subject, Students.Skip(3).ToList()));
        }

        public List<Student> GetStudentsFromClass(string className)
        {
            Class c = GetClass(className);
            if (c == null)
                throw new ArgumentNullException();
            return c.Students;
        }

        public Class GetClass(string className)
        {
            return Classes.SingleOrDefault(c => c.Name == className);
        }

        public List<Class> GetStudentClasses(Student student)
        {
            return Classes.Where(c => c.Students.Contains(student)).ToList();
        }

        public void CreateStudent(string fullName, string birthday, string[] classes)
        {
            string[] name = fullName.Split(new string[] { ", " }, StringSplitOptions.None);
            if (name.Length != 2)
                throw new ArgumentException();

            Student student = new Student(name[0], name[1], DateTime.Parse(birthday));
            Students.Add(student);

            foreach (string c in classes)
                GetClass(c).AddStudent(student);
        }

        public void EditStudent(Student student, string[] classNames)
        {
            List<Class> oldClasses = GetStudentClasses(student);
            List<Class> classes = new List<Class>();
            foreach (string c in classNames)
                classes.Add(GetClass(c));

            foreach (Class c in Classes)
            {
                if (oldClasses.Contains(c) && !classes.Contains(c))
                    c.RemoveStudent(student);
                else if (!oldClasses.Contains(c) && classes.Contains(c))
                    c.AddStudent(student);
            }
        }

    }
}
