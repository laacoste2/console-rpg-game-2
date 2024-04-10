using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame
{
    internal class ArcherClass : IClass
    {
        private int _health = 30;
        private int _strenght = 5;

        public int Health { get => _health; }
        public int Strenght { get => _strenght; }

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
