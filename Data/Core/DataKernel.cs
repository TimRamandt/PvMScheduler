using Data.Core.Facade;
using Data.Facades;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Core
{
    public class DataKernel
    {
        private static DataKernel instance = new DataKernel();
        public static DataKernel Instance => instance;

        public ServiceProvider Containter { get; set; }

        private DataKernel()
        {
            this.Containter = new ServiceCollection()
                .AddSingleton<IDatabase, Database>()
                .AddSingleton<IDiscordUserFacade,DiscordUserFacade>()
                .AddSingleton<IBossFacade,BossFacade>()
                .BuildServiceProvider();
        }

        public T Resolve<T>()
        {
            return this.Containter.GetService<T>();
        } 
    }
}
