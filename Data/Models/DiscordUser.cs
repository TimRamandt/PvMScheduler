using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class DiscordUser
    {
        [Key]
        public string DiscordUserId { get; set; }
        public string Name { get; set; }
    }
}
