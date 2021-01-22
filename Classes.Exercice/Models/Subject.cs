using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Exercice.Models
{
    public class Subject
    {
        public string Name { get; private set; }

        public Subject(string name)
        {
            this.Name = name;
        }
    }
}
