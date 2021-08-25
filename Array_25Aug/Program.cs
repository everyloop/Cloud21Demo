using System;

namespace Array_25Aug
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string name = "Fredrik";

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            */
            ArrayExamples();

        }

        static void ArrayExamples()
        {
            string myName = "Fredrik";

            string[] firstNames = { "Fredrik", "Anna", "Anders", "Erik", "Maria", "Kalle", "Gunnar" };
            string[] lastNames = new string[firstNames.Length];

            //firstNames[6] = "Tomas";

            Console.WriteLine($"Number of first names:{firstNames.Length}");

            for (int i = 0; i < firstNames.Length; i++)
            {
                lastNames[i] = $"Johansson{i + 1}";
                //Console.WriteLine(i + ": " + names[i]);
                Console.WriteLine($"Detta är index {i} med värde {firstNames[i]}");
                Console.WriteLine($"{firstNames[i]} {lastNames[i]}");
            }



            //Console.WriteLine("Rad1\nRad2\tEfter tabben\\");
            //Console.WriteLine("c:\\users\\fredrik\\source\\repos");
            //Console.WriteLine(@"c:\users\fredrik\source\repos");
        }
    }
}
