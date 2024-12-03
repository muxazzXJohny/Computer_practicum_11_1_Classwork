using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp03._12._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String st1 = "Это первая строка";
            String st2 = "Это вторая строка";
            Console.WriteLine($"Вывод перед обменом:{st1} + {st2}");
            Swap(ref st1, ref st2);
            Console.WriteLine($"Вывод после обмена:{st1}+{st2}");
            Console.ReadKey();
        }
        static void Swap(ref string x, ref string y)
        {
            String p = x;
            x = y;
            y = p;
        }

    }
}
