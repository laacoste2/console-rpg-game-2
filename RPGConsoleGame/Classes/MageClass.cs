using RPGConsoleGame.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.Classes
{
    internal class MageClass : IClass
    {
        public MageClass() { }

        public void UseClassAbility()
        {
            Console.WriteLine("O Mago lançou uma bola de fogo.");

        }

        public void UseClassAtack()
        {
            Console.WriteLine("O Mago usou seu cajado para acertar o inimigo.");
        }
    }
}
