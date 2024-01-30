﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Library_For_Games
{
    /// <summary>
    /// Interaction logic for Add_to_library.xaml
    /// </summary>
    public partial class Add_to_library : Window
    {
        public Game_S game;
        public Library Library;
        public Database database = new();
        public Add_to_library(int Edit,int ID)
        {
            InitializeComponent();

            if (Edit > 0) 
            {
                database.GetUsingID(game,Library,ID);
                int gID = game.ID;
                if (gID > 0)
                {
                    string gName = game.Name;
                    string gDescription = game.Description;
                    string gHours = game.Hours.ToString();
                    TB_Game_Name.Text = gName;
                    TB_DESCRIPTION.Text = gDescription;
                    TB_Hours_Played.Text = gHours;
                    TB_ID.Text = gID.ToString();
                }
                int lID = Library.ID;
                if (lID > 0)
                {
                    CHB_Epic.IsChecked = Library.Epic;
                    CHB_Steam.IsChecked = Library.Steam;
                    CHB_Other.IsChecked = Library.Other;
                }
            }
        }

        private void BTN_Close_without_Save_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BTN_Close_and_save_Click(object sender, RoutedEventArgs e)
        {
            bool steam = (bool)CHB_Steam.IsChecked;
            bool epic = (bool)CHB_Epic.IsChecked;
            bool other = (bool)CHB_Other.IsChecked;

            string Gamename = TB_Game_Name.Text;
            string Gamedescrip = TB_DESCRIPTION.Text;
            int Gamehours = int.Parse(TB_Hours_Played.Text);
            
            if (int.TryParse(TB_ID.Text,out int GameID))
            {
                _ = new Library(GameID, epic, steam, other);
                _ = new Game_S(GameID, Gamename, Gamedescrip, Gamehours, GameID);

                MessageBox.Show("EDIT SAVED");
            }
            else if(GameID <= 0)
            {
                int FkeyID = 0;

                Library library = new(FkeyID, epic, steam, other);
                database.LibraryADD(library);

                Game_S games = new(GameID, Gamename, Gamedescrip, Gamehours, FkeyID);
                database.GameAddlist(games);
                MessageBox.Show("GAME ADDED");
            }
            Close();
        }
    }
}