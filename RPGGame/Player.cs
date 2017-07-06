using System;
using System.Collections.Generic;
using System.Threading;

namespace RPGGame
{
    static class Player
    {
        private static int m_iPlayerPosX; // player x position
        private static int m_iPlayerPosY; // player y position
        private static List<Items> m_listItemInventory; // list of items on player
        private static int m_iMaxWeight = 6; // max weight player can have
        private static int m_iHealth = 100; // max health for the player
        private static int m_iSoftAttack = 5;
        private static int m_iMediumAttack = 10;
        private static int m_iHeavyAttack = 20;
        private static int m_iWinItem = 0;

        static Player()
        {
            m_listItemInventory = new List<Items>();
        }

        public static int iWin
        {
            get { return m_iWinItem; } // get the health value
            set { m_iWinItem = value; } // set the health value
        }

        public static int iHealth
        {
            get { return m_iHealth; } // get the health value
            set { m_iHealth = value; } // set the health value
        }


        public static int iPosX
        {
            get { return m_iPlayerPosX; } // get the player X curent location
            set { m_iPlayerPosX = value; } // set the player X locatoin
        }


        public static int iPosY
        {
            get { return m_iPlayerPosY; } // get the player Y location
            set { m_iPlayerPosY = value; } // set the player Y location
        }


        public static int InventoryWeight
        {
            get
            {  // get the weight of each item in the players inventory
                int result = 0;
                foreach (Items item in m_listItemInventory)
                {
                    result += item.iWeight;
                }
                return result;
            }
        }


        public static void Move(string direction)
        {
            Cave room = Player.GetCurrentCave(); // get the current location
            if (!room.CanExit(direction)) // check if the location has an exit
            {
                Console.WriteLine("Invalid direction");
                return; // the player cannot move then break out of this method
            }


            switch (direction)
            {   
                // check the string direction
                // increase or decrease the player X and Y location values
                case Cave.sWest:
                    m_iPlayerPosY--;
                    break;
                case Cave.sEast:
                    m_iPlayerPosY++;
                    break;
                case Cave.sSouth:
                    m_iPlayerPosX++;
                    break;
                case Cave.sNorth:
                    m_iPlayerPosX--;
                    break;
            }

            Player.GetCurrentCave().DescribeCave(); // return the cave description
        }

        // Get methods for attack type
        // the type of player class chosen decides which type of attack is used 
        public static int SoftAttack
        {     // archer
            get
            {
                return m_iSoftAttack;
            }
        }

        public static int MediumAttack
        {    // sword fighter
            get
            {
                return m_iMediumAttack;
            }
        }

        public static int StrongAttack
        {    // mage
            get
            {
                return m_iHeavyAttack;
            }
        }


        public static int PlayerAttack()
        {
            switch (Program.iClass)
            {
                case 1: // archer
                    Console.WriteLine("You fire an arrow to the enemy ");
                    Thread.Sleep(3000);
                    return m_iSoftAttack;
                case 2: // sword fighter
                    Console.WriteLine("You swing your sword against your enemy ");
                    Thread.Sleep(3000);
                    return m_iMediumAttack;
                case 3: // mage
                    Console.WriteLine("You cast a spell on your enemy");
                    Thread.Sleep(3000);
                    return m_iHeavyAttack;
            }
            return 0;
        }


        public static void PickupItem(string itemName)
        {
            Cave cave = Player.GetCurrentCave(); // get the current location
            Items item = cave.GetItem(itemName); // get the item from the cave or get null

            if (item != null)
            {
                if (Player.InventoryWeight + item.iWeight > Player.m_iMaxWeight)
                { // check if the player can carry anymore items
                    Console.WriteLine("You must firt drop some weight before you can pick up that item.");
                    return; // if the player cannot carry anymore items break out of the function
                }

                if (itemName == "gold") {
                    iWin = 1;
                }
                cave.Items.Remove(item); // remove the item from the cave item list
                Player.m_listItemInventory.Add(item); // add the item to the player inventory list
                Console.WriteLine(item.sPickupText); // write pick up text for the item
            }
            else
            {  // if item is null then inform the player there is no item in room
                Console.WriteLine("There is no " + itemName + " in this room.");
            }
        }


        public static void DropItem(string itemName)
        {
            Cave cave = Player.GetCurrentCave(); // get the current location
            Items item = GetInventoryItem(itemName); // get the item from the player or get null

            if (item != null)
            {
                if (itemName == "gold")
                {
                    iWin = 0;
                }
                Player.m_listItemInventory.Remove(item); // remove item from the player inventorylist 
                cave.Items.Add(item); // add item to the cave item list
                Console.WriteLine("The " + itemName + " has been dropped into this room");
            }
            else if (itemName == "")
                Console.WriteLine("You waved you hands in the air.");
            else
                Console.WriteLine("you are not carrying {0}", itemName);
        }

        public static void DisplayInventory()
        {
            string message = "You look inside your pack \n";
            string items = "";

            // check the player is carrying items
            if (m_listItemInventory.Count > 0)
            { 
                foreach (Items item in m_listItemInventory)
                {
                    // fore each item in the player item list 
                    items += "\n" + item.sTitle +"wt: " + item.iWeight.ToString();
                }
            }
            else // no items in player inventoy list
                items = "\nYou are not carrying anything!!";
            // show the total weight of each item in the player item list
            items += "\n\nTotal Wt: " + Player.InventoryWeight + " / " + Player.m_iMaxWeight;

            Console.WriteLine("{0} \n {1}",message,items); // write the list of items to the screen
        }

        public static Cave GetCurrentCave()
        {
            // get the players current cave location in the world
            return World.arrayCaves[m_iPlayerPosX, m_iPlayerPosY];
        }


        public static Items GetInventoryItem(string itemName)
        {
            foreach (Items item in m_listItemInventory)
            {
                // return each item in the player item inventory list
                if (item.sTitle.ToLower() == itemName.ToLower())
                    return item;
            }
            return null;
        }

  


    }
}

