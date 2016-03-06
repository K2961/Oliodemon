using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Task7
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        
        public Person()
        {

        }

        public Person(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }

        public override string ToString()
        {
            return "\nName: " + Name + "\nLastName: " + LastName + "\nAddress: " + Address + "\nAge: " + Age;
        }
    }
}
