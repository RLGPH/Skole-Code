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
        public Game_S game;
        public Library Library;
        public Database database = new();
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Add_to_library(int Edit,int ID,Game_S game,Library library)
        {
            InitializeComponent();
            //if its the edit button then edit will be 1 instead of 0
            if (Edit > 0) 
            {
                int gID = ID;
                if (gID > 0)
                {
                    //gives all game data to the textboxes and show ID in a read only textbox
                    string gName = game.Name;
                    string gDescription = game.Description;
                    string gHours = game.Hours.ToString();
                    TB_Game_Name.Text = gName;
                    TB_DESCRIPTION.Text = gDescription;
                    TB_Hours_Played.Text = gHours;
                    TB_ID.Text = null;
                    TB_ID.Text = gID.ToString();
                }
                int lID = ID;
                if (lID > 0)
                {
                    //checks whats true and gives that a checkmark
                    if (library.Epic == true)
                    {
                        CHB_Epic.IsChecked = library.Epic;
                    }
                    if (library.Steam == true)
                    {
                        CHB_Steam.IsChecked = library.Steam;
                    }
                    if (library.Other == true)
                    {
                        CHB_Other.IsChecked = library.Other;
                    }
                }
            }
        }

        private void BTN_Close_without_Save_Click(object sender, RoutedEventArgs e)
        {
            //it closes the window but does it also close you chance to fix your life?
            Close();
        }

        private void BTN_Close_and_save_Click(object sender, RoutedEventArgs e)
        {
            //gets the data
#pragma warning disable CS8629 // Nullable value type may be null.
            bool steam = (bool)CHB_Steam.IsChecked;

            bool epic = (bool)CHB_Epic.IsChecked;
            bool other = (bool)CHB_Other.IsChecked;

            string Gamename = TB_Game_Name.Text;
            string Gamedescrip = TB_DESCRIPTION.Text;
            
            //checks if there is an ID
            if (int.TryParse(TB_ID.Text,out int GameID))
            {
                //checks if hours can be converted to int
                if (int.TryParse(TB_Hours_Played.Text, out int Gamehours))
                {
                    Library library = new(GameID, epic, steam, other);
                    Game_S game = new(GameID, Gamename, Gamedescrip, Gamehours, GameID);
                    //sends data to the edit method in database class
                    database.Editobjectsandopdates(library, game);

                    //tells you edit saved and then give true to the previous page
                    MessageBox.Show("EDIT SAVED");
                    DialogResult = true;
                    //it does what its name states close aka close the window  
                    Close();
                }
                else
                {
                    MessageBox.Show("please type a valid number what you typed:", Gamehours.ToString());
                }
            }
            //if it didnt hold an ID value higher then 0 it will go into adding said item instead
            else if(GameID <= 0)
            {
                if (int.TryParse(TB_Hours_Played.Text, out int Gamehours))
                {
                    int FkeyID = 0;
                    //sends data to the add functions so they can be added to database

                    Library library = new(FkeyID, epic, steam, other);

                    Game_S games = new(GameID, Gamename, Gamedescrip, Gamehours, FkeyID);
                    database.IfGameIsInDatabase(games, library);

                    MessageBox.Show("GAME ADDED/EDITED");

                    DialogResult = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("please type a valid number what you typed:" + Gamehours.ToString() + "either you have writen a letter or a word");
                }
            }
            //error message that really shouldnt ever appere unless you leave to much null
            else
            {
                MessageBox.Show("Something whent wrong with saving changes all we can say is check what data you have writen there shouldnt be an instance where this shoudl show");
            }
        }
    }
}