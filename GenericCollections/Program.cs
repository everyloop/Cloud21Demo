using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var lookupDays = new Dictionary<string, DateTime>();

            lookupDays.Add("today", DateTime.Now);
            lookupDays.Add("yesterday", DateTime.Now.AddDays(-1));
            lookupDays.Add("tomorrow", DateTime.Now.AddDays(1));

            /*
            Console.Write("Enter english word: ");
            var word = Console.ReadLine();
            */

            foreach (KeyValuePair<string, DateTime> day in lookupDays)
            {
                Console.WriteLine($"{day.Key}: {day.Value.DayOfWeek}");
            }
        }

        static void listExample()
        {
            var names = new List<string>();

            names.Add("Fredrik");
            names.Add("Anna");
            names.Add("Anders");
            names.Add("Kalle");

            //names.Clear();
            /*
            var input = Console.ReadLine();

            while (!String.IsNullOrWhiteSpace(input))
            {
                names.Add(input);
                input = Console.ReadLine();
            }
            */

            for (int i = 0; i <= 2; i++)
            {
                names.RemoveAt(i);
            }

            Console.WriteLine(names.Count);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
