using System;

namespace Loops__23Aug_
{
    class Program
    {
        static int b = 3;

        static void Main(string[] args)
        {
            //DoWhileExample();
            //ForLoopExample();
            //NestedForLoops();
            Uppgift11();
        }

        static void Uppgift11()
        {
            /*
            for (int i = 1; i <= 9; ++i)
            {
                for (int col = 1; col <= i; ++col)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
            */
            /*{
                int i = 1;
                while (i <= 9)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.WriteLine(i);
                    }
                    i++;
                }
            }*/
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
        }

        static void ForEachLoop()
        {
            string text = "Hejsan";

            foreach (char bokstav in text)
            {
                Console.WriteLine(bokstav);
            }

    
            string[] strings = { "Hejsan", "hoppsan" };

            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }
        
        static void NestedForLoops()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int y = 1; y <= 5; y++)
                {
                    for (int x = 1; x <= 5; x++)
                    {
                        Console.Write("O");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static void ForLoopExample()
        {
            for (int i = 5; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void DoWhileExample()
        {
            int i = 0;

            do
            {
                i++;
                Console.WriteLine(i);

            } while (i < 10);
        }

        static void WhileExample()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.Write("x");

                int j = 1;
                while (j <= 3)
                {
                    Console.Write("x");
                    j++;
                }

                Console.WriteLine();

                i++;
            }
        }

        static void Loop1()
        {
            Console.Write(b);

            bool myBool = true;

            int i = 0;

            while (true)
            {
                i++;

                if (i == 5 || i == 8)
                {
                    continue;
                }


                if (i > 10)
                {
                    break;
                }

                Console.WriteLine(i);

            }

            Console.WriteLine("The end!");

        }
    }
}
