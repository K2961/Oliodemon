using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_Harjoitus_1
{
    class Person
    {
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public Person(string SSN , string firstName, string lastName, int age, int weigth, int heigth) {
            this.SSN = SSN;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Weight = weigth;
            Height = heigth;
        }
        public override string ToString()
        {
                return "\nFirstName: " + FirstName + "\nLast Name: " + LastName + "\nSSN: " + SSN + "\nAge: " + Age + "\nWeight: " + Weight + "\nHeight: " + Height + "\n";
        }
    }
}
