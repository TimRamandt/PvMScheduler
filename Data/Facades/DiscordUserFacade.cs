using Data.Core.Facade;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Facades
{
    //TO DO: dependancy injection or MEF
    public class DiscordUserFacade : IDiscordUserFacade
    {
        private DatabaseContext context;
        public DiscordUserFacade(DatabaseContext context)
        {
            this.context = context;
        }

        public void AddDiscordUser(DiscordUser discordUser)
        {
            this.context.DiscordUsers.Add(discordUser);
            this.context.SaveChanges();
        }
    }
}
