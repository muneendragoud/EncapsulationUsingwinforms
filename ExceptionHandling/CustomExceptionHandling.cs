using System;

namespace ExceptionHandling
{
    public class CustomExceptionHandling
    {
        static void Main(string[] args)
        {
            int d, div, res;
            div = Int32.Parse(Console.ReadLine());
            d = Int32.Parse(Console.ReadLine());
            try
            {
                if (div == 0)
                {
                    throw new CustomException();
                }
            }
            catch (CustomException e)
            {
                e.DivisionException();
            }

            res = d / div;
            Console.WriteLine("Result:{0}", res);
            Console.ReadLine();
        }
    }
}
