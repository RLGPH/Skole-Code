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
    /// Interaction logic for User_List.xaml
    /// </summary>
    public partial class User_List : Window
    {
        public User_List()
        {
            InitializeComponent();
            List<User> list = new();
        }

        private void BTN_ADD_Click(object sender, RoutedEventArgs e)
        {
            AddAndEditUser addAndEditUser = new();
            addAndEditUser.Show();
        }

        private void BTN_CLOSE_Click(object sender, RoutedEventArgs e)
        {
            string seclevel = "Admin";
            Main_Menu mainMenu = new(seclevel);
            mainMenu.Show();
            Close();
        }
    }
}
