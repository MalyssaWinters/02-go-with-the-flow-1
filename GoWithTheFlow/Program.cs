using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWithTheFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lamp doesn't work");

            Console.WriteLine("Lamp plugged in?");

            string answer = Console.ReadLine();

            if (answer.ToLower() == "no")
            {
                Console.WriteLine("Plug in lamp");
            }   
            else
            {
                Console.WriteLine("Bulb burned out?");
                answer = Console.ReadLine();

                if (answer.ToLower() == "no")
                {
                    Console.WriteLine("Repair lamp");
                }
                else
                {
                    Console.WriteLine("Replace bulb");
                }
            }

            Console.ReadKey();
        }
    }
}
