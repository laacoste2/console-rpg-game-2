using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.Monsters
{
    internal class Monster : IMonster
    {
        public string Name { get; set; }
        private int _strenght;
        private int _health;

        public int Strenght { get => _strenght; set => _strenght = value; }
        public int Health { get => _health; set => _health = value; }

        public Monster(string name, int health, int strenght) 
        {
            Name = name;
            Health = health;
            Strenght = strenght;
        }

        public void useAttack(Character character)
        {
            Console.WriteLine("O monstro atacou!");
            character.Health -= Strenght;
            Console.WriteLine("Vida atual de " + character.Name + ": " + character.Health);
        }
    }
}
