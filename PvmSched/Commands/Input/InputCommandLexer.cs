using BotClient.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotClient.Commands.Input
{
    public static class InputCommandLexer 
    {
        public static IUserInputCommand ToCommandInput(string input)
        {
            return new UserInputCommand()
            {
                FirstToken = input[0],
                Name = FetchCommandName(input),
                Parameters = FetchParameters(input)
            };
        }

        private static string FetchCommandName(string input)
        {
            return input.Split(' ')[0].Substring(1);
        }

        private static string[] FetchParameters(string input)
        {
            var parameters = new List<string>();

            StringBuilder parameter = new StringBuilder();
            int i = input.Split(' ')[0].Length+1;
            bool multispaceArgument = false;

            while (i < input.Length)
            {
                if(input[i] == ' ' && !multispaceArgument)
                {
                    parameters.Add(parameter.ToString());
                    parameter.Clear();
                    i++;
                    continue;
                }

                if(input[i] == '\"')
                {
                    multispaceArgument = !multispaceArgument;
                    i++;
                    continue;
                }

                parameter.Append(input[i]);
                i++;
            }
            //add last parameter 
            parameters.Add(parameter.ToString());

            return parameters.ToArray();
        }
    }
}
