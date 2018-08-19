using BotClient.Commands;
using BotClient.Commands.CommandImpls;
using BotClient.Core.Commands;
using BotClient.Core.Discord.Messaging;
using BotClient.Discord.Messaging;
using BotClient.Discord.Messaging;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotClient.Core
{
    public class BotClientKernel
    {
        private static BotClientKernel instance = new BotClientKernel();
        public static BotClientKernel Instance => instance;

        private BotClientKernel()
        {
            this.Containter = new ServiceCollection()
                .AddSingleton<ICommand, Command>()
                .AddSingleton<ICommandManager, CommandManager>()
                .AddSingleton<IMessageManager, MessageManager>()
                .AddScoped<IMessage, Message>()
                .BuildServiceProvider();
        }

        public ServiceProvider Containter { get; set; }

        public T Resolve<T>()
        {
            return this.Containter.GetService<T>();
        }
    }
}
