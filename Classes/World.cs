using System;

namespace RPGGame
{
    class World
    {
        // Multidemensional array to store the cave map
        private static Cave[,] m_arrayCave;
    
        /* * * Get methods * * */
        /* * * cave* * */
        public static Cave[,] arrayCaves
        {
          // input two integer values and get the current cave
          get { return m_arrayCave; }
        }

        public static void InitializeWorlds()
        {
          // create the worlds
          BuildCaves();
        }

        private static void BuildCaves()
        {
            // define the world size, how many caves
            m_arrayCave = new Cave[2, 2];

            Cave cave; // create a new cave object
            Items item; // create a new item object for the cave

            
            // the cave entrance
            cave = new Cave();

            // Assign this cave to location 0, 0
            m_arrayCave[0, 0] = cave;

            // Setup the cave
            cave.sCaveTitle = "Spooky Cave Entrance";
            cave.sDescription = "You have entered the Spooky Cave Entrance. There is a locked door to the South.";
            cave.AddExit(Cave.sEast);

           // create item
            item = new Items();
            item.sTitle = "piece of shin bone";
            item.sPickupText = "You just picked up the shin bone.";
            cave.Items.Add(item);

            
            // large cave hall
            cave = new Cave();

            // Assign this cave to location 1, 0
            m_arrayCave[1, 0] = cave;

            // Setup the cave
            cave.sCaveTitle = "Large Cave Hall";
            cave.sDescription = "You have entered the Large Cave Hall.";
            // two exits in the room
            cave.AddExit(Cave.sWest);
            cave.AddExit(Cave.sSouth);

            // create a new item
            item = new Items();
            item.sTitle = "dirty rags";
            item.sPickupText = "As feel the slime from the dirty rags ooze onto your fingers. But for some reason you take the rags anyways.";
            item.iWeight = 2;
            cave.Items.Add(item);

            // create new item
            item = new Items();
            item.sTitle = "cherries";
            item.sPickupText = "Your heart warms with joy because you found cherries as you havent eatten in days. Too bad you are allergic.";
            cave.Items.Add(item);

            // create new item
            item = new Items();
            item.sTitle = "worn key";
            item.sPickupText = "You have just picked up the worn key. Maybe you can open the locked door with it";
            cave.Items.Add(item);


            // Water Cave
            cave = new Cave();
            m_arrayCave[1, 1] = cave;
            cave.sCaveTitle = "Water Cave";
            cave.sDescription = "As you enter the new cave you realize it has been flooded. Good thing you are wearing shorts.";
            cave.AddExit(Cave.sWest);
            cave.AddExit(Cave.sNorth);

            // create a new Items
            item = new Items();
            item.sTitle = "broken key";
            item.sPickupText = "You picked up a broken key.";
            cave.Items.Add(item);

            
            // Shiny Cave
            cave = new Cave();
            m_arrayCave[0, 1] = cave;
            cave.sCaveTitle = "Shiny Cave";
            cave.sDescription = "You have entered the shiny cave. You notice gold and a locked door to the north.";
            cave.AddExit(Cave.sEast);

            // create a new Items
            item = new Items();
            item.sTitle = "gold";
            item.sPickupText = "You just picked up a bunch of gold..";
            item.iWeight = 4;
            cave.Items.Add(item);

            // ADD THE PLAYER TO THE GAME
            // place the player at position x and y
            //Player.iPosX = 0;
            //Player.iPosY = 0;
        }

        
           
           

           
    }
}