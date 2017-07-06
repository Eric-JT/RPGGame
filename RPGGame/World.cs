using System;

namespace RPGGame
{
    class World
    {
        private static int m_iCaveX;
        private static int m_iCaveY;
        // Multidemensional array to store the cave map
        private static Cave[,] m_arrayCave;

        /* * * Get methods * * */
        /* * * cave* * */
        public static Cave[,] arrayCaves
        {
          // input two integer values and get the current cave
          get { return m_arrayCave; }
        }

        public static int caveX
        {
            get { return m_iCaveX; }
            set { m_iCaveX = value; }
        }

        public static int caveY
        {
            get { return m_iCaveY; }
            set { m_iCaveY = value; }
        }

        public static void InitializeWorlds()
        {
          // create the worlds
          BuildCaves();
        }

        /*
        public static void DisplayWorld()
        {
            for (int row =0; row <= caveY; row++) {
                fo
            }
        }
        */
        private static void BuildCaves()
        {
            caveX = 3;
            caveY = 4;
            // define the world size, how many caves
            m_arrayCave = new Cave[caveX, caveY]; // 3 by 4 grid Y by X

            Cave cave; // create a new cave object
            Items item; // create a new item object for the cave
  

            // ***************the cave entrance
            cave = new Cave();

            // Assign this cave to location 0, 0
            m_arrayCave[0, 0] = cave;

            // Setup the cave
            cave.sCaveTitle = "Spooky Cave Entrance [0, 0]";
            cave.sDescription = "You have entered the Spooky Cave Entrance. There is a locked door to the South.";
            cave.AddExit(Cave.sSouth);

           // create item
            item = new Items();
            item.sTitle = "shin bone";
            item.sPickupText = "You just picked up the shin bone.";
            cave.Items.Add(item);
         

            // **********************large cave hall
            cave = new Cave();

            m_arrayCave[1, 0] = cave;

            // Setup the cave
            cave.sCaveTitle = "Large Cave Hall [1, 0]";
            cave.sDescription = "You have entered the Large Cave Hall.";
            // two exits in the room
            cave.AddExit(Cave.sNorth);
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

            

            //*************** Water Cave
            cave = new Cave();
            m_arrayCave[2, 0] = cave;
            cave.sCaveTitle = "Water Cave [2, 0]";
            cave.sDescription = "As you enter the new cave you realize it has been flooded. Good thing you are wearing shorts.";
            cave.AddExit(Cave.sEast);
            cave.AddExit(Cave.sNorth);

            // create a new Items
            item = new Items();
            item.sTitle = "broken key";
            item.sPickupText = "You picked up a broken key.";
            cave.Items.Add(item);

            //*************** Shiny Cave
            cave = new Cave();
            m_arrayCave[2, 1] = cave;
            cave.sCaveTitle = "Shiny Cave [2, 1]";
            cave.sDescription = "You have entered the shiny cave. You notice gold and a locked door to the north.";
            cave.AddExit(Cave.sNorth);
            cave.AddExit(Cave.sWest);

            // create a new Items
            item = new Items();
            item.sTitle = "grass";
            item.sPickupText = "You just picked up a bunch of grass..";
            item.iWeight = 4;
            cave.Items.Add(item);

            //*************** Water Cave
            cave = new Cave();
            m_arrayCave[1, 1] = cave;
            cave.sCaveTitle = "Water Cave Continued [1, 1]";
            cave.sDescription = "the water gets deeper as you move farther into the darkness";
            cave.AddExit(Cave.sSouth);
            cave.AddExit(Cave.sNorth);

            // create a new Items
            item = new Items();
            item.sTitle = "broken key";
            item.sPickupText = "You picked up a broken key.";
            cave.Items.Add(item);

            //*************** Shiny Cave
            cave = new Cave();
            m_arrayCave[0, 1] = cave;
            cave.sCaveTitle = "Edge of watery cave [0, 1]";
            cave.sDescription = "You have made it to tend of the watery cave. you see a small whole to the east.";
            cave.AddExit(Cave.sSouth);
            cave.AddExit(Cave.sEast);

            // create a new Items
            item = new Items();
            item.sTitle = "taco";
            item.sPickupText = "You just picked up a bunch of tacos..";
            item.iWeight = 4;
            cave.Items.Add(item);


            //*************** Water Cave
            cave = new Cave();
            m_arrayCave[0, 2] = cave;
            cave.sCaveTitle = "small hole  [0, 2]";
            cave.sDescription = "As you enter the small hole a part of you rethinks this entire adventure. but you go anyways.";
            cave.AddExit(Cave.sWest);
            cave.AddExit(Cave.sSouth);

            // create a new Items
            item = new Items();
            item.sTitle = "broken key";
            item.sPickupText = "You picked up a broken key.";
            cave.Items.Add(item);

            //*************** Shiny Cave
            cave = new Cave();
            m_arrayCave[1, 2] = cave;
            cave.sCaveTitle = "small hole continued [1, 2] ";
            cave.sDescription = "the small hole keeps getting smaller... luckily you see light at the end.";
            cave.AddExit(Cave.sNorth);
            cave.AddExit(Cave.sSouth);

            // create a new Items
            item = new Items();
            item.sTitle = "gameboy";
            item.sPickupText = "You just picked up a gameboy..";
            item.iWeight = 4;
            cave.Items.Add(item);

            //*************** Water Cave
            cave = new Cave();
            m_arrayCave[2, 2] = cave;
            cave.sCaveTitle = "small hole continued [2, 2]";
            cave.sDescription = "You have made it to the end of the small hole. you can exit to the east or go back north.";
            cave.AddExit(Cave.sEast);
            cave.AddExit(Cave.sNorth);

            // create a new Items
            item = new Items();
            item.sTitle = "broken key";
            item.sPickupText = "You picked up a broken key.";
            cave.Items.Add(item);

            //*************** Shiny Cave
            cave = new Cave();
            m_arrayCave[2, 3] = cave;
            cave.sCaveTitle = "Dungeon [2, 3]";
            cave.sDescription = "You have entered a dungean.";
            cave.AddExit(Cave.sWest);
            cave.AddExit(Cave.sNorth);

            // create a new Items
            item = new Items();
            item.sTitle = "gold";
            item.sPickupText = "You just picked up a bunch of gold..";
            item.iWeight = 4;
            cave.Items.Add(item);

            //*************** Shiny Cave
            cave = new Cave();
            m_arrayCave[1, 3] = cave;
            cave.sCaveTitle = "dungeon [1, 3]";
            cave.sDescription = "the dungeon looks as if it hasn't been used in a while";
            cave.AddExit(Cave.sSouth);
            cave.AddExit(Cave.sNorth);

            // create a new Items
            item = new Items();
            item.sTitle = "golphers";
            item.sPickupText = "You just picked up a bunch of golphers..";
            item.iWeight = 4;
            cave.Items.Add(item);

            //*************** Shiny Cave
            cave = new Cave();
            m_arrayCave[0, 3] = cave;
            cave.sCaveTitle = "end of dungeon [0, 3]";
            cave.sDescription = "Hey you made it to the end of the dungeon.";
            cave.AddExit(Cave.sSouth);

            // create a new Items
            item = new Items();
            item.sTitle = "shoe";
            item.sPickupText = "You just picked up a shoe..";
            item.iWeight = 4;
            cave.Items.Add(item);


            // ADD THE PLAYER TO THE GAME
            // place the player at position x and y

            Player.iPosX = 0;
            Player.iPosY = 0;

            
            
           Enemy.iPosX = Player.iPosX;
           Enemy.iPosY = Player.iPosY;
            
            
        }

    }
}
