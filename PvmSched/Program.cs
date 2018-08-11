using BotClient;
using System;

namespace PvmSched
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new PvmSchedulerClient();
            client.Run().GetAwaiter().GetResult();
        }
    }
}
