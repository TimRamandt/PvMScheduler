using BotClient.Core.Discord;
using BotClient.Core.Discord.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotClient.Discord.Messaging
{
    public class Message : IMessage
    {
        public string Content { get; set; } 
    }
}
