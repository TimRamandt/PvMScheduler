using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class Boss
    {
        [Key]
        public int BossId { get; set; }
        public string Name { get; set; } 
        public List<Role> Roles { get; set; }
    }
}
