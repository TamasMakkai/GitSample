using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World again!");

            do
            {
                Console.WriteLine("Press \"q\" to quit: ");
                Console.WriteLine();
            } while (Console.ReadKey().KeyChar != 'q');
        }
    }
}
