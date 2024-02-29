using System;
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
        private string userRank;
        public Main_Menu(String rank)
        {
            InitializeComponent();
            userRank = rank;
            if (rank == "User")
            {
                int row = Grid.GetRow(SP_BTN_Users);
                int column = Grid.GetColumn(SP_BTN_Users);

                Grid.SetRow(SP_BTN_Logout, row);
                Grid.SetColumn(SP_BTN_Logout, column);

                BTN_Users.Visibility = Visibility.Collapsed;
            }
        }

        private void BTN_LIBRARY_Click(object sender, RoutedEventArgs e)
        {

            Most_Played_Save most_Played_Save = new(userRank);
            most_Played_Save.Show();
            Close();
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

        private void BTN_Logout_Click(object sender, RoutedEventArgs e)
        {
            Logout_Y_N logout = new Logout_Y_N();
            bool? resault = logout.ShowDialog();
            if (resault == true)
            {
                MainWindow main = new MainWindow();
                main.Show();
                Close();
            }
        }

        private void BTN_Users_Click(object sender, RoutedEventArgs e)
        {
            User_List userlist = new User_List();
            userlist.Show();
            Close();
        }
    }
}