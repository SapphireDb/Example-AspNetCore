namespace SapphireDb_Example.Data.Chat.Models
{
    public class Message : Base
    {
        public string Content { get; set; }

        public int OwnerId { get; set; }

        public int ReceiverId { get; set; }
    }
}