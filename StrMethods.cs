using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsMethods
{
    internal class StrMethods
    {
        static void Main(string[] args)
        {
            string str = "helloWorld";
            Console.WriteLine(str.IndexOf('l'));
            Console.WriteLine(str.LastIndexOf('o'));
            Console.WriteLine(str.StartsWith("s"));
            Console.WriteLine(str.EndsWith("l"));
            Console.WriteLine(str.Contains('l'));
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }
            Console.WriteLine(str.Substring(1, ch.Length - 1));
            string str1 = "";
           str1= str1+str.Concat("America");
            Console.WriteLine(str1.ToString());
            Console.ReadLine();
        }
    }
}
