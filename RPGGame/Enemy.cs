

// attack Player

// reduce players health when attacking
using System;

namespace RPGGame
{
    class Enemy
    {
        private static int m_iEnemyPosX;
        private static int m_iEnemyPosY;
        private static int m_iEnemyHealth;
        private static int m_iEnemyAttack;
        
        static string desc1 = "When you enter the cave, you saw an ugly creature. It looks like an alien and makes some weird voice. Unfortunately he heard you and start to run towards you. What are you going to do? ";
        static string desc2 = "It's dark inside and you think you saw a monster. You know what you have to do. Just kill that freak !!";
        static string desc3 = "Suddenly a little yellow creature hops up unto a nearby rock ! ";
        static string desc4 = "OMG you finally found the dark magician !! He is the big boss be careful !!";
        private static string[] m_iEnemyDescription = new string[]
        { desc1, desc2, desc3, desc4 };


        
        public static int iPosX
        {
            get { return m_iEnemyPosX; }
            set { m_iEnemyPosX = value; }
        }
        
        public static int iPosY
        {
            get { return m_iEnemyPosY; }
            set { m_iEnemyPosY = value; }
        }
        
       
        public static int iHealth
        {
            get { return m_iEnemyHealth; }
            set { m_iEnemyHealth = value; }
        }

        
        public static int iAttack
        {
            get { return m_iEnemyAttack; }
            set { m_iEnemyAttack = value; }
        }

        public static string sBossDescription
        {
            get { return m_iEnemyDescription[3]; }
        }

        public static string sDescription
        {
           
            get
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(3);

                return m_iEnemyDescription[randomNumber];

            }
        }

    }
}