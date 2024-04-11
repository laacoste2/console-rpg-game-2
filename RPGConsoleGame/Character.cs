using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGConsoleGame.Classes;
using RPGConsoleGame.Monsters;

namespace RPGConsoleGame
{
    internal class Character
    {
        public string Name { get; set; }
        public IClass Class { get; set; }
        private int _health = 30;
        private int _strenght = 10;

        public int Health { get => _health; set => _health = value; }
        public int Strenght { get => _strenght; set => _strenght = value; }

        public Character(string name, IClass characterClass) 
        {
            Name = name;
            Class = characterClass;
        }

        public void UseClassAbility(Monster monster)
        {
            Class.UseClassAbility();
            monster.Health -= (Strenght + 10);
            Console.WriteLine("Vida atual do monstro: " + monster.Health);
        }

        public void UseAttack(Monster monster)
        {
            Class.UseClassAtack();
            monster.Health -= Strenght;
            Console.WriteLine("Vida atual do monstro: " + monster.Health);
        }

    }
}
