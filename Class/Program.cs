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
        }
    }

    class Cat
    {
        public string name;
        public double weight;
        private string secretPassword;

        public Cat()
        {
            this.name = "Default name";
        }

        public Cat(string name)
        {
            this.name = name;
        }

        public Cat(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public Cat(string name, double weight, string password)
        {
            this.name = name;
            this.weight = weight;
            this.secretPassword = password;
        }

        public string TellSecretPassword()
        {
            return this.secretPassword;
        }

        public void SetPassword(string newPassword)
        {
            this.secretPassword = newPassword;
        }
    }


}
