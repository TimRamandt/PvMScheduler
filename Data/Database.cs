using Data.Core;
using Data.Core.Facade;
using Data.Core.Seeding;
using Data.Facades;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class Database : IDatabase
    {
        #if DEBUG
            //if your data is up-to-date, you can skip this method with this flag (only in debug).
            private readonly bool doBossDataCheck = true;
        #endif

        public IDiscordUserFacade DiscordUsers { get; private set; }
        public IBossFacade BossFacade { get; private set; }

        private DatabaseContext dbContext;

        public Database()
        {
            this.dbContext = new DatabaseContext();
            this.CheckAndUpdateBossData();
            this.DiscordUsers = new DiscordUserFacade(this.dbContext);
            this.BossFacade = new BossFacade(this.dbContext);
        }

        private void CheckAndUpdateBossData()
        {
            #if DEBUG
            if (!doBossDataCheck)
                return;
            #endif

            var bosses = BossSeeds.Seed();

            foreach (var boss in bosses)
            {
                if (!this.dbContext.Bosses.Any(x => x.BossId == boss.BossId))
                {
                    this.dbContext.Bosses.Add(boss);
                    continue;
                }
                this.dbContext.Update(boss);
            }
            this.dbContext.SaveChanges();
        }
    }
}
