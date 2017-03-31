using System;
using System.Collections.Generic;

namespace RPGGame
{
    class Cave
    {
        
        /* Create caves - outline for each cave, used to build the game world */
        
        // Store titles for each cave
        protected string m_sCaveTitle;
        
        // Store description of cave
        protected string m_sCaveDescription;
        
        // Store Items and available Exits in cave - list
        protected List<string> exits;

        public Cave(){

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
        
        
        // store exits in cave - list
        
        // Describe()
                
        // ShowTitle()
                
        // GetItem()
               
        // AddExit()
         
        // RemoveExit()
                
        // CanExit()
               
        // GetItemList()
               
        // GetExitList()
               
        // GetCoordinates()
    }    
}