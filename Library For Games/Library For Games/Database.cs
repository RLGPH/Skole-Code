﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using System.Xml.Linq;

namespace Library_For_Games
{

    public class Database
    {
        //change data source to what ever you need but is the string need to connect to SQL database
        public string connectionstring = "Data Source=LAPTOP-BOMR24KV;Initial Catalog = Library For Video games; Integrated Security = True";

        List<Combind> combind = new();

        //----------------If allready in SQL Database------------//
        public void IfGameIsInDatabase(Game_S game, Library library)
        {
            using SqlConnection connection = new(connectionstring);
            connection.Open();

            string GetGname = "SELECT ID, GHours FROM Games WHERE GName = @gameName";

            using SqlCommand selectCommand = new(GetGname, connection);
            selectCommand.Parameters.AddWithValue("@gameName", game.Name);
            using SqlDataReader reader = selectCommand.ExecuteReader();

            if (reader.Read())
            {
                //gets gameID using gamename
                int gameId = reader.GetInt32(0);

                reader.Close();
                //opens to update relavent Data
                string sqlGame = "UPDATE Games SET GDescription = @GDescription, GHours = @GHours WHERE ID = @ID";
                string sqlLibrary = "UPDATE GLibrary SET Steam = @Steam, Epic = @Epic, Other = @Other WHERE LibraryID = @LibraryID";

                using SqlCommand updateGame = new(sqlGame, connection);
                using SqlCommand updateLibrary = new(sqlLibrary, connection);

                updateGame.Parameters.AddWithValue("@GHours", game.Hours);
                updateGame.Parameters.AddWithValue("@GDescription", game.Description);
                updateGame.Parameters.AddWithValue("@ID", gameId);
                updateGame.ExecuteNonQuery();

                updateLibrary.Parameters.AddWithValue("@Steam", library.Steam);
                updateLibrary.Parameters.AddWithValue("@Epic", library.Epic);
                updateLibrary.Parameters.AddWithValue("@Other", library.Other);
                updateLibrary.Parameters.AddWithValue("@LibraryID", gameId);
                updateLibrary.ExecuteNonQuery();
            }
            else
            {
                //incase reader is on shut it off
                reader.Close();
                //sends data to be added to database if it didnt already exist in the SQL database
                LibraryADD(library);
                GameAddlist(game);
            }
        }
        //----------------If allready in SQL Database------------//
        //----------------ADD'S to the SQL Server----------------//
        public void GameAddlist(Game_S game)
        {
            //uses string to open connection
            using SqlConnection connection = new(connectionstring);
            connection.Open();
            
            //selects latest library ID
            string getFkey = "SELECT TOP 1 LibraryID FROM GLibrary ORDER BY LibraryID DESC";
            using SqlCommand getFkeycmd = new(getFkey, connection);
            int FKeyID = Convert.ToInt32(getFkeycmd.ExecuteScalar());

            //inserts string tells what the names refer to
            string SQL = "INSERT INTO Games (GName,GDescription,GHours,LibraryID)" +
                         "VALUES(@GName,@GDescription,@GHours,@LibraryID)" +
                         "SELECT SCOPE_IDENTITY()";

            //the commands used to add said values
            using SqlCommand cmd = new(SQL, connection);
            cmd.Parameters.AddWithValue("@GName",game.Name);
            cmd.Parameters.AddWithValue("@GDescription",game.Description);
            cmd.Parameters.AddWithValue("@GHours",game.Hours);
            cmd.Parameters.AddWithValue("@LibraryID", FKeyID);
            
            //auto scale ID
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            game.ID = id;
            
            connection.Close();
        }

