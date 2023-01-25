using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityConsoleApp.Models
{
    internal class Person : Entity
    {
        
        internal string FirstName { get; set; }

        internal string LastName { get; set; }

        internal string FatherName { get; set; }

        internal int Age { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, FullName: {FirstName} {LastName} {FatherName}, Age: {Age}";
        }
    }
}
