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
        public string connectionstring = "Data Source=LAPTOP-BOMR24KV;Initial Catalog = Library For Video games; Integrated Security = True";
        
        public void GameAddlist(Game_S game)
        {
            using SqlConnection connection = new(connectionstring);
            connection.Open();

            string getFkey = "SELECT TOP 1 LibraryID FROM GLibrary ORDER BY LibraryID DESC";
            using SqlCommand getFkeycmd = new(getFkey, connection);
            int FKeyID = Convert.ToInt32(getFkeycmd.ExecuteScalar());

            string SQL = "INSERT INTO Games (GName,GDescription,GHours,Fkey)" +
                         "VALUES(@GName,@GDescription,@GHours,@Fkey)" +
                         "SELECT SCOPE_IDENTITY()";

            using SqlCommand cmd = new(SQL, connection);
            cmd.Parameters.AddWithValue("@GName",game.Name);
            cmd.Parameters.AddWithValue("@GDescription",game.Description);
            cmd.Parameters.AddWithValue("@GHours",game.Hours);
            cmd.Parameters.AddWithValue("@Fkey", FKeyID);
            
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            game.ID = id;
            
            connection.Close();
        }

        public void LibraryADD(Library library)
        { 
            using SqlConnection connection = new(connectionstring);
            connection.Open();

            string SQL = "INSERT INTO GLibrary (Steam, Epic, Other)" +
                         "VALUES(@Steam,@Epic,@Other)SELECT SCOPE_IDENTITY()";
            using SqlCommand cmd = new(SQL, connection);
            cmd.Parameters.AddWithValue("@Steam", library.Steam);
            cmd.Parameters.AddWithValue("@Epic", library.Epic);
            cmd.Parameters.AddWithValue("@Other", library.Other);

            int id = Convert.ToInt32(cmd.ExecuteScalar());
            library.ID = id;
            connection.Close();
        }
        public void DeleteObjects(Library library,Game_S game)
        {
            using SqlConnection connection = new(connectionstring);
            connection.Open();

            string SQL = "DELETE FROM Games WHERE ID = @ID";
            using SqlCommand cmd = new(SQL, connection);
            cmd.Parameters.AddWithValue("@ID", game.ID);
            string sql = "DLETE FROM GLibrary WHERE LibraryID = @lID";
            using SqlCommand CMD = new(sql, connection);
            CMD.Parameters.AddWithValue("@lID", library.ID);

            connection.Close();
        }
    }
}
