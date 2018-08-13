using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Core.Facade
{
    public interface IDiscordUserFacade
    {
        void AddDiscordUser(DiscordUser discordUser); 
    }
}
