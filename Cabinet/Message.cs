using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cabinet
{
    public class Message
    {
        private string textMessage;
        private string etatMessage;
        private string sender;
        public string TextMessage
        {
            get { return textMessage; }
            set { textMessage = value; }
        }
        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }
       
        public string EtatMessage
        {
            get { return etatMessage; }
            set { etatMessage = value; }
        }


        public Message(string msgText,string sender,string state)
        {
            this.TextMessage = msgText;
            this.Sender = sender;
            this.EtatMessage = state;
        
        }
    }
}
