using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
   public class CustomException:ApplicationException
    {
        public void NoneOfZero()
        {
            Console.WriteLine("Nothing");
        }
        public void DivisionException()
        {
            Console.WriteLine("Exception occured, divisor should not be zero");
            Console.ReadLine();
        }
    }
}
