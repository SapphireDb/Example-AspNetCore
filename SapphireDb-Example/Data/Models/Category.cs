using SapphireDb.Attributes;

namespace SapphireDb_Example.Data.Models
{
    public class Category : Base
    {
        [Updatable]
        public string Name { get; set; }
    }
}