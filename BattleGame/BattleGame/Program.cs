namespace BattleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int amount = TryParseAmount(args);
            var heros = HeroGenerator.Generate(amount);

            Console.WriteLine("Press key to start..");
            Console.ReadKey();
            var game = new Game(heros);
            while (true)
            {
                if (!game.GameOver)
                {
                    game.NextRound();
                    Console.WriteLine("Next round?");
                }
                else
                {
                    Console.WriteLine("Game Over!");
                    game.Winner();                   
                }
                Console.ReadKey();
            }
        }

        private static int TryParseAmount(string[] args)
        {
            int firstArg = 0;
            if (args.Length > 0)
            {
                int.TryParse(args[0], out firstArg);
            }
            return firstArg;
        }
    }
}