using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace LW2.src.village.strategies
{
    public interface ITavernAction
    {
        void Execute(Knight knight, Tavern tavern);
    }
}

