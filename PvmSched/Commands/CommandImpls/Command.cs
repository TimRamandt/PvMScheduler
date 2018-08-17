using BotClient.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotClient.Commands.CommandImpls
{
    public class Command : ICommand
    {
        public virtual string Name { get; }
        public string Output { get; set; }

        public virtual void Execute(string[] parameters) { }

        public string PrintOutput()
        {
            return this.Output;
        }
    }
}
