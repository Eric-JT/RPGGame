using System;

namespace RPGGame
{
    static class GameCommands
    {

        private static int GetRandomNum()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(2);
            return randomNumber;
        }

        public static string GetCommand(string sPlayerInput)
        {
            // Input string. check if the string has more than one word
            // if string has one word return that string
            // if the string has more than one word return the first word
            int iIndex = sPlayerInput.IndexOf(' ');
            if (iIndex == -1)
                return sPlayerInput;
            else
                return sPlayerInput.Substring(0, iIndex);
        }

        public static string GetArgument(string sPlayerInput)
        {
            // input string. check if the string has more than one word
            // if the string has one word return an empty string
            // if there are more than one word than return all words exept the first one
            int iIndex = sPlayerInput.IndexOf(' ');
            if (iIndex == -1)
                return "";
            else
                return sPlayerInput.Substring(iIndex + 1, sPlayerInput.Length - iIndex - 1);
        }

        public static void CheckTheCommand(string sPlayerInput)
        {

            // store the first word in the string to sCommand, remove whitespace and lower case
            string sCommand = GetCommand(sPlayerInput.Trim()).Trim().ToLower();
            // store all remaing words in the string to sArguments, remove whitespace and lower case
            string sArguments = GetArgument(sPlayerInput.Trim()).Trim().ToLower();

            // check if the commands are valid
            if (Cave.IsValidDirection(sCommand))
            {
                // move the player
            }
            else
            {
                // reun the specified command
                switch (sCommand)
                {
                    case "exit":
                        Program.quit = true;
                        return;
                    case "help":
                        ShowHelp();
                        break;
                   case "move":
                        // move the player towards the given direction, increment or decrement player x and y
                        Console.Clear();
                        Player.Move(sArguments);
                        if (GetRandomNum() == 1)
                        {
                            // if GetRandomNum() returns 1, an enemy appears
                            GameManager.EnemyEncounter();
                        }
                        break;
                    case "look":
                        // get the location of the play, check it against locations of caves
                        // return information for that cave
                        Console.Clear();
                        Player.GetCurrentCave().DescribeCave();
                        break;
                    case "pickup":
                        // check if item in cave, remove item from cave, add item to inventory
                        Player.PickupItem(sArguments);
                        break;
                    case "drop":
                        // check if item in inventory, remove item from inventory, add item to cave
                        Console.Clear();
                        Player.DropItem(sArguments);
                        break;
                    case "inventory":
                        // display all items in inventory
                        Console.Clear();
                        Player.DisplayInventory();
                        break;
                    case "whereami":
                        // get the location of the play, check it against locations of caves
                        // return information for that cave
                        Player.GetCurrentCave().ShowTitle();
                        break;
                    
                    
                    case "clear":
                        Console.Clear();
                        break;
                
                }
            }

            GameManager.GameRules();

        }

        public static void ShowHelp()
        {
            // display a help screen with a list of commmands
            Console.WriteLine("List of commands");
            Console.WriteLine("help");
            Console.WriteLine("exit");
            Console.WriteLine("move - north, south, east, west");
            Console.WriteLine("look");
            Console.WriteLine("pickup");
            Console.WriteLine("drop");
            Console.WriteLine("inventory");
            Console.WriteLine("whereami");
            Console.WriteLine("clear");
        }
    }
}
