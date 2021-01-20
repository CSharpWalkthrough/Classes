using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Exercice.Models
{
    public class Student
    {
        private string lastName;
        private string firstName;
        private DateTime birthday;

        public Student(string lastName, string firstName, DateTime birthday)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.birthday = birthday;
        }

        public string FullName { 
            get
            {
                return firstName + ", " + lastName;
            } 
        }

        public int Age
        {
            get
            {
                // Save today's date.
                DateTime today = DateTime.Today;

                // Calculate the age.
                int age = today.Year - birthday.Year;

                // Go back to the year in which the person was born in case of a leap year
                if (birthday.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}
