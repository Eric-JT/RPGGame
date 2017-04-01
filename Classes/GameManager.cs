using System;

namespace RPGGame
{
    class GameManager
    {
        public static void ShowTitleScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("RPGGAME");
            Console.WriteLine("\nNote: You may type 'help' at any time to see a list of commands");
            Console.WriteLine("\nPress a key to begin");

            Console.CursorVisible = false;
            Console.ReadKey();
            Console.CursorVisible = true;
            Console.Clear();
        }

        public static void StartGame()
        {
            // player get current room and describe room
        }

        public static void EndGame(string endingText)
        {
            // quit the while loop by changing quit to true
            Program.quit = true;

            // clear console
            Console.Clear();

            // display ending message
            Console.WriteLine("Game is over");
            Console.Write("\nYou may now close this window.");
            Console.CursorVisible = false;

            while (true)
            {
                Console.ReadKey(true);
            }
        }

        // Add rules for the game here
        // apply the rules after each command is done in GameCommands
    }
}
