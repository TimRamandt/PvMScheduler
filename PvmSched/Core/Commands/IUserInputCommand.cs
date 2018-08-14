using System;
using System.Collections.Generic;
using System.Text;

namespace BotClient.Core.Commands
{
    public interface IUserInputCommand
    {
        char FirstToken { get; set; }
        string Name { get; set; }
        string[] Parameters { get; set; }
    }
}
