using BotClient.Auth;
using BotClient.Commands.Input;
using BotClient.Core;
using BotClient.Core.Commands;
using BotClient.Core.Discord.Messaging;
using Data.Core;
using Data.Models;
using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace BotClient
{
    public class PvmSchedulerClient
    {
        private DiscordSocketClient client;
        private IDatabase database;
        private ICommandManager commandManager;
        private IMessageManager messageManager;

        public async Task Run()
        {
            this.client = new DiscordSocketClient();
            this.database = DataKernel.Instance.Resolve<IDatabase>();

            this.commandManager = BotClientKernel.Instance.Resolve<ICommandManager>();
            this.messageManager = BotClientKernel.Instance.Resolve<IMessageManager>();

            client.MessageReceived += MessageReceived;

            client.Log += Log;

            string token = TokenReader.ReadToken();
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            var testBoss = this.database.BossFacade.FindBoss("rockman");

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
