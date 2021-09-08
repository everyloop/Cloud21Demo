using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Felix", 10.2, "hejsan");
            Cat myOtherCat = new Cat("Findus", 8.7, "abc123");

            //myCat.name = "Felix";
            //myCat.weight = 5.3;

            Console.WriteLine($"My cat's name is {myCat.name} and his weight is {myCat.weight}");
            Console.WriteLine($"My other cat's name is {myOtherCat.name} and his weight is {myOtherCat.weight}");

            //myOtherCat.secretPassword = "newPassword";
            myOtherCat.name = "Pelle";
            myOtherCat.SetPassword("myNewPassword");

            Console.WriteLine($"My cat's name is {myCat.name} and his weight is {myCat.weight}");
            Console.WriteLine($"My other cat's name is {myOtherCat.name} and his weight is {myOtherCat.weight}");

            Console.WriteLine(myCat.TellSecretPassword());
            Console.WriteLine(myOtherCat.TellSecretPassword());

            Console.WriteLine();

            Person PersonA = null;

            PersonA = new Person();
            PersonA.SetFirstName("Fredrik");
            PersonA.LastName = "Johansson";
            PersonA.length = 1.80;
            


            Person PersonB = new Person() { length = 1.95, weight = 92 };

            //string firstName = PersonA.GetFirstName();
            //PersonB.SetFirstName(firstName + "2");
            PersonB.SetFirstName(PersonA.GetFirstName());

            //string lastName = PersonA.LastName;
            //PersonB.LastName = lastName;
            PersonB.LastName = PersonA.LastName;

            PersonB.PrintGreeting();
            PersonA.PrintGreeting();
            PersonB.PrintGreeting();

            Console.WriteLine($"PersonB BMI = {PersonB.BMI}");
        }
    }


}
