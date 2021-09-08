using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Person
    {
        private string firstName = "No name";
        public double length;
        public double weight;

        private string _lastName;
        public string LastName { 
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value.ToUpper();
            }

            // lowercase
            // UPPERCASE
        }
        public double BMI { 
            get 
            {
                return  weight / (length * length);
            }
        }

        public void PrintGreeting()
        {
            Console.WriteLine($"Hello, {firstName} {_lastName}");
        }

        public void SetFirstName(string name)
        {
            this.firstName = name.ToUpper();
        }

        public string GetFirstName()
        {
            return firstName;
        }
    }
}
