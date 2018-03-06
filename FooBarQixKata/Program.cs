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

            while (true)
            {
                try
                {
                    Console.Write("Please enter a number between 1 and 100: ");
                    string numberStr = Console.ReadLine();
                    int number = Convert.ToInt32(numberStr);
                    Console.WriteLine(new FooBarQix().Transform(number));
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
