using RPGConsoleGame.Classes;
using RPGConsoleGame.Monsters;

namespace RPGConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do seu personagem: ");
            string nameChoise = Console.ReadLine();

            Console.WriteLine("\nEscolha sua classe: [K]night - [M]age - [A]rcher");
            string classChoise = Console.ReadLine();

            IClass characterClass;
            switch (classChoise)
            {
                case "K":
                    characterClass = new KnightClass();
                    break;

                case "M":
                    characterClass = new MageClass();
                    break;

                case "A":
                    characterClass = new ArcherClass();
                    break;

                default:
                    Console.WriteLine("Classe Invalida");
                    return;
            }

            Console.Clear();
            Character character = new Character(nameChoise, characterClass);

            DialoguesAndCombatSystem.Dialogue1AndStartOfTheJourney(character);

            Console.Clear();

            Monster spider = new Monster("Spider", 10, 1);
            Console.WriteLine(character.Name + " encontra algo que se parece com uma aranha, mas com dentes afiados...");
            Console.WriteLine("Com o susto que levou da aranha, " + character.Name + " acaba pisando em um galho.");
            Console.WriteLine("Com isso, a aranha acaba percebendo sua presença e parte pra cima dele.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("- * - * - * - * - * -");
            Console.WriteLine("Combate Iniciado!");
            Console.WriteLine("- * - * - * - * - * -");

            Console.ReadKey();
            Console.Clear();

            DialoguesAndCombatSystem.CombatSystem(character, spider);
        }
    }
}