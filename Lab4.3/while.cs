using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A = ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("C = ");
            int C = Convert.ToInt32(Console.ReadLine());
            int S1 = A * B;
            Console.WriteLine("S1 = {0}",S1);
            int S2 = C * C;
            Console.WriteLine("S2 = {0}",S2);
            int n = 0;
            while (S1 - S2 >= 0)
            {
                S1 -= S2;
                n++;
            }
            Console.WriteLine("n = {0}", n);
            Console.ReadKey();
        }
    }
}
