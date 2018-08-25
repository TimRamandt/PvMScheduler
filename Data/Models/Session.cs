using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Session
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SessionId { get; set; }

        public Boss Boss { get; set; }
        public int Limit { get; set; }

        public DiscordUser Host { get; set; }
        public DateTime Time { get; set; }
    }
}
