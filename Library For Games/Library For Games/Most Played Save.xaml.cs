using System;
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
            Add_to_library add_to_library = new(0);
            add_to_library.Show();
        }

        private void BTN_EDIT_Click(object sender, RoutedEventArgs e)
        {
            Add_to_library add_to_library = new(1);
            add_to_library.Show();
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