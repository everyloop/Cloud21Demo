using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Cat myCat = new Cat() { Name = "Felix" };
            myCat.Eat();
            myCat.SayMeow();
            myCat.Drink();

            Console.WriteLine();

            Dog myDog = new Dog() { Name = "Karo" };
            myDog.Eat();
            myDog.SayWoff();
            myDog.Drink();

            Console.WriteLine();

            Console.WriteLine(myDog);
            */


            Animal[] animals = new Animal[3];
            animals[0] = new Cat() { Name = "Felix" };
            animals[1] = new Dog() { Name = "Karo" };
            animals[2] = new Cat() { Name = "Findus" };

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
                animal.Eat();

                Cat cat = animal as Cat;

                if (cat != null)
                {
                    cat.SayMeow();
                }
            }
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
            Console.WriteLine($"{Name} says Woff!");
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

        public override string ToString()
        {
            return $"This is {Name}!";
        }
    }


    class Cat : Animal
    {
        public void SayMeow()
        {
            Console.WriteLine($"{Name} says MEOW!");
        }

        public override void Eat()
        {
            Console.WriteLine($"The cat {Name} is eating now!");
        }
    }
}
