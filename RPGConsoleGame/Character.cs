using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame
{
    internal class Character
    {
        public string Name { get; set; }
        public IClass Class { get; set; }

        public Character(string name, IClass characterClass) 
        {
            Name = name;
            Class = characterClass;
        }

        public void UseClassAbilityAction()
        {
            Class.UseClassAbility();
        }

        public void UseAttackAction()
        {
            Class.UseClassAtack();
        }

    }
}
