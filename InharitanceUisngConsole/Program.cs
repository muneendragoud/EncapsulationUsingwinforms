using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InharitanceUisngConsole
{

    public class Parent
    {
        private int priA { get; set;}
        public int pubA { get; set;}

        public Parent()
        {

        }
        public Parent(int pria,int puba)
        {
            this.priA = pria;
            this.pubA = puba;
        }
    }
    public class cChild:Parent
    {
        private int priB { get; set;}
        protected int proA { get; set;}

        public cChild()
        {

        }
        public cChild(int prib,int proa,int puba)
        {
            this.priB = prib;
            this.pubA = puba;
            this.proA = proa;
        }
    }

   public class InharitanceConcept
    {
        static void Main(string[] args)
        {
            Parent c = new cChild();
           
        }
    }
}
