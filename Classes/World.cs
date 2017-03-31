using System;

namespace RPGGame
{
    class World
    {
        // Multidemensional array to store the cave map
        private static Cave[,] m_aCave;
    
        /* * * Get methods * * */
        /* * * cave* * */
        public static Cave[,] caves
        {
          get { return m_aCave; }
        }

        public static void InitializeWorlds()
        {
          BuildCaves();
        }

        private static void BuildCaves()
        {
           // set the size of the world/Amount of caves
           m_aCave = new Cave[2,2];

           Cave cave;

           // Create the first room
           cave = new Cave();

           // assign room to the location 0,0
           m_aCave[0,0] = cave;
           cave.sCaveTitle = "Cave Entrance";
           cave.sDescription = "You have entered the spooky cave. The only direction you can move is East.";
           // Need to add exits

           // create items

           // add the items
           
           // follow the same code to create more rooms

           // Place the [;ayer at starting POS [0,0] 
        }

        
           
           

           
    }
}