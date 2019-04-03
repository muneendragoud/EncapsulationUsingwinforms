using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InharitanceUisngConsole
{

  abstract  class Figure
    {
        public int Dimension;
        public abstract double Area();
        public abstract  double Perimeter(); 
    }
     class Circle : Figure
    {
        public override double Area()
        {
            return Math.PI * Dimension * Dimension;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Dimension;
        }
    }

    public class AbstractClass
    {
        static void Main(string[] args)
        {
            Figure fig;
            fig = new Circle();
            fig.Dimension = 3;
            double peri = fig.Perimeter();
            double are = fig.Area();
            Console.WriteLine("Area of Circle"+are);
            Console.WriteLine("Perimeter of Circle"+peri);
            Console.ReadLine();
        }
    }
}
