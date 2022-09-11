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
            if (answer >1)
            {
                Console.WriteLine("Youre going to put on weight");
            }
            if (answer==1)
            {
                Console.WriteLine("thats pretty standard");
            }
            if (answer <=0)
            {
                Console.WriteLine("you need to eat something");
            }

            Console.ReadLine();
        }
    }
}
