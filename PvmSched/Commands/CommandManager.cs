using BotClient.Commands.CommandImpls;
using BotClient.Commands.Input;
using BotClient.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotClient.Commands
{
    public class CommandManager : ICommandManager
    {
        public char CommandToken => '!'; //TO DO: put this in a config file.
        public List<ICommand> Commands => this.InitializeCommands();

        public ICommand FindCommand(string commandName)
        {
            return this.Commands.Find(x => x.Name == commandName);
        }

        private List<ICommand> InitializeCommands()
        {
            var commands = new List<ICommand>();
            var gameTimeCommand = new GametimeCommand();

            commands.Add(gameTimeCommand);

            return commands;
        }


    }
}
