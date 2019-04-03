using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InharitanceUisngConsole
{

    public class Parent
    {
        private int priA;
        public int pubA;
        protected int proA;

        public Parent()
        {

        }
        public Parent(int a,int b,int c)
        {
            this.priA = a;
            this.pubA = b;
            this.proA=c;
        }
    }
    public class cChild:Parent
    {
        public int pubB;
        public cChild()
        {

        }
        public cChild(int a,int b,int c,int d)
            :base(a,b,c)
        {
            this.pubB = d;
        }

        public void GetAll()
        {
            proA = 10;
            pubB = 80;
            pubA = 45;
        }

    }

   public class InharitanceConcept
    {
        static void Main(string[] args)
        {
            cChild c = new cChild();
            c.GetAll();
            Console.ReadLine();
        }
    }
}
