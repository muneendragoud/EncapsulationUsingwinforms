using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            try
            {
                int n1, n2;
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine("Result " + result);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.InnerException);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Good");
            }
            Console.ReadLine();
        }
    }
}
