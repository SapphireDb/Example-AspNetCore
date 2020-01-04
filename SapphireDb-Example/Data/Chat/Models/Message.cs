using System;

namespace SapphireDb_Example.Data.Chat.Models
{
    public class Message : Base
    {
        public string Content { get; set; }

        public string OwnerId { get; set; }

        public string ReceiverId { get; set; }
    }
}