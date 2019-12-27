using System.ComponentModel.DataAnnotations.Schema;

namespace SapphireDb_Example.Data.Models
{
    public class Notice : Base
    {
        public string Content { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        
        public virtual User User { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}