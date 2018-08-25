using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Core.Facade
{
    public interface IBossFacade
    {
        Boss FindBoss(string name);
    }
}
