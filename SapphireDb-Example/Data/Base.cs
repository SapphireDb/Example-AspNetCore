using System;
using System.ComponentModel.DataAnnotations;
using SapphireDb.Attributes;

namespace SapphireDb_Example.Data
{
    [UpdateEvent(nameof(OnUpdate))]
    public class Base
    {
        public Base()
        {
            CreatedOn = DateTime.Now;
        }
        
        [Key]
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }
        
        public DateTime UpdatedOn { get; set; }

        private void OnUpdate()
        {
            UpdatedOn = DateTime.Now;
        }
    }
}