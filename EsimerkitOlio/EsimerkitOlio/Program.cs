using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimerkitOlio
{
    //class Car
    /*{
        public Car(string model, int cc)
        {
            this.model = model;
            this.cc = cc;
        }

        public int EngineSize
        {
            get { return cc; }
        }
        

        public string ModelProperty
        {
            get { return model; }
            set{ model = value; }
        }
        private string model;
        private readonly int cc;
    }*/
    struct Point
    {
        public int x;
        public int y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Car toyota = new Car("avensis", 1895);
            toyota.ModelProperty = "911";

            Console.WriteLine("This toyota model is: " + toyota.ModelProperty);
            Console.WriteLine("This toyota engine size is: " + toyota.EngineSize);
            Console.ReadLine();*/

            Point coordinate;
            coordinate.x = 100;
            coordinate.y = 50;

            ModifyPoint(coordinate);

            Console.WriteLine("Coordinate is: " + coordinate.x + "," + coordinate.y);
            Console.ReadLine();
        }
        static void ModifyPoint(Point p)
        {
            p.x += 500;
            p.y += 1500;
        }
    }
}
