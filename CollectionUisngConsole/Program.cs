using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionUisngConsole
{
    class CollectionProgram
    {
        static void Main(string[] args)
        {
           
            ArrayList arrlst = new ArrayList();
            arrlst.Add("A");
            arrlst.Add("A");
            arrlst.Add("10");
            arrlst.Add("E");

            string[] str =(string[])arrlst.ToArray(typeof(string));

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.ReadLine();
        }
    }

    class HastableProgram
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(10, "ASS");
            ht.Add(20, 'A');
            ht.Add(30, 222);

            foreach (DictionaryEntry  de in ht)
            {
                Console.WriteLine(de.Key+" -"+de.Value);
            }
            Console.ReadLine();
        }

    }


    class Employee
    {

        public int Id;
        public string Name;

        static void Main(string[] args)
        {
            List<Employee> lstEmp = new List<Employee>();
            lstEmp.Add(new Employee { Id = 1, Name = "Venu" });
            lstEmp.Add(new Employee {Id=2,Name="Rammu"});
            lstEmp.Add(new Employee {Id=3,Name="Rose" });

            foreach (Employee item in lstEmp)
            {
                Console.WriteLine(item.Id+"-"+item.Name);
            }
            Console.WriteLine();

            IEnumerator<Employee> emp = lstEmp.GetEnumerator();
             while(emp.MoveNext())
            {
                Employee ee = emp.Current;
                Console.WriteLine(ee.Id+"-"+ee.Name);
            }
            Console.ReadLine();
        }
    }
}
