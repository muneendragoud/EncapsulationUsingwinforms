using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PloymorphsimConsole
{
    interface IA1
    {
        void M1();
        void M2();
        void M4();
    }
    interface IA2
    {
        void M3();
        void M4();
    }
    class CA : IA1, IA2
    {
        public void M1()
        {
            Console.WriteLine("M1");
        }

        public void M2()
        {
            Console.WriteLine("M2");
        }

        public void M3()
        {
            Console.WriteLine("M3");
        }

        public void M4()
        {
            Console.WriteLine("M4");
        }
    }

    class MultipleImplementations
    {
        static void Main(string[] args)
        {
            IA1 a;
            IA2 b;

            a = new CA();

            a.M1();
            a.M2();
            a.M4();

            b = new CA();
            b.M3();
            b.M4();
            Console.ReadLine();
        }
    }
}
