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
        public ObservableCollection<Game_S> Games = new();
        public ObservableCollection<Game_S> GameAddlist(Game_S game)
        {
            if(Games == null) 
            {
                Games = new ObservableCollection<Game_S>();
            }

            int GameID = game.ID;
            string GName = game.Name;
            string GDescrip = game.Description;
            int GHours = game.Hours;
            int FkeyID = game.ForignkeyID;
            Game_S game_S = new(GameID, GName, GDescrip, GHours, FkeyID);
            Games.Add(game_S);
            return Games;
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
