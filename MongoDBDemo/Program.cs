using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MongoDB Demo\n");

            var client = new MongoClient();
            var database = client.GetDatabase("Cloud21Demo");
            var collection = database.GetCollection<Person>("People");

            /*
            collection.InsertOne(new Person() { FirstName = "Fredrik", LastName = "Andersson" });
            collection.InsertOne(new Person() { FirstName = "Mikeal", LastName = "Svensson" });
            collection.InsertOne(new Person() { FirstName = "Gunnar", LastName = "Jönsson" });
            collection.InsertOne(new Person() { FirstName = "Frida", LastName = "Karlsson" });
            collection.InsertOne(new Person() { FirstName = "Johanna", LastName = "Johansson" });
            */

            //var tomas = new Person() { FirstName = "Tomas", LastName = "Svensson", Title = "Mr.", Age = 55, Phone = "07012232354353" };
            //collection.InsertOne(tomas);

            //var filter = Builders<Person>.Filter.Eq("FirstName", "Johan");
            // Person person = collection.Find(filter).FirstOrDefault();
            //List<Person> persons = collection.Find(filter).ToList();

            //List<Person> persons = collection.Find(p => p.FirstName.Length == 7 || p.LastName.Contains("a")).ToList();
            List<Person> persons = collection.Find(p => true).ToList();

            foreach (Person person in persons)
            {
                person.PrintName();
                //Console.WriteLine(person.Phone);
            }

            //collection.DeleteMany(p => p.FirstName == "Tomas");

            //var filter = Builders<Person>.Filter.Eq("FirstName", "Fredrik");
            //var update = Builders<Person>.Update.Set("Title", "Mr.");
            //collection.UpdateMany(filter, update);
        }
    }

    class Person
    {
        [BsonId]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Title { get; set; }
        [BsonIgnore]
        public int Age { get; set; }
        [BsonElement("PhoneNumber")]
        public string Phone { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"{(Title != null ? Title + " " : "")}{FirstName} {LastName}");
        }
    }
}
