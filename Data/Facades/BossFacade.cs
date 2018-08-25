using Data.Core.Facade;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Facades
{
    public class BossFacade : IBossFacade
    {
        private DatabaseContext context;
        public BossFacade(DatabaseContext context)
        {
            this.context = context;
        }

        public Boss FindBoss(string name)
        {
            var boss = this.context.Bosses.Where(b => b.Name == name).FirstOrDefault();
            if (boss != null)
                return boss;

            foreach (var potentialBoss in this.context.Bosses)
            {
                if(potentialBoss.Aliases.Any(a => a.Alias == name))
                {
                    boss = potentialBoss;
                    return boss;
                }
            }

            return boss;
        }
    }
}
