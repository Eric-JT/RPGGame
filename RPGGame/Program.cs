using System;
using System.Media;

namespace RPGGame
{
    class Program
    {
        

        public static int iClass = 0;
        public static string sUserName = "";
        public static int iBossKill = 0;
        public static Boolean quit = false; // false for game to run, true for game to end
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\cave.wav";
            player.PlayLooping();

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
