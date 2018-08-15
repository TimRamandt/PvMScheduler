using System;
using System.Collections.Generic;
using System.Text;

namespace BotClient.Core.Commands
{
    public interface ICommandManager
    {
        char CommandToken { get; }
        List<ICommand> Commands { get; }

        ICommand FindCommand(string commandName);

    }
}
