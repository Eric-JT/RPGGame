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

        /* Create caves - outline for each cave, used to build the game world */
        
        // Store titles for each cave
        protected string m_sCaveTitle;
        
        // Store description of cave
        protected string m_sCaveDescription;
        
        // Store Items and available Exits in cave - list
        protected List<string> exits;

        public Cave(){
            exits = new List<string>();
        }
        
        /* * * Get/Set methods * * */
        /* * * Cave Titles * * */
        public string sCaveTitle
        {
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
            get {
                return m_sCaveDescription;
            }
            set {
                m_sCaveDescription = value;
            }
        }

        /* * * Cave Description More detail * * */
        public void sDescribeCave()
        {
            Console.WriteLine(this.m_sCaveDescription);
            Console.WriteLine(this.GetListOfExits() );
            // display items in room
        }

        /* * * Display Title * * */
        public void ShowTitle()
        {
            Console.WriteLine(this.sCaveTitle);
        }
        
        
        // store exits in cave - list
        
        // Describe()
                
        // ShowTitle()
                
        // GetItem()
               
        // AddExit()
         
        // RemoveExit()
                
        // CanExit()
               
        // GetItemList()
               
        // GetExitList()
        private string GetListOfExits()
        {
            string sExit = "";
            string sMessage = "Available exits are: ";

            // check if there are exits in the cave
            if (this.exits.Count > 0) {
                foreach (string sExitDirection in this.exits) {
                    sExit += "\n" + sExitDirection;
                }
            }
            else {
                sExit = "\nNone";
            }
            return sMessage + sExit;
        }
               
        // GetCoordinates()

        /* * * Check for valid directions * * */
        public static bool IsValidDirection(string direction)
        {
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