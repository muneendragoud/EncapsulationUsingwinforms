
using System;

namespace PloymorphsimConsole
{
    interface IFigure
    {
        int Dimension { get; set; }
        double Area();
        double Perimeter();
    }

    public class Circle : IFigure
    {
        private int _Radius;
        public int Dimension
        {
            get
            {
                return _Radius;
            }
            set
            {
                _Radius = value;
            }
        }

        public double Area()
        {
            return Math.PI * _Radius * _Radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * _Radius;
        }
    }

    public class Square : IFigure
    {
        private int _length;
        public int Dimension
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }

        public double Area()
        {
            return _length * _length;
        }

        public double Perimeter()
        {
            return 4 * _length;
        }
    }


    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            IFigure fig;
            fig = new Circle();
            fig.Dimension = 10;
            double are = fig.Area();
            double peri = fig.Perimeter();
            Console.WriteLine("Area of Circle: " + are);
            Console.WriteLine("Perimeter of Cirecle: " + peri);
            fig = new Square();
            fig.Dimension = 4;
            double SA = fig.Area();
            double SP = fig.Perimeter();
            Console.WriteLine("Square Area: "+SA);
            Console.WriteLine("Square Perimeter: "+SP);
            Console.ReadLine();
        }
    }
}
