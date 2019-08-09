using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazingChatWebApp.Models
{
    public class Profile
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Color { get; set; }
        public string PicUrl { get; set; }
    }
}