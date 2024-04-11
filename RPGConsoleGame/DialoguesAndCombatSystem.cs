using RPGConsoleGame.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame
{
    internal static class DialoguesAndCombatSystem
    {
        public static void Dialogue1AndStartOfTheJourney(Character character)
        {
            Console.WriteLine(character.Name + " acorda no meio do nada...");
            Console.WriteLine("Ao olhar ao seu arredor, ele percebe que está em uma floresta.");
            Console.ReadKey();
            Console.WriteLine("(...)");
            Console.ReadKey();
            Console.WriteLine("Após retomar parcialmente sua consciência " + character.Name + " se levanta e começa a andar rumo a uma estrada de pedra logo em sua frente.");
            Console.WriteLine("Quando ele chega na estrada, percebe que ela segue rumo para dentro da floresta.");
            Console.WriteLine("Em um breu causado pela escuridão da noite, " + character.Name + " hesita rapidamente perante a ideia de seguir a estrada, mas se recompõe rapidamente.");

            Console.WriteLine("\n- * - * - * - * - * - * - * - * - * -");
            Console.WriteLine("Digite E para iniciar sua jornada!");
            Console.WriteLine("- * - * - * - * - * - * - * - * - * -");
            string startJourney = Console.ReadLine();

            if (startJourney == "E")
            {
                Console.Clear();
                Console.WriteLine("E assim " + character.Name + " iniciou sua jornada!");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine(character.Name + " escorregou e caiu de cabeça em uma quina.");
                Console.WriteLine("Seu personagem MORREU!");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        public static void CombatSystem(Character character, Monster monster)
        {
            while (character.Health > 0 && monster.Health > 0)
            {
                bool showMonsterAttackMessage = true;
                character.UseAttack(monster);
                if (monster.Health <= 0)
                {
                    Console.WriteLine("\nO monstro morreu. " + character.Name + " venceu a batalha! ");
                    Console.WriteLine("Ao matar o monstro, seu personagem ganha algumas moedas.");
                    //Adicionar sistema de moedas depois
                    showMonsterAttackMessage = false;
                }

                if(showMonsterAttackMessage)
                {
                    monster.useAttack(character);
                    if (character.Health <= 0)
                    {
                        Console.WriteLine("\nSeu personagem morreu e sua aventura acaba aqui.");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                

            }
        }
    }
}
