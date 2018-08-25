using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class BossAlias
    {
        [Key]
        public string AliasId { get; set; }
        public string Alias { get; set; }

        public string BossId { get; set; }
        public virtual Boss Boss { get; set; }
    }
}
