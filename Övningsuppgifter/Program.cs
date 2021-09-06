using System;

namespace Övningsuppgifter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            string searchString = "chuck";

            Console.WriteLine($"Length: {text.Length}");

            for (int i = 0; i < text.Length; i++)
            { 
                if (i <= 1 || i >= text.Length - 1)
                {
                    Console.ResetColor();
                    Console.Write(text[i]);
                    continue;
                }


                if (text[i] == searchString[0] && text[i+1] == searchString[1] && text[i+2] == searchString[2] && text[i + 3] == searchString[3] && text[i + 4] == searchString[4])
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    //Alternativ 1
                    //Console.Write(searchString);

                    //Alternativ 2
                    for (int j = i; j < i + searchString.Length; j++)
                    {
                        Console.Write(text[j]);
                    }

                    i += searchString.Length - 1;

                    /*
                    //Alternativ 3:
                    Console.Write(text[i]);
                    Console.Write(text[i + 1]);
                    Console.Write(text[i + 2]);
                    Console.Write(text[i + 3]);
                    Console.Write(text[i + 4]);

                    //Alternativ 4:
                    for (int k = 0; k < searchString.Length; k++)
                    {
                        Console.Write(searchString[k]);
                    }

                    //Alternativ 5:
                    Console.Write(searchString[0]);
                    Console.Write(searchString[1]);
                    Console.Write(searchString[2]);
                    Console.Write(searchString[3]);
                    Console.Write(searchString[4]);
                    */
                }
                else
                {
                    Console.ResetColor();
                    Console.Write(text[i]);
                }
                //Console.WriteLine($"{11-i}: {text[11-i]}");
            }

            Console.ResetColor();
        }
    }
}
