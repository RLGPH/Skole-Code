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
    /// Interaction logic for Add_to_library.xaml
    /// </summary>
    public partial class Add_to_library : Window
    {
        public Database database = new();
        public Add_to_library()
        {
            InitializeComponent();

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
                Library library = new(GameID, epic, steam, other);

                Game_S game = new(GameID, Gamename, Gamedescrip, Gamehours, GameID);

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
