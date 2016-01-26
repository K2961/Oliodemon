using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person somebody = new Person();
            somebody.FirstName = "Joe";
            somebody.LastName = "Dirt";
            somebody.Address = "Unknown";
            somebody.Age = 29;
            somebody.PhoneNumber = "5465446548645465";
            Console.WriteLine(somebody.ToString());

            Teacher teacher = new Teacher();
            teacher.FirstName = "Teppo";
            teacher.LastName = "Konsoli";
            teacher.Address = "piippukatu 2";
            teacher.Age = 40;
            teacher.PhoneNumber = "010-12345678";
            teacher.Room = "D100";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Minna", "Husso", "J9090");
            student.Address = "kilju 3";
            student.Age = 20;
            student.PhoneNumber = "040-12345678";
            Console.WriteLine(student.ToString());

            somebody.PersonMethod();
            teacher.PersonMethod();
            teacher.TeacherMethod();
            student.PersonMethod();
            student.StudentMethod();

            // nonono!
            //teacher.StudentMethod();
            //student.TeacherMethod();

            Console.ReadLine();
        }
    }
}
