using System;
using System.Collections.Generic;
using System.Text;

namespace BotClient.Core.Commands
{
    public interface ICommand
    {
        string Name { get; }
        void Execute(string[] parameters);

        string PrintOutput();
    }
}
