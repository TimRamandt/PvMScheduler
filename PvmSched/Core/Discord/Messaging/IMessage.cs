using System;
using System.Collections.Generic;
using System.Text;

namespace BotClient.Core.Discord.Messaging
{
    public interface IMessage
    {
        string Content { get; set; }
    }
}
