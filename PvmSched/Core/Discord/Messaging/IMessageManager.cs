using System;
using System.Collections.Generic;
using System.Text;

namespace BotClient.Core.Discord.Messaging
{
    public interface IMessageManager
    {
        IMessage CreateMessage(string content);
    }
}
