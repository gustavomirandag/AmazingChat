using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazingChatWebApp.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public Profile Sender { get; set; }
        public Profile Recipient { get; set; }
        private string content; //Variável protegida
        public string Content
        {
            get => content;
            set
            {
                if (value != null)
                    content = value;
            }
        }
        public DateTime Timestamp { get; set; }
    }
}