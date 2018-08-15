using BotClient.Auth;
using BotClient.Commands;
using BotClient.Commands.Input;
using BotClient.Core.Commands;
using Data;
using Data.Facades;
using Data.Models;
using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BotClient
{
    public class PvmSchedulerClient
    {
        private DiscordSocketClient client;
        private DatabaseContext dbContext;
        private ICommandManager commandManager;

        public async Task Run()
        {
            this.client = new DiscordSocketClient();
            this.dbContext = new DatabaseContext();

            this.commandManager = new CommandManager();

            client.MessageReceived += MessageReceived;

            client.Log += Log;

            string token = TokenReader.ReadToken();
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            // Block this task until the program is closed.
            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        private async Task MessageReceived(SocketMessage messageSocket)
        {
            //TO DO: Create DiscordManagerClasses for channels & messages
            var content = messageSocket.Content;

            var parsedInput = InputCommandLexer.ToCommandInput(content);
            if (parsedInput.FirstToken != this.commandManager.CommandToken)
                return;

            var command = this.commandManager.FindCommand(parsedInput.Name);
            command.Execute(parsedInput.Parameters);

            await messageSocket.Channel.SendMessageAsync(command.PrintOutput());
            
        }
    }
}
