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


            if (!GetYesOrNo()) // == false
            {
                Console.WriteLine("Plug in lamp");
            }
            else
            {
                Console.WriteLine("Bulb burned out?");

                if (!GetYesOrNo()) // == false
                {
                    Console.WriteLine("Repair lamp");
                }
                else
                {
                    Console.WriteLine("Replace bulb");

                }

            }


            Console.WriteLine("Press a key to finish");
            Console.ReadKey();
        }

        static void InvalidInput()
        {
            Console.WriteLine("I didn't understand that. I'm going to assume you mean no.");
        }

        static bool GetYesOrNo()
        {
            string answer = Console.ReadLine();
            if (answer.ToLower() == "no")
            {
                return false;
            }
            else if (answer.ToLower() == "yes")
            {
                return true;
            }
            else
            {
                InvalidInput();
                return false;
            }
        }


        //static bool GetYesOrNo()
        //{
        //    string answer = Console.ReadLine();

        //    if (answer.ToLower() == "no")
        //    {

        //    }
        //    else
        //    {

        //    }
        //}
    }
}
