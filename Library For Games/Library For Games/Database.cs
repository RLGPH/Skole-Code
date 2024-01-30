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

        List<Combind> combind = new();

        //----------------ADD'S to the SQL Server----------------//
        public void GameAddlist(Game_S game)
        {
            using SqlConnection connection = new(connectionstring);
            connection.Open();

            string getFkey = "SELECT TOP 1 LibraryID FROM GLibrary ORDER BY LibraryID DESC";
            using SqlCommand getFkeycmd = new(getFkey, connection);
            int FKeyID = Convert.ToInt32(getFkeycmd.ExecuteScalar());

            string SQL = "INSERT INTO Games (GName,GDescription,GHours,LibraryID)" +
                         "VALUES(@GName,@GDescription,@GHours,@LibraryID)" +
                         "SELECT SCOPE_IDENTITY()";

            using SqlCommand cmd = new(SQL, connection);
            cmd.Parameters.AddWithValue("@GName",game.Name);
            cmd.Parameters.AddWithValue("@GDescription",game.Description);
            cmd.Parameters.AddWithValue("@GHours",game.Hours);
            cmd.Parameters.AddWithValue("@LibraryID", FKeyID);
            
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
        //----------------ADD'S to the SQL Server----------------//

        //----------------Deletes the things in the SQL SERVER----------------//
        public void DeleteObjects(Library library, Game_S game)
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
        //----------------Deletes the things in the SQL SERVER----------------//

        //----------------gets the games----------------//
        public List<Combind> GetAndCombind() 
        {
            if(combind == null)
            {
                combind = new List<Combind>();
            }
            else
            {
                combind.Clear();
            }
            using SqlConnection connection = new(connectionstring);
            connection.Open();

            string sql = "SELECT * FROM Games INNER JOIN GLibrary ON Games.LibraryID = GLibrary.LibraryID";

            using SqlCommand cmd = new(sql, connection);
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int ID = (int)reader["ID"];
                string Name = (string)reader["GName"];
                string Description = (string)reader["GDescription"];
                int Hours = (int)reader["GHours"];
                int FKey = (int)reader["LibraryID"];
                int FID = (int)reader["LibraryID"];
                bool Steam = (bool)reader["Steam"];
                bool Epic = (bool)reader["Epic"];
                bool Other = (bool)reader["Other"];

                Combind combinds = new(ID,Name,Description,Hours,FKey,FID,Steam,Epic,Other);
                
                combind.Add(combinds);
            }
            connection.Close();

            return combind;
        }
        public void GetUsingID(Game_S game,Library library,int SearchID)
        {
            using SqlConnection connection = new(connectionstring);
            connection.Open();

            string sql = "SELECT * FROM Games INNER JOIN GLibrary ON Games.LibraryID = GLibrary.LibraryID WHERE Games.ID = @GameID";

            

            using SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@GameID", SearchID);

            using SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                // Assuming the column names in your database match the properties of your Game_S class
                game.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                game.Name = reader.GetString(reader.GetOrdinal("Name"));
                game.Description = reader.GetString(reader.GetOrdinal("Description"));
                game.Hours = reader.GetInt32(reader.GetOrdinal("Hours"));
                // Assuming the Library information is also retrieved and stored in your Library object
                library.ID = reader.GetInt32(reader.GetOrdinal("LibraryID"));
                library.Epic = reader.GetBoolean(reader.GetOrdinal("Epic"));
                library.Steam = reader.GetBoolean(reader.GetOrdinal("Steam"));
                library.Other = reader.GetBoolean(reader.GetOrdinal("Other"));
            }
            connection.Close();
        }
        //----------------gets the games----------------//
    }
}
