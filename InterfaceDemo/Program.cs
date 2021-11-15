using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IStuffThatEats>();

            var myCar = new Car(); // { Year = 2017, Name = "BMW" };
            myCar.Year = 2017;
            myCar.Name = "BMW";

            //list.Add(myCar);

            list.Add(new Dog() { Name = "Vovve" });

            //list.Add(new Car("Volvo"));

            list.Add(new Cat() { Name = "Kitte" });

            foreach (IStuffThatEats item in list)
            {
                item.Eat();
            }

            Console.WriteLine();

            IStuffThatRuns runningItem = new Car() { Name = "Tesla" };

            runningItem.Run();

            Console.WriteLine();

            PrintGreeting(runningItem);

            PrintGreeting(new Dog() { Name = "Vovve2" });
        }

        static void PrintGreeting(IStuffThatRuns item)
        {
            Console.WriteLine($"Hello {item.Name}");
        }
    }

    interface IStuffThatRuns
    {
        public string Name { get; set; }
        public void Run();
    }

    interface IStuffThatEats
    {
        public string Name { get; set; }
        public void Eat();
    }

    class Car : IStuffThatRuns
    {
        public Car()
        {
            Name = "Default car";
        }

        public Car(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Year { get; set; }

        public void Run()
        {
            Console.WriteLine($"{Name} is running!");
        }
    }

    class Cat : IStuffThatRuns, IStuffThatEats
    {
        public string Name { get; set; }

        public void Run()
        {
            Console.WriteLine($"The cat {Name} is running!");
        }
        public void Eat()
        {
            Console.WriteLine($"The cat {Name} is eating!");
        }
        
    }

    class Dog : IStuffThatRuns, IStuffThatEats
    {
        public string Name { get; set; }

        public void Run()
        {
            Console.WriteLine($"The dog {Name} is running!");
        }

        public void Eat()
        {
            Console.WriteLine($"The dog {Name} is eating!");
        }

    }

}
