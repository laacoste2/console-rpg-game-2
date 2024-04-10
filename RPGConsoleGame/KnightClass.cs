using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame
{
    internal class KnightClass : IClass
    {
        private int _health = 35;
        private int _strenght = 4;

        public int Health { get => _health; }
        public int Strenght { get => _strenght; }

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
