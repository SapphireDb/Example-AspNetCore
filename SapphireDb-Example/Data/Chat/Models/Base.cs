using System;
using System.ComponentModel.DataAnnotations;
using SapphireDb.Attributes;

namespace SapphireDb_Example.Data.Chat.Models
{
    [UpdateEvent(nameof(OnUpdate))]
    public class Base
    {
        public Base()
        {
            Id = Guid.NewGuid().ToString();
            CreatedOn = DateTime.Now;
        }
        
        [Key]
        public string Id { get; set; }

        public DateTime CreatedOn { get; set; }
        
        public DateTime UpdatedOn { get; set; }

        private void OnUpdate()
        {
            UpdatedOn = DateTime.Now;
        }
    }
}