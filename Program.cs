using System;

namespace RPGGame
{
    class Program
    {
        
        public static Boolean quit = false; // false for game to run, true for game to end
        static void Main(string[] args)
        {
            
            // show the title screen
            GameManager.ShowTitleScreen();
            // start up teh world
            World.InitializeWorlds();
            // start the game
            GameManager.StartGame();

            while (!quit)
            {
                // get the commands from the user
                GameCommands.CheckTheCommand(Console.ReadLine());
            }

        }
    }
}
