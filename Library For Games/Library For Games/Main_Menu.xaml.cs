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
    /// Interaction logic for Main_Menu.xaml
    /// </summary>
    public partial class Main_Menu : Window
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void BTN_LIBRARY_Click(object sender, RoutedEventArgs e)
        {
            //opens the window use to show whats saved in SQL database
            Most_Played_Save most_Played_Save = new();
            most_Played_Save.Show();
        }

        private void BTN_ADD_TO_Click(object sender, RoutedEventArgs e)
        {
            //gives some dumby information to get past the dependinsie
            Library library = new(0, false, false, false);
            Game_S game = new(0, "null", "null", 0, 0);

            //opens window for add window
            Add_to_library add_to_library = new(0, 0, game, library);
            add_to_library.Show();
        }

        private void BTN_Steam_Sync_Click(object sender, RoutedEventArgs e)
        {
            //opens sync windows 
            SyncDataFromProfile syncDataFromProfile = new();
            syncDataFromProfile.Show();
        }
    }
}