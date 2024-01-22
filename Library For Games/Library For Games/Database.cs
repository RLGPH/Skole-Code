using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace Library_For_Games
{
    
    public class Database
    {
        public List<Game_S>? Gamesdatabase;
        public List<Game_S> GameAddlist(Game_S game)
        {
            if(Gamesdatabase == null) 
            {
                Gamesdatabase = new List<Game_S>();
            }

            int GameID = game.ID;
            string GName = game.Name;
            string GDescrip = game.Description;
            int GHours = game.Hours;
            int FkeyID = game.ForignkeyID;
            Game_S game_S = new(GameID, GName, GDescrip, GHours, FkeyID);
            Gamesdatabase.Add(game_S);
            return Gamesdatabase;
        }

        public List<Game_S> GetGames()
        {
            if (Gamesdatabase == null) 
            {
            }
            else
            {
                
            }
            return Gamesdatabase;
        }

        public void LibraryADD(Library library)
        { 
            int ID = library.ID;
            bool Epic = library.Epic;
            bool Steam = library.Steam;
            bool Other = library.Other;
        }
    }
}
