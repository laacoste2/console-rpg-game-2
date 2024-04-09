﻿using System;
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
            Console.WriteLine("The Knight uses his sword to pierce the enemy's weak point");
        }

        public void UseClassAtack()
        {
            Console.WriteLine("The Knight attack with his sword");
        }
    }
}