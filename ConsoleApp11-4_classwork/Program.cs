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
            int a = Input("Введите 1 число:");
            int b = Input("Введите 2 число:");
            int c = Input("Введите 3 число:");
            int d = Input("Введите 4 число:");

            Console.WriteLine($"до изменений {a} {b} {c} {d}");
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            Console.Write($"после изменений {a} {b} {c} {d}");
            Console.ReadKey();
        }
        static void Swap (ref int a, ref int b)
        {
            int p = a;
            a = b;
            b = p;
        }
        static int Input(string a)
        {
            Console.Write(a);
            return int.Parse(Console.ReadLine());
        }
    }

    }

