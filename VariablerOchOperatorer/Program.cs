using System;

namespace VariablerOchOperatorer
{
    class Program
    {
        static void Main(string[] args)
        {/*
            bool isAwesome = false;

            Console.Write("Enter your namne: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);

            if (name == "Fredrik") 
            {
                Console.WriteLine("You are Fredrik");
            }
            else
            {
                Console.WriteLine("You are not Fredrik");
            }

            if (isAwesome)
            {
                Console.WriteLine("Your are awesome!");
            }
            else
            {
                Console.WriteLine("Your are not so awesome, sorry!");
            }
            */
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The number times two is: " + number * 2);
        }
    }
}
