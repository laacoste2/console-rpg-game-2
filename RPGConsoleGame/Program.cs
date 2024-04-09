namespace RPGConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your character name: ");
            string nameChoise = Console.ReadLine();

            Console.WriteLine("\nChoose your CLASS: [K]night - [M]age - [A]rcher");
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
                    Console.WriteLine("Invalid Class Choise");
                    return;
            }

            Character character = new Character(nameChoise, characterClass);

            
        }
    }
}