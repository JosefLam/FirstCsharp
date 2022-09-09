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
            Console.WriteLine('how many pizzas?');
            int answer = int.Parse(Console.ReadLine());

            for (int i = 0; i < answer; i++) ;
            {
                Console.WriteLine('eat pizza number' + (i+1));
            }

            Console.ReadLine;
        }
    }
}
