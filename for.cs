using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" N = ");
            uint N = Convert.ToUInt32(Console.ReadLine());
            for (uint i = 1, j = 0; i <= N; i++)
            {
                Console.WriteLine(j += 2 * i - 1);
            }
            Console.ReadKey();
        }
    }
}
