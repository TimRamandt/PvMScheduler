using Data.Core;
using Data.Core.Facade;
using Data.Facades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Database : IDatabase
    {
        public IDiscordUserFacade DiscordUsers { get; private set; }

        public Database()
        {
            var dbContext = new DatabaseContext();
            this.DiscordUsers = new DiscordUserFacade(dbContext);
        }
    }
}
