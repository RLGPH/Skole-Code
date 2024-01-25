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
        readonly Game_S Game_S;
        readonly Database database = new();
        public Most_Played_Save()
        {
            InitializeComponent();
            List<Game_S> games = database.GetGames();
            List<Library> libraries = database.GetLibrary();
            

            DTG_Games.ItemsSource = games;
        }

        private void BTN_CLOSE_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BTN_ADD_Click(object sender, RoutedEventArgs e)
        {
            Add_to_library add_to_library = new();
            add_to_library.Show();
        }
    }
    public class Combind
    {
        int MasterID {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hours {  get; set; }
        public bool epic {  get; set; }
        public bool steam {  get; set; }
        public bool other { get; set; }
    }
}