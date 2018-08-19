using BotClient.Core.Discord.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotClient.Discord.Messaging
{
    public class MessageManager : IMessageManager
    {
        public IMessage CreateMessage(string content)
        {
            return new Message()
            {
                Content = content
            };
        }
    }
}
