using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("\nVehicle data : ");
            Console.WriteLine("\n- name : " + Name);
            Console.WriteLine("\n- Speed : " + Speed);
            Console.WriteLine("\n- Tyres : " + Tyres);
        }
    }

    class ToString
    {

        private string[] strings = new string[100];

        public string this[int i]
        {
            get
            {
                return strings[i];
            }
            set
            {
                strings[i] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            ToString tostring = new ToString();
            tostring[0] = "Mopo";
            tostring[1] = "Traktori";
            tostring[2] = "Skoda";


            Console.WriteLine(tostring[0]);

            Vehicle mopo = new Vehicle();
            mopo.Name = "Derbi 50cc";
            mopo.Speed = 45;
            mopo.Tyres = 2;

            Vehicle traktori = new Vehicle();
            traktori.Name = "New Holland";
            traktori.Speed = 60;
            traktori.Tyres = 4;

            mopo.PrintData();
            traktori.PrintData();
            Console.ReadLine();
           


        }  
    }
}
