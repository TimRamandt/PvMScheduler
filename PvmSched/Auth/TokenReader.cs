using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BotClient.Auth
{
    public static class TokenReader
    {
        /// <summary>
        /// The token should be in a seperate file, and you should keep this token a secret. 
        /// </summary>
        /// <returns>Authentication token</returns>
        public static string ReadToken()
        {
            var baseDir = Directory.GetCurrentDirectory();
            return File.ReadAllText($"{Path.Combine(baseDir,@"Auth\Token.txt")}");
        }
    }
}
