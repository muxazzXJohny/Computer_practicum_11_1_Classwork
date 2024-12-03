using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11_2_classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String st1 = "1";
            String st2 = "2";
            String st3 = "3";
            String st4 = "4";
            Console.WriteLine($"Вывод перед обменом:{st1} {st2} {st3} {st4}");
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

