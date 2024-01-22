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
        public Database _database;
        public ObservableCollection<Game_S> games;
        public Most_Played_Save()
        {
            InitializeComponent();

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
}
