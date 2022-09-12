using System;                                   //import
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
            Console.WriteLine("how many pizzas?");          //asks questions
            int answer = int.Parse(Console.ReadLine());             //take input
            if (answer >1)
            {
                Console.WriteLine("Youre going to put on weight");          //outputs based on response
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
