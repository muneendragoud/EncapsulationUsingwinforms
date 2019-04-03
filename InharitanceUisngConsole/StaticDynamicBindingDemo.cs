using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InharitanceUisngConsole
{
   public class PParent
    {
        public virtual void Methods()
        {
            Console.WriteLine("Parent");
        }
    }
   public class CChild:PParent
    {
        public new  void Methods()
        {
            Console.WriteLine("Child");
        }
    }

   public class StaticDynamicBindingDemo
    {
        static void Main(string[] args)
        {
            CChild c = new CChild();
            c.Methods();
            //PParent p = new CChild();
            //p.Methods();
            Console.ReadLine();
        }
    }
}
