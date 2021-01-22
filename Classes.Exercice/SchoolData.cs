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
        private List<Subject> Subjects { get; set; }
        private List<Student> Students { get; set; }
        private List<Class> Classes { get; set; }

        public SchoolData()
        {
            InitializeData();
        }

        #region InitializeData
        private void InitializeData()
        {
            // Initialize with test data
            Students = new List<Student>();
            Students.AddRange(new List<Student>
            {
                new Student("Whiteford", "Thomas", DateTime.Parse("05/25/2000")),
                new Student("Parks", "Erick", DateTime.Parse("07/11/2000")),
                new Student("Smith", "Emily", DateTime.Parse("01/03/2001")),
                new Student("James", "Bratt", DateTime.Parse("08/30/1995")),
                new Student("Peterson", "Lily", DateTime.Parse("05/31/1999")),
                new Student("Lee", "Mathew", DateTime.Parse("01/03/2001")),
                new Student("Smith", "Alice", DateTime.Parse("08/30/1995")),
                new Student("Hill", "Anna", DateTime.Parse("05/31/1999")),
                new Student("Weldon", "Max", DateTime.Parse("12/05/1998"))
            });

            Subject maths = new Subject("Maths");
            Subject english = new Subject("English");
            Subject french = new Subject("French");

            Subjects = new List<Subject>();
            Subjects.Add(maths);
            Subjects.Add(english);
            Subjects.Add(french);

            Classes = new List<Class>();
            Classes.Add(new Class("Calculus 1", "Mr. Brown", maths, Students.Take(3).ToList()));
            Classes.Add(new Class("Calculus 2", "Mr. Monroe", maths, Students.Skip(3).ToList()));

            Classes.Add(new Class("Learning English from Scratch", "Mr. Roy", english, Students.Skip(4).ToList()));
            Classes.Add(new Class("Littérature française", "Mr. Tremblay", french, Students.Take(5).ToList()));
        }
        #endregion

        public Student GetStudent(string fullName)
        {
            return Students.SingleOrDefault(s => s.FullName == fullName);
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

        public string[] GetAllClassesText()
        {
            return Classes.Select(c => c.Name).ToArray();
        }

        public List<Class> GetStudentClasses(Student student)
        {
            return Classes.Where(c => c.Students.Contains(student)).ToList();
        }

        public void CreateStudent(string firstName, string lastName, string birthday, List<string> classes)
        {
            Student student = new Student(firstName, lastName, DateTime.Parse(birthday));
            Students.Add(student);

            foreach (string c in classes)
                GetClass(c).AddStudent(student);
        }

        public void EditStudent(Student student, List<string> classNames)
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
