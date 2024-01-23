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

            string SQL = "INSERT INTO Game (GName,GDescription,GHours,Fkey)" +
                         "VAUES(@GName,@GDescription,@GHours,@Fkey)SELECT SCOPE_IDENTITY()";

            using SqlCommand cmd = new(SQL, connection);
            cmd.Parameters.AddWithValue("@GName",game.Name);
            cmd.Parameters.AddWithValue("@GDescription",game.Description);
            cmd.Parameters.AddWithValue("@GHours",game.Hours);
            cmd.Parameters.AddWithValue("@Fkey",game.ForignkeyID);
            
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
