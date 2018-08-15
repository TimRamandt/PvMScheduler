using BotClient.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotClient.Commands.CommandImpls
{
    public class GametimeCommand : Command
    {
        public override string Name => "gametime";
        
        public override void Execute(string[] parameters)
        {
            var now = DateTime.UtcNow.TimeOfDay;
            this.Output = $"{now.Hours.ToString("D2")}:{now.Minutes.ToString("D2")}";
        }
    }
}
