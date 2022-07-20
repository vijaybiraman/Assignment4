using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumber
{
    internal class SwapNumber
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine("x : " + x);
            Console.WriteLine("y : " + y);
            SwapNumbers(ref x, ref y);
            Console.WriteLine("x : " + x);
            Console.WriteLine("y : " + y);

            Console.ReadLine();
        }

        static void SwapNumbers(ref int x,ref int y)
        {
           int z = x + y;
            x = z - x;
            y = z - y;
        }
    }

}
