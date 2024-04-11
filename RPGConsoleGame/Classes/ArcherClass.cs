using RPGConsoleGame.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.Classes
{
    internal class ArcherClass : IClass
    {
        public ArcherClass() { }

        public void UseClassAbility()
        {
            Console.WriteLine("O Arqueiro jogou fogo em sua flecha.");
        }

        public void UseClassAtack()
        {
            Console.WriteLine("O Arqueiro usa seu arco para lançar uma flecha em seu inimigo");
        }
    }
}
