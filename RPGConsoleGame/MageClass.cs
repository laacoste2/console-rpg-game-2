using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame
{
    internal class MageClass : IClass
    {
        private int _health = 25;
        private int _strenght = 6;

        public int Health { get => _health; }
        public int Strenght { get => _strenght; }

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
