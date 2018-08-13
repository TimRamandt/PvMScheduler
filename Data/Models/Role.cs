using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public DiscordUser Player { get; set; }
        public string Name { get; set; }
    }
}
