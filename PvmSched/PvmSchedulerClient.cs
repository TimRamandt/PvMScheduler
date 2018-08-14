using BotClient.Auth;
using BotClient.Commands;
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

        }
    }
}
