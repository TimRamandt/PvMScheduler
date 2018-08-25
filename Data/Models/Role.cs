using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Role
    {
        [Key]
        public string RoleId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public string BossId { get; set; }
        public virtual Boss Boss { get; set; }
    }
}
