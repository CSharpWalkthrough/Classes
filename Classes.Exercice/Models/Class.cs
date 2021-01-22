using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Exercice.Models
{
    public class Class
    {
        private string name;
        private string teacher;

        private Subject subject;
        private List<Student> students;

        public Class(string name, string teacher, Subject subject, List<Student> students)
        {
            this.name = name;
            this.teacher = teacher;
            this.subject = subject;
            this.students = students;
        }

        public string Name { get { return name; } }
        public string Teacher { get { return teacher; } }
        public string Subject {
            get 
            { 
                return subject.Name; 
            }
        }
        public List<Student> Students { 
            get 
            { 
                return students.OrderBy(s => s.FullName).ToList(); 
            }
        }

        #region Methods

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        #endregion
    }
}
