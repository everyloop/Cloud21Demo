using System;
using System.Collections.Generic;
using System.Text;

namespace EventDemo
{

    class MessageEventArgs : EventArgs
    {
        public MessageEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }

    class Publisher
    {
        //public delegate void SendMessage(object sender, MessageEventArgs args);

        public event EventHandler<MessageEventArgs> sendMessage;

        public void OnSendMessage(string text)
        {
            sendMessage.Invoke(this, new MessageEventArgs(text));
        }
    }
}
