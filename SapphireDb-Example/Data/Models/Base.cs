using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;

namespace SapphireDb_Example.Data.Models
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}