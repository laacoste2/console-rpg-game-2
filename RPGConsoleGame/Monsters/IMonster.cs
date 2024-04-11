using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.Monsters
{
    internal interface IMonster
    {
        void useAttack(Character character);
    }
}
