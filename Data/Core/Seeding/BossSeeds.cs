using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Core.Seeding
{
    public class BossSeeds
    {
        private static Boss SeedVorago()
        {
            var vorago = new Boss()
            {
                BossId = "6a61qasa8oe5d58t",
                Name = "vorago",
                Aliases = new List<BossAlias>()
            };

            vorago.Aliases.Add(new BossAlias() { Alias = "rago", AliasId=$"{vorago.BossId}_10" /*, AliasId = 200, BossId=1 */});
            vorago.Aliases.Add(new BossAlias() { Alias = "rockboss", AliasId=$"{vorago.BossId}_11" /*, AliasId = 201, BossId=1 */});
            vorago.Aliases.Add(new BossAlias() { Alias = "rockman", AliasId=$"{vorago.BossId}_12" /*, AliasId = 202, BossId=1 */});

            vorago.Roles = RoleSeeds.SeedVoragoRoles(vorago);

            return vorago;
        }

        private static Boss SeedAngelOfDeath()
        {
            var aod = new Boss()
            {
                BossId = "subkgui5ha2yddzu",
                Name = "angel of death",
                Aliases = new List<BossAlias>()
            };
            aod.Aliases.Add(new BossAlias() { Alias = "aod", AliasId=$"{aod.BossId}_20" });
            aod.Roles = RoleSeeds.SeedAngelOfDeathRoles(aod);

            return aod;
        }

        private static Boss SeedRiseOfTheSix()
        {

            var rots = new Boss()
            {
                BossId = "8ss7a6gn6rtaoam0",
                Name = "rise of the six",
                Aliases = new List<BossAlias>()
            };
            rots.Aliases.Add(new BossAlias() { Alias = "rots", AliasId=$"{rots.BossId}_30" });
            rots.Roles = RoleSeeds.SeedRiseOfTheSixRoles(rots);

            return rots;
        }


        public static List<Boss> Seed()
        {
            var bosses = new List<Boss>();

            bosses.Add(SeedVorago());
            bosses.Add(SeedAngelOfDeath());
            bosses.Add(SeedRiseOfTheSix());

            return bosses;
        }
    }
}
