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

        public void FindAndExcuteCommand(string userInput)
        {
            var userCommandInput = InputCommandLexer.ToCommandInput(userInput);

            this.Commands.Find(x => x.Name == userCommandInput.Name).Execute(userCommandInput.Parameters);
        }

        private List<ICommand> InitializeCommands()
        {
            var commands = new List<ICommand>();

            return commands;
        }


    }
}
