using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Library_For_Games
{
    
    public class Database
    {
        public string connectionstring = "Data Source=LAPTOP-BOMR24KV;Initial Catalog = Library For Video games; Integrated Security = True; Trust Server Certificate=True";
        
        public void GameAddlist(Game_S game)
        {
            using SqlConnection connection = new(connectionstring);
            connection.Open();

            using SqlCommand cmd = connection.CreateCommand();

            int GameID = game.ID;
            string GName = game.Name;
            string GDescrip = game.Description;
            int GHours = game.Hours;
            int FkeyID = game.ForignkeyID;
            Game_S game_S = new(GameID, GName, GDescrip, GHours, FkeyID);

            connection.Close();
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
