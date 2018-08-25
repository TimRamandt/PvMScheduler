using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Core.Seeding
{
    public class RoleSeeds
    {
        public static List<Role> SeedVoragoRoles(Boss boss)
        {
            var roles = new List<Role>();

            if(boss.Name != "vorago")
                return roles;

            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_100",
                Name = "dps",
                Abbreviation = "dps",
                Boss = boss
            });
            
            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_101",
                Name = "Top Lure 5",
                Abbreviation = "tl5",
                Boss = boss
            });

            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_102",
                Name = "Base Tank",
                Abbreviation = "base",
                Boss = boss
            });

            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_103",
                Name = "Bomb Tank",
                Abbreviation = "bt", 
                Boss = boss
            });

            return roles;
        }

        public static List<Role> SeedAngelOfDeathRoles(Boss boss)
        {
            var roles = new List<Role>();

            if(boss.Name != "angel of death")
                return roles;

            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_200",
                Name = "dps",
                Abbreviation = "dps",
                Boss = boss
            });
            
            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_201",
                Name = "minion tank: Umbra",
                Abbreviation = "u",
                Boss = boss
            });

            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_202",
                Name = "minion tank: Glacies",
                Abbreviation = "g",
                Boss = boss
            });

            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_203",
                Name = "minion tank: Cruor",
                Abbreviation = "c",
                Boss = boss
            });

            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_204",
                Name = "minion tank: Fumus",
                Abbreviation = "f",
                Boss = boss
            });

            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_205",
                Name = "Chinner",
                Abbreviation = "chin", 
                Boss = boss
            });

            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_206",
                Name = "Base Tank",
                Abbreviation = "bt", 
                Boss = boss
            });
            
            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_207",
                Name = "Base Tank 2",
                Abbreviation = "b2", 
                Boss = boss
            });

            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_208",
                Name = "hammer",
                Abbreviation = "hammer", 
                Boss = boss
            });
            
            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_209",
                Name = "debuffer",
                Abbreviation = "db", 
                Boss = boss
            });

            return roles;
        }

        public static List<Role> SeedRiseOfTheSixRoles(Boss boss)
        {
            var roles = new List<Role>();

            if(boss.Name != "rise of the six")
                return roles;

            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_300",
                Name = "incite west",
                Abbreviation = "iw",
                Boss = boss
            });

            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_301",
                Name = "dps west",
                Abbreviation = "w",
                Boss = boss
            });

            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_302",
                Name = "incite east",
                Abbreviation = "ie",
                Boss = boss
            });

            roles.Add(new Role()
            {
                RoleId = $"{boss.BossId}_303",
                Name = "dps west",
                Abbreviation = "e",
                Boss = boss
            });

            return roles;
        }
    }
}
