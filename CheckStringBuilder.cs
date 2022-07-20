using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demowork1
{
    internal class CheckStringBuilder
    {
        static void Main(string[] args)
        {
            string str = "hello";
            str = str + "world";
            Console.WriteLine(str);
            StringBuilder sb = new StringBuilder("hello");
            sb.Append("java");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
