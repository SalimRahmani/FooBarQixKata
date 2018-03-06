using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQixKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t╔═══════════════════════════════════════════╗");
            Console.WriteLine("\t Welcome into my Fancy FooBarQix Console App");
            Console.WriteLine("\t╚═══════════════════════════════════════════╝");

            for(int i = FooBarQix.Min; i <= FooBarQix.Max; i++)
            {
                Console.WriteLine(new FooBarQix().Transform(i));
            }

            Console.ReadLine();
        }
    }
}
