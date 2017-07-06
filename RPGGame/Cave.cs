using System;
using System.Collections.Generic;

namespace RPGGame
{
    class Cave
    {
        // Directions to move
        public const string sNorth = "north";
        public const string sSouth = "south";
        public const string sWest = "west";
        public const string sEast = "east";

        // Store titles for each cave
        protected string m_sCaveTitle;
        
        // Store description of cave
        protected string m_sCaveDescription;
        
        protected List<string> m_listsExits; // available Exits in cave - list
        protected List<Items> m_listItems;  // available Items in cave - list

        public List<Items> Items
        {
            // store and retrieve item names in cave
            get {
                return m_listItems;
            }
            set {
                m_listItems = value;
            }
        }

        public Cave(){
            // for each cave created, crete a list of exits and items
            m_listsExits = new List<string>();
            m_listItems = new List<Items>();
        }
        
        /* * * Get/Set methods * * */
        /* * * Cave Titles * * */
        public string sCaveTitle
        {
            // store or retrieve cave title
            get {
                return m_sCaveTitle;
            }
            set {
                m_sCaveTitle = value;
            }
        }

        /* * * Cave Description * * */
        public string sDescription
        {
            // store or retrieve cave description
            get {
                return m_sCaveDescription;
            }
            set {
                m_sCaveDescription = value;
            }
        }

        /* * * Cave Description More detail * * */
        public void DescribeCave()
        {
            // write out decription, list of items, list of available exits
            Console.WriteLine(this.m_sCaveDescription);
            Console.WriteLine(this.GetListOfExits());
            Console.WriteLine(this.GetListOfItems());
        }

        public Items GetItem(string itemName)
        {
            // input string for item name
            // check each item in the cave
            // if the item is in the room return that item
            // else return nothing
            foreach (Items item in this.m_listItems)
            {
                if (item.sTitle.ToLower() == itemName.ToLower())
                    return item;
            }
            return null;
        }

        private string GetListOfItems()
        {
            // create empty string to store items in
            // create output message
            string sItem = "";
            string sOutput = "Items in Cave:";

            // if the item list of the current cave is > 0
            // add each item to item list
            // return the list of items
            // else return none
            if (this.m_listItems.Count > 0)
            {
                foreach (Items item in this.m_listItems)
                {
                    sItem += "\n[" + item.sTitle + "]";
                }
            }
            else
            {
                sItem = "\n<none>";
            }

            return "\n" + sOutput + "\n" + sItem;
        }


        /* * * Display Title * * */
        public void ShowTitle()
        {
            // Write out the title to the current cave
            Console.WriteLine(this.sCaveTitle);
        }
        
        /* * * Exits * * */
        public void AddExit(string directon)
        {
            // input is a direction
            // adds an exit refuring to the given direction
            if (this.m_listsExits.IndexOf(directon) == -1)
                this.m_listsExits.Add(directon);
            
        }

        public bool CanExit(string direction)
        {
            // input is a string
            // return true or false if the player can exit the given direction
            foreach (string validExit in this.m_listsExits)
            {
                if (direction == validExit)
                    return true;
            }
            return false;
        }
    
               
        /* * * Get list of exits * * */
        private string GetListOfExits()
        {
            // Check the list of exits for the given cave
            // output a list of exits
            string sExit = "";
            string sOutput = "You can exit: ";

            // check if there are exits in the cave
            if (this.m_listsExits.Count > 0) {
                foreach (string sExitDirection in this.m_listsExits) {
                    sExit += "\n" + sExitDirection;
                }
            }
            else {
                sExit = "\nNone";
            }
            return sOutput + sExit;
        }
               
  

        /* * * Check if move is a valid direction for cave * * */
        public static bool IsValidDirection(string direction)
        {
            // input is a string, returns true or false
            switch (direction)
            {
                case sNorth:
                    return true;
                case sSouth:
                    return true;
                case sWest:
                    return true;
                case sEast:
                    return true;
            }
            return false;
        }

        
    }    
}