        public void LibraryADD(Library library)
        { 
            //opens connection using connection string
            using SqlConnection connection = new(connectionstring);
            connection.Open();

            //assoctiates which values is going to recive data
            string SQL = "INSERT INTO GLibrary (Steam, Epic, Other)" +
                         "VALUES(@Steam,@Epic,@Other)SELECT SCOPE_IDENTITY()";
            
            //sends/adds before mentioned data to SQL DATABASE
            using SqlCommand cmd = new(SQL, connection);
            cmd.Parameters.AddWithValue("@Steam", library.Steam);
            cmd.Parameters.AddWithValue("@Epic", library.Epic);
            cmd.Parameters.AddWithValue("@Other", library.Other);

            //executes the auto scalar
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            library.ID = id;

            //closes connection
            connection.Close();
        }
        //----------------ADD'S to the SQL Server----------------//
        //----------------Edit things in the SQL server----------//
        public void Editobjectsandopdates(Library library,Game_S game)
        {
            //opens connection usin connection string
            using SqlConnection connection = new(connectionstring);
            connection.Open();

            //asigning data postions with names
            string sqlGame = "UPDATE Games SET GName = @GName, GDescription = @GDescription, GHours = @GHours WHERE ID = @ID";
            string sqlLibrary = "UPDATE GLibrary SET Steam = @Steam, Epic = @Epic, Other = @Other WHERE LibraryID = @LibraryID";

            //gives and changes the data being give to SQL database
            using SqlCommand updateGame = new(sqlGame, connection);
            using SqlCommand updateLibrary = new(sqlLibrary, connection);
            updateGame.Parameters.AddWithValue("@GName", game.Name);
            updateGame.Parameters.AddWithValue("@GDescription", game.Description);
            updateGame.Parameters.AddWithValue("@GHours", game.Hours);
            updateGame.Parameters.AddWithValue("@ID", game.ID);
            updateGame.ExecuteNonQuery();

            updateLibrary.Parameters.AddWithValue("@Steam", library.Steam);
            updateLibrary.Parameters.AddWithValue("@Epic", library.Epic);
            updateLibrary.Parameters.AddWithValue("@Other", library.Other);
            updateLibrary.Parameters.AddWithValue("@LibraryID", library.ID);
            updateLibrary.ExecuteNonQuery();

            //close connection or does it damdam daaaa
            connection.Close();
        }
        //----------------Edit things in the SQL server----------//
        //----------------Get from steam If name allready exist--//
        public void ChecksSteamAndDatabase(Game_S game)
        {
            //do i need to explain this again i have already said it like 12 times
            using SqlConnection connection = new(connectionstring);
            connection.Open();

            //gives id and gamehours from the use of Name
            string selectQuery = "SELECT ID, GHours FROM Games WHERE GName = @gameName";

            //reads the gamename to see if there is one of the exact same
            using SqlCommand selectCommand = new(selectQuery, connection);
            selectCommand.Parameters.AddWithValue("@gameName", game.Name);
            using SqlDataReader reader = selectCommand.ExecuteReader();

            if (reader.Read())
            {
                //gets gameID using gamename
                int gameId = reader.GetInt32(0); 

                reader.Close();
                //opens to update relavent Data
                string updateQuery = "UPDATE Games SET GHours = @updatedHours, GDescription = @GDescription WHERE ID = @gameId";
                using SqlCommand updateCommand = new(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@updatedHours", game.Hours);
                updateCommand.Parameters.AddWithValue("@GDescription", game.Description);
                updateCommand.Parameters.AddWithValue("@gameId", gameId);
                updateCommand.ExecuteNonQuery();
            }
            else
            {
                //incase reader is on shut it off
                reader.Close();
                //sends data to be added to database if it didnt already exist in the SQL database
                Library library = new(1, false, true, false);
                LibraryADD(library);
                GameAddlist(game);   
            }

            connection.Close();
        }
        //----------------Get from steam If name allready exist--//
        //----------------Deletes the things in the SQL SERVER----------------//
        public void DeleteObjects(Library library, Game_S game)
        {
            //fine i guess i can explain it opens connection
            using SqlConnection connection = new(connectionstring);
            connection.Open();

            //deletes from both Games in database and GLibrary
            string SQL = "DELETE FROM Games WHERE ID = @ID";
            using SqlCommand cmd = new(SQL, connection);
            cmd.Parameters.AddWithValue("@ID", game.ID);
            string sql = "DLETE FROM GLibrary WHERE LibraryID = @lID";
            using SqlCommand CMD = new(sql, connection);
            CMD.Parameters.AddWithValue("@lID", library.ID);

            //heres jhony 
            connection.Close();
        }
        //----------------Deletes the things in the SQL SERVER----------------//

        //----------------gets the games----------------//
        public List<Combind> GetAndCombind() 
        {
            //if list is null instence list
            if(combind == null)
            {
                combind = new List<Combind>();
            }
            else
            {
                combind.Clear();
            }
            //guess what im stealing you data with this line. opens connection
            using SqlConnection connection = new(connectionstring);
            connection.Open();

            //joins both database aka compares if its the same id from the forign and main key
            string sql = "SELECT * FROM Games INNER JOIN GLibrary ON Games.LibraryID = GLibrary.LibraryID";


            using SqlCommand cmd = new(sql, connection);
            using SqlDataReader reader = cmd.ExecuteReader();
            
            //gets from database with the reader the reader will continue til no more data can be read
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

                //puts it in combind and adds it 
                Combind combinds = new(ID,Name,Description,Hours,FKey,FID,Epic,Steam,Other);
                
                combind.Add(combinds);
            }
            //you cant make me explain again just go to line 66 trust it wont leave room for questions
            connection.Close();
            //returns data
            return combind;
        }
        //----------------gets the games----------------//
        //----------------Login related database accesse-------------//
        public bool Logintest(string Password, string Username, string seclevel, string APassword)
        {
            using SqlConnection sqlConnection = new(connectionstring);
            sqlConnection.Open();

            string SQL = "SELECT UserName, UserPassWord, AdminPassWord, ProfileRank FROM UsersAndAdmins WHERE UserName = @UserName";

            using SqlCommand cmd = new(SQL, sqlConnection);
            cmd.Parameters.AddWithValue("@UserName", Username);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string username = reader["UserName"].ToString();
                string UserPassword = reader["UserPassWord"].ToString();
                string AdminPassword = reader["AdminPassWord"].ToString();
                string UserRank = reader["ProfileRank"].ToString();
                if (Username == username && Password == UserPassword && seclevel == "User")
                {
                    return true;
                }
                else if (Username == username && Password != UserPassword)
                {
                    MessageBox.Show("Password is Wrong");
                    return false;
                }

                if (Username == username && APassword == AdminPassword && Password == UserPassword && seclevel == "Admin" && UserRank == "Admin")
                {
                    return true;
                }
                else if (Username == username && APassword != AdminPassword || Password != UserPassword)
                {
                    MessageBox.Show("Password is Wrong");
                    return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("UserName is Wrong");
                return false;
            }
        }


        public void AddUser(User user)
        {
            using SqlConnection sqlConnection = new(connectionstring);
            sqlConnection.Open();

            string SQL = "INSERT INTO UsersAndAdmins (UserName,UserPassWord, AdminPassWord, ProfileRank)" +
                         "VALUES(@UserName,@UserPassWord, @AdminPassWord, @ProfileRank)" +
                         "SELECT SCOPE_IDENTITY()";

            using SqlCommand cmd = new(SQL, sqlConnection);
            cmd.Parameters.AddWithValue("@UserName", user.Name);
            cmd.Parameters.AddWithValue("@UserPassWord", user.Password);
            cmd.Parameters.AddWithValue("@AdminPassWord", user.APassword);
            cmd.Parameters.AddWithValue("@ProfileRank", user.UserRank);

            int Id = Convert.ToInt32(cmd.ExecuteScalar());
            user.ID = Id;

            sqlConnection.Close();
        }
        //----------------Login related database accesse-------------//
    }
}











//why are you still here there is nothing more go home go to sleep.