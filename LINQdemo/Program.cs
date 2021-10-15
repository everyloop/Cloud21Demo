using System;
using System.Linq;

namespace LINQdemo
{
    class Program
    {
        static void Main(string[] args)
        {
			var people = new[] {
				new { firstName = "Fredrik", lastName = "Johansson", age = 40, length = 1.80, weight = 75 },
				new { firstName = "Maria", lastName = "Andersson", age = 42, length = 1.72, weight = 72 },
				new { firstName = "Anna", lastName = "Svensson", age = 22, length = 1.65, weight = 64 },
				new { firstName = "Per", lastName = "Svensson", age = 27, length = 1.87, weight =  80}
			}.ToList();

			people.Add(new { firstName = "Camilla", lastName = "Karlsson", age = 67, length = 1.70, weight = 82 });

			//var query = from p in people where p.age > 30 select p;

			var query = from p in people group p by p.lastName;



			/*
			var newList = people
				.Where(p => p.age > 25)
				.Select(p => new { name = $"{p.firstName} {p.lastName}", p.age, bmi = p.weight / Math.Pow(p.length, 2) })
				.ToList();

			foreach (var person in newList)
			{
				Console.WriteLine($"{person.name} BMI: {person.bmi:N2}");
			}
			*/
		}
    }
}
