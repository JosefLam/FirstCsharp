using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many pizzas?");
            int answer = int.Parse(Console.ReadLine());
            if (answer < 1)
            {
                Console.WriteLine("Youre going to put on weight");
            }

            Console.ReadLine();
        }
    }
}
