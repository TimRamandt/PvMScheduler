using Data.Core.Facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Core
{
    public interface IDatabase
    {
        IDiscordUserFacade DiscordUsers { get; }
    }
}
