﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Boss
    {
        [Key]
        public string BossId { get; set; }
        public string Name { get; set; }
        
        public virtual List<BossAlias> Aliases { get; set; }
        public virtual List<Role> Roles { get; set; }
    }
}
