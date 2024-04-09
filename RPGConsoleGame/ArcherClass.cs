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
            Console.WriteLine("The Archer sets fire on his arrow.");
        }

        public void UseClassAtack()
        {
            Console.WriteLine("The Archer uses his bow to throw a arrow on his enemy");
        }
    }
}
