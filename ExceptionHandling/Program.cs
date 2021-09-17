using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumberAsText(50);
            
            try
            {

                // FormatException
                int myInt = int.Parse("fem");

                // DivideByZeroException
                int x = 0;
                int y = 5 / x;

                // IndexOutOfRangeException
                int[] myArray = new int[5];
                Console.WriteLine(myArray[6]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Bad format: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unkown error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("The end!");
            }


            // IndexOutOfRangeException
            //int[] myArray = new int[5];
            //Console.WriteLine(myArray[6]);

            // FormatException
            // int myInt = int.Parse("fem");

            // DivideByZeroException
            // int x = 0;
            // int y = 5 / x;

            // OverFlowException
            //checked
            //{
            //    byte b = 255;
            //    b += 1;
            //}

            // int myInt = 5;
            // myInt += int.Parse("5");
            // myInt += int.Parse("5000000000");

            // StackOverFlowException
            // Recursion / Rekursiva anrop
            // MyMethod();

            // OutOfMemoryException
            //int[] i = new int[1000000000];
            //int[] j = new int[1000000000];
            //int[] k = new int[1000000000];
            //int[] l = new int[1000000000];
            //int[] m = new int[1000000000];

        }

        static void PrintNumberAsText(int n)
        {
            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };            
            
            if (n >= 0 && n <= 9)
            {
                Console.WriteLine(numbers[n]);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Number must be between 0 and 9.");
            }
        }

        static void MyMethod()
        {
            Console.WriteLine("Hello World!");
            MyMethod2();
        }

        static void MyMethod2()
        {
            Console.WriteLine("Hello Again");
            MyMethod();
        }

    }
}
