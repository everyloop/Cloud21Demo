using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat() { Name = "Felix" };
            myCat.Eat();
            myCat.SayMeow();
            myCat.Drink();

            Console.WriteLine();

            Dog myDog = new Dog() { Name = "Karo" };
            myDog.Eat();
            myDog.SayWoff();
            myDog.Drink();
        }
    }

    abstract class Animal
    {
        public string Name { get; set; }
        public abstract void Eat();

        public virtual void Drink()
        {
            Console.WriteLine($"The animal {Name} is drinking now!");
        }
        
    }

    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine($"The dog {Name} is eating now!");
        }

        public void SayWoff()
        {
            Console.WriteLine("Woff!");
        }

        public override void Drink()
        {
            Console.WriteLine($"The dog {Name} starts drinking!");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The dog {Name} is still drinking!");
            }
            Console.WriteLine($"The dog {Name} is done drinking!");
        }

    }


    class Cat : Animal
    {
        public void SayMeow()
        {
            Console.WriteLine("MEOW!");
        }

        public override void Eat()
        {
            Console.WriteLine($"The cat {Name} is eating now!");
        }
    }
}
