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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library_For_Games
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void BTN_LIBRARY_Click(object sender, RoutedEventArgs e)
        {
            Most_Played_Save most_Played_Save = new();
            most_Played_Save.Show();
        }

        private void BTN_ADD_TO_Click(object sender, RoutedEventArgs e)
        {
            Library library = new(0, false, false, false);
            Game_S game = new(0,"null","null",0,0);
            Add_to_library add_to_library = new(0, 0, game, library);
            add_to_library.Show();
        }
    }
}
