using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Most_Played_Save.xaml
    /// </summary>
    public partial class Most_Played_Save : Window
    {
        readonly Database database = new();
        public Most_Played_Save()
        {
            InitializeComponent();
            //initiates the database and saves data that has been gotten from the database
            List<Combind> combinds = database.GetAndCombind();

            //adds said data to datagrid
            DTG_Games.ItemsSource = combinds;
        }

        private void BTN_CLOSE_Click(object sender, RoutedEventArgs e)
        {
            //just close nothing else totaly wont
            //show you eldricth horro images
            Close();
        }

        private void BTN_ADD_Click(object sender, RoutedEventArgs e)
        {
            //dumby info to open the ADD but not Edit
            Library library = new(0, false, false, false);
            Game_S game = new(0, "null", "null", 0, 0);

            //opens window with dumby info
            Add_to_library add_to_library = new(0, 0, game, library);
            add_to_library.Show();
        }

        private void BTN_EDIT_Click(object sender, RoutedEventArgs e)
        {
            //checks if the item in the text can be converted to INT
            if (int.TryParse(TB_ID_SELECT.Text,out int ID))
            {
                //selects item using ID
                DTG_Games.SelectedItem = ID;

                //turns datagrid selected item into combind class object
                Combind combind = (Combind)DTG_Games.SelectedItem;

                //turns relavent data from combinds into Game_S class
                int id = combind.MasterID;
                string name = combind.Name;
                string descrip = combind.Description;
                int Hours = combind.Hours;
                int fKey = combind.Fkey;
                Game_S game = new(id,name,descrip,Hours,fKey);

                //turns relavent data from combinds into Library class
                int libraryID = combind.LibraryID;
                bool epic = combind.Epic;
                bool steam = combind.Steam;
                bool other = combind.Other;
                Library library = new(libraryID, epic, steam, other);

                //gives the relevant data to the next window
                Add_to_library add_to_library = new(1, ID, game, library);
                //gets resault from window 
                bool? resault = add_to_library.ShowDialog();
                if (resault == true)
                {
                    //if true then give updated data to database and reload datagrid
                    List<Combind> combinds = database.GetAndCombind();
                    DTG_Games.ItemsSource = null;
                    DTG_Games.ItemsSource = combinds;
                }
            }
            else
            {
                //If the ID cant select the thing then this shows
                MessageBox.Show("plese select Valid ID");
            }
        }

        private void DTG_Games_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //checks if itemsouce is or isnt null
            if (DTG_Games.ItemsSource != null)
            {
                //changes selected item to combind object instead
                Combind combind = (Combind)DTG_Games.SelectedItem;
                
                //gets the ID and displays it in the text box
                int ID = combind.MasterID;
                TB_ID_SELECT.Text = ID.ToString();
            }
        }

        private void TB_Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            //gets the combind list with search name
            List<Combind> combind = database.GetAndCombind();
            string searchText = TB_Search.Text.ToLower();

            //get where the .Name in the object starts with then some text from TB
            var results = combind.Where(c => c.Name.ToLower().StartsWith(searchText));
            DTG_Games.ItemsSource = null;
            DTG_Games.ItemsSource = results;
            //in case you remove everletter from the search function then returns to no filter/search
            if(string.IsNullOrWhiteSpace(searchText))
            {
                var args = new SelectionChangedEventArgs(e.RoutedEvent, new List<object>(), new List<object>());

                CBB_Filter_SelectionChanged(sender, args);
            }
        }

        private void CBB_Filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
#pragma warning disable CS8604 // Possible null reference argument.
            var tag = CBB_Filter.SelectedItem != null ? int.Parse(((ComboBoxItem)CBB_Filter.SelectedItem).Tag.ToString()) : 0;
#pragma warning restore CS8604 // Possible null reference argument.

            List<Combind> combinds = database.GetAndCombind();
            IEnumerable<Combind>? filterList = null;


            //instead of search then filter from fx A-Z OR Z-A etc
            switch (tag)
            {
                case 0:
                    filterList = combinds;
                    break;
                case 1:
                    filterList = combinds.Where(c => c.Steam);
                    break;
                case 2:
                    filterList = combinds.Where(c => c.Epic);
                    break;
                case 3:
                    filterList = combinds.Where(c => c.Other);
                    break;
                case 4:
                    filterList = combinds.OrderByDescending(c => c.Hours);
                    break;
                case 5:
                    filterList = combinds.OrderBy(c => c.Hours);
                    break;
                case 6:
                    filterList = combinds.OrderBy(c => c.Name);
                    break;
                case 7:
                    filterList = combinds.OrderByDescending(c => c.Name);
                    break;
            }

            DTG_Games.ItemsSource = null;
            DTG_Games.ItemsSource = filterList;
        }
    }
    
    public class Combind
    {
        public int MasterID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hours {  get; set; }
        public int Fkey { get; set; }
        public int LibraryID { get; set; }
        public bool Epic {  get; set; }
        public bool Steam {  get; set; }
        public bool Other { get; set; }
        public Combind(int masterID, string name, string description, int hours, int fkey, int libraryID, bool epic, bool steam, bool other) 
        {
            MasterID = masterID;
            Name = name;
            Description = description;
            Hours = hours;
            Fkey = fkey;
            LibraryID = libraryID;
            Epic = epic;
            Steam = steam;
            Other = other;
        }
    }
}