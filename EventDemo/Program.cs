using System;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            Subscriber sub1 = new Subscriber("Fredrik");
            Subscriber sub2 = new Subscriber("Anna");
            Subscriber sub3 = new Subscriber("Frida");

            publisher.sendMessage += sub1.HandleMessageRecieved;
            publisher.sendMessage += sub2.HandleMessageRecieved;
            publisher.sendMessage += sub3.HandleMessageRecieved;

            publisher.OnSendMessage("Hello there!");
            Console.WriteLine();
            publisher.OnSendMessage("Another message!");
        }
    }
}
