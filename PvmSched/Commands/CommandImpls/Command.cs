using BotClient.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotClient.Commands.CommandImpls
{
    public abstract class Command : ICommand
    {
        public abstract string Name { get; }
        public string Output { get; set; }

        public abstract void Execute(string[] parameters);

        public string PrintOutput()
        {
            return this.Output;
        }
    }
}
