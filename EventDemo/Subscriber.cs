using System;
using System.Collections.Generic;
using System.Text;

namespace EventDemo
{
    class Subscriber
    {
        private string name;

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void HandleMessageRecieved(object sender, MessageEventArgs args)
        {
            Console.WriteLine($"{name} got the message: {args.Message}");
        }
    } 
}
