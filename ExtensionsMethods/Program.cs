using System;

namespace ExtensionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!".Title());

            string myString = "freDRIk";

            Console.WriteLine(myString.Substring(2,2).Title());

            int myInt = 5;

            Console.WriteLine(myInt.Add(3));

            Console.WriteLine("Detta är en mening!".GetWord(1));

        }
    }

    static class ExtensionMethods
    {
        public static string Title(this string text)
        {
            var firstLetter = text.Substring(0, 1);
            var rest = text.Substring(1);
            return firstLetter.ToUpper() + rest.ToLower();
        }

        public static int Add(this int number, int addValue)
        {
            return number + addValue;
        }

        public static string GetWord(this string myString, int myInt)
        {
            string[] wordlist = myString.Split(" ");

            if (myInt < 0 || myInt >= wordlist.Length) throw new ArgumentOutOfRangeException("Word does not exist.");

            return wordlist[myInt];
        }
    }
}
