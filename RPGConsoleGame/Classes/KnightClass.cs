using RPGConsoleGame.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.Classes
{
    internal class KnightClass : IClass
    {
        public KnightClass() { }

        public void UseClassAbility()
        {
            Console.WriteLine("O Cavaleiro usa sua espada para perfurar o ponto fraco de seu inimigo.");
        }

        public void UseClassAtack()
        {
            Console.WriteLine("O Cavaleiro atacou utilizando sua espada");
        }
    }
}
