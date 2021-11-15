using System;

namespace ConstructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            var personA = new Person("Fredrik", "Johansson");

            Console.WriteLine(personA.Name);
        }
    }

    class Animal
    {
        public string Description { get; set; }
        public Animal(string description)
        {
            Description = description;
        }

        public Animal()
        {

        }
    }

    class Person : Animal
    {
        public string FirstName { get; }
        public string LastName { get; set; }
        public string Title { get; set; }

        //public string Name 
        //{ 
        //    get
        //    {
        //        return $"{FirstName} {LastName}";
        //    }
        //}

        public string Name => $"{FirstName} {LastName}";

        public readonly int Age = 20;

        public Person() : this("Mr.", "Firstname", "Lastname")
        {
        }

        public Person(string firstName, int age) : base("Human")
        {
            FirstName = firstName;
            Age = age;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string title, string firstName, string lastName) 
        {
            Title = title;
            FirstName = firstName;
            LastName = lastName;
        }


    }
}
