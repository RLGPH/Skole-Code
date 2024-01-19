using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_For_Games
{
    public List<Game_S> videogames = new();
    public class Database
    {
        public void GameUpdateList(Game_S game) 
        {
            int GameID = game.ID;
            string GName = game.Name;
            string GDescrip = game.Description;
            int GHours = game.Hours;
            int FkeyID = game.ForignkeyID;

        }
    }
}
