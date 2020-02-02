using SapphireDb.Attributes;

namespace SapphireDb_Example.Data.Basic.Models
{
    public class Example : Base
    {
        [Updatable]
        public string Content { get; set; }
    }
}