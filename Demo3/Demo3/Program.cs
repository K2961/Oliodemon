using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_Task4
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public override string ToString()
        {
            return "\nVehicle data : " + "\n- name : " + Name + "\n- Speed : " + Speed + "\n- Tyres : " + Tyres;
        }

       /* public void PrintData()
        {
            Console.WriteLine("\nVehicle data : ");
            Console.WriteLine("\n- name : " + Name);
            Console.WriteLine("\n- Speed : " + Speed);
            Console.WriteLine("\n- Tyres : " + Tyres);
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle mopo = new Vehicle();
            mopo.Name = "Derbi 50cc";
            mopo.Speed = 45;
            mopo.Tyres = 2;

            Vehicle traktori = new Vehicle();
            traktori.Name = "New Holland";
            traktori.Speed = 60;
            traktori.Tyres = 4;

            //mopo.PrintData();
            //traktori.PrintData();

            Console.Write(mopo.ToString());
            Console.Write(traktori.ToString());
            Console.ReadLine();
           


        }  
    }
}
