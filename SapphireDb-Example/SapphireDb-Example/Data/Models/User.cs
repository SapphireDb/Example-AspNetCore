using System.Collections.Generic;

namespace SapphireDb_Example.Data.Models
{
    public class User : Base
    {
        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Notice> Notices { get; set; }
    }
}