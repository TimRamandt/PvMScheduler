using BotClient.Auth;
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
        public async Task Run()
        {
            this.client = new DiscordSocketClient();
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
