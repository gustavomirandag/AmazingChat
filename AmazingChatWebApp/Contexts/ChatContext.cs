using AmazingChatWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AmazingChatWebApp.Contexts
{
    public class ChatContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Message> Messages { get; set; }
        public ChatContext()
            :base("Server=tcp:amazing-chat-db-server.database.windows.net,1433;Initial Catalog=amazing-chat-db;Persist Security Info=False;User ID=daniel;Password=@dsInf123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {
            Database.CreateIfNotExists();
        }
    }
}