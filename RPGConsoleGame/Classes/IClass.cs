using RPGConsoleGame.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.Classes
{
    internal interface IClass
    {
        void UseClassAtack();
        void UseClassAbility();
    }
}
