using System;
using System.Threading;

namespace RPGGame
{
    class GameManager
    {

        public static bool BossEncounter()
        {
            Console.Clear();
            Figthing fight = new Figthing();
            Enemy.iHealth = 30;
            Console.WriteLine(Enemy.sBossDescription);
            Thread.Sleep(3000);
            while (Enemy.iHealth > 1)
            {
                Random ran = new Random();
                Enemy.iAttack = 15;
                int hit = ran.Next(0, 11);
                fight.Boss();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("you should attack: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string sCommand = Console.ReadLine();
                switch (sCommand)
                {
                    case "attack":
                        if (hit > 3)
                        {
                            Enemy.iHealth -= Player.PlayerAttack();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("You attacked the enemy!");
                            Thread.Sleep(3000);
                        }
                        else
                        {
                            Console.WriteLine("You attacked the Boss, BUT MISSED!!");
                            Thread.Sleep(3000);
                        }
                        if (Enemy.iAttack < 5)
                        {
                            Player.iHealth -= Enemy.iAttack;
                            Console.WriteLine("The Boss attacked you!");
                            Thread.Sleep(3000);
                        }
                        else
                        {
                            Console.WriteLine("The Boss attacked you, BUT MISSED!");
                            Thread.Sleep(3000);
                        }

                        break;

                }

                if (Player.iHealth == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have died!!!!");
                    Program.quit = true;
                    Console.ReadKey();
                    return Program.quit;
                }
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("You have killed your Boss!");
            Thread.Sleep(3000);
            Console.Clear();
            Player.GetCurrentCave().DescribeCave();
            return false;
        }

        public static bool EnemyEncounter()
        {
            Console.Clear();
            Figthing fight = new Figthing();
            Random ran = new Random();
            int randEnemy = ran.Next(0, 4);
            Enemy.iHealth = ran.Next(10, 21);
            Console.WriteLine(Enemy.sDescription);
            Thread.Sleep(3000);
            while (Enemy.iHealth > 1 )
            {
                Enemy.iAttack = ran.Next(0, 11);
                int hit = ran.Next(0, 11);
                switch (randEnemy)
                {
                    case 1:
                        fight.Fight();
                        break;
                    case 2:
                        fight.Fight2();
                        break;
                    case 3:
                        fight.Fight3();
                        break;
                    default:
                        fight.Fight3();
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("you should attack: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string sCommand = Console.ReadLine();
                switch (sCommand)
                {
                    case "attack":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (hit > 3)
                        {
                            Enemy.iHealth -= Player.PlayerAttack();
                            Console.WriteLine("You attacked the enemy!");
                            Thread.Sleep(3000);
                        }
                        else {
                            Console.WriteLine("You attacked the enemy, BUT MISSED!!");
                            Thread.Sleep(3000);
                        }
                        if (Enemy.iAttack < 5)
                        {
                            Player.iHealth -= Enemy.iAttack;
                            Console.WriteLine("The enemy attacked you!");
                            Thread.Sleep(3000);
                        }
                        else {
                            Console.WriteLine("The enemy attacked you, BUT MISSED!");
                            Thread.Sleep(3000);
                        }
                        
                        break;
                    
                }

                if (Player.iHealth == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have died!!!!");
                    Program.quit = true;
                    Console.ReadKey();
                    return Program.quit;
                }
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("You have killed your enemy!");
            Thread.Sleep(3000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Player.GetCurrentCave().DescribeCave();
            return false;
        }

        public static void ShowTitleScreen()
        {
            Console.SetWindowSize(90, 50);
            Program.sUserName = "";
            bool bValidName = false;
            string sConfirmation = "";
            while (!bValidName)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("|88888888ba  88888888ba    ,ad8888ba,                                          |");
                Console.WriteLine("|88      8b 88         8b d8        8b                                         |");
                Console.WriteLine("|88      ,8P 88      ,8P d8                                                    |");
                Console.WriteLine("|88aaaaaa8P' 88aaaaaa8P' 88                                                    |");
                Console.WriteLine("|88    88'   88      '   88      88888                                         |");
                Console.WriteLine("|88    `8b   88          Y8,        88                                         |");
                Console.WriteLine("|88     `8b  88           Y8a.    .a88                                         |");
                Console.WriteLine("|88      `8b 88             Y88888P                                            |");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|  Pick the gold and get out                                                   |");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|  What's your name?                                                           |");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Program.sUserName = Console.ReadLine();
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0}, is this rigth? (yes or no)", Program.sUserName);
                Console.ForegroundColor = ConsoleColor.Green;
                sConfirmation = Console.ReadLine();
                if (sConfirmation == "yes" || sConfirmation == "y")
                {
                    bValidName = true;
                }
            }

        }

        public static void StartGame()
        {
            string sClass = "";
            Program.iClass = 0;
            while (Program.iClass == 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("| What's your class?                                                           |");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n|(1)Archer                (2)Sword Fighter                    (3)Mage          |");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                sClass = Console.ReadLine();
                Program.iClass = CheckInt(sClass);
                if ((Program.iClass != 1) && (Program.iClass != 2) && (Program.iClass != 3))
                {
                    Program.iClass = 0;
                }
            }
            Console.Clear();
            Player.GetCurrentCave().ShowTitle();
            Player.GetCurrentCave().DescribeCave();
        }

        public static int CheckInt(string sValue)
        {
            int value;
            if (!int.TryParse(sValue, out value))
            {
                return 0;
            }
            return value;
        }


        public static void EndGame(string endingText)
        {
            // quit the while loop by changing quit to true
            Program.quit = true;

            // clear console
            Console.Clear();

            // display ending message
            Console.ResetColor();
            Console.WriteLine("Game is over");
            Console.Write("\nYou may now close this window.");
            Console.CursorVisible = false;

            
        }

        public static bool GameRules()
        {
            if (Player.iHealth == 0) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have died!!!!");
                Program.quit = true;
                Console.ReadKey();
                return Program.quit;
            }
            if (Player.iWin == 1 && Player.GetCurrentCave() == World.arrayCaves[0,3]) {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("You have Won the Game!!!!");
                Program.quit = true;
                Console.ReadKey();
                return Program.quit;
            }

            if (Program.iBossKill == 0 && Player.iPosX == 0 && Player.iPosY == 3)
            {

                GameManager.BossEncounter();
                Program.iBossKill++;
            }


            return false;
        }
    }
}
