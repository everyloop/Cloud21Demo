using System;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new[] {
                new { name = "Fredrik", age = 40, length = 1.80 },
                new { name = "Maria", age = 42, length = 1.72 },
                new { name = "Anna", age = 22, length = 1.65 },
                new { name = "Per", age = 27, length = 1.87 }
            };

            foreach (var p in people)
            {
                Console.WriteLine($"{p.name} is {p.age} years old.");
            }

            Console.WriteLine();

            var person = new
            {
                name = "Anders Eriksson",
                age = 45,
                contactInfo = new { eMail = "anders@gmail.com", phone = "07023485734" }
            };

            Console.WriteLine(person);
        }
    }
}
