using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_For_Games
{
    
    public class Database
    {
        public List<Game_S> game_s = new();
        public List<Game_S> GameAddList(Game_S game) 
        {
            game_s = new List<Game_S>();
            int GameID = game.ID;
            string GName = game.Name;
            string GDescrip = game.Description;
            int GHours = game.Hours;
            int FkeyID = game.ForignkeyID;
            Game_S game_S = new(GameID, GName, GDescrip, GHours, FkeyID);
            game_s.Add(game_S);
            return game_s;
        }
    }
}
