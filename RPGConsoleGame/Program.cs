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

            Dialogues.Dialogue1AndStartOfTheJourney(character);

            Console.Clear();

            Console.WriteLine("");
        }
    }
}