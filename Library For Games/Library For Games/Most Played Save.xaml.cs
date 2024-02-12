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
            List<Combind> combinds = database.GetAndCombind();

            DTG_Games.ItemsSource = combinds;
        }

        private void BTN_CLOSE_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BTN_ADD_Click(object sender, RoutedEventArgs e)
        {
            Library library = new(0, false, false, false);
            Game_S game = new(0, "null", "null", 0, 0);
            Add_to_library add_to_library = new(0, 0, game, library);
            add_to_library.Show();
        }

        private void BTN_EDIT_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TB_ID_SELECT.Text,out int ID))
            {
                DTG_Games.SelectedItem = ID;

                Combind combind = (Combind)DTG_Games.SelectedItem;

                int id = combind.MasterID;
                string name = combind.Name;
                string descrip = combind.Description;
                int Hours = combind.Hours;
                int fKey = combind.Fkey;
                Game_S game = new(id,name,descrip,Hours,fKey);

                int libraryID = combind.LibraryID;
                bool epic = combind.Epic;
                bool steam = combind.Steam;
                bool other = combind.Other;
                Library library = new(libraryID,epic,steam,other);

                Add_to_library add_to_library = new(1, ID, game, library);
                bool? resault = add_to_library.ShowDialog();
                if (resault == true)
                {
                    List<Combind> combinds = database.GetAndCombind();
                    DTG_Games.ItemsSource = null;
                    DTG_Games.ItemsSource = combinds;
                }
            }
            else
            {
                MessageBox.Show("plese select ID");
            }
        }

        private void DTG_Games_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DTG_Games.ItemsSource != null)
            {
                Combind combind = (Combind)DTG_Games.SelectedItem;
                
                int ID = combind.MasterID;
                TB_ID_SELECT.Text = ID.ToString();
                
            }
        }

        private void TB_Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Combind> combind = database.GetAndCombind();
            string searchText = TB_Search.Text.ToLower();
            var results = combind.Where(c => c.Name.ToLower().StartsWith(searchText));
            DTG_Games.ItemsSource = null;
            DTG_Games.ItemsSource = results;
            if(string.IsNullOrWhiteSpace(searchText))
            {
                var args = new SelectionChangedEventArgs(e.RoutedEvent, new List<object>(), new List<object>());

                CBB_Filter_SelectionChanged(sender, args);
            }
        }

        private void CBB_Filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var tag = CBB_Filter.SelectedItem != null ? int.Parse(((ComboBoxItem)CBB_Filter.SelectedItem).Tag.ToString()) : 0;

            List<Combind> combinds = database.GetAndCombind();
            IEnumerable<Combind> filterList = null;

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