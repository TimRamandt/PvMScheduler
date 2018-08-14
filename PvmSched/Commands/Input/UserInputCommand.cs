using BotClient.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotClient.Commands.Input
{
    class UserInputCommand : IUserInputCommand
    {
        public char FirstToken { get; set; }
        public string Name { get; set; }
        public string[] Parameters { get; set; }

    }
}
