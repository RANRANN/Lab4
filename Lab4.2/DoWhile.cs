using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n;
            int a = 0;
            int b = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    a++;
                }
                else if (n < 0)
                {
                    b++;
                }
            } while ( n != 0);
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            Console.ReadKey();
        }
    }
}
