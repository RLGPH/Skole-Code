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
    /// Interaction logic for AddAndEditUser.xaml
    /// </summary>
    public partial class AddAndEditUser : Window
    {
        Database database;
        public AddAndEditUser()
        {
            InitializeComponent();
            database = new();
        }

        private void BTN_Save_ADD_Click(object sender, RoutedEventArgs e)
        {
            bool AdminOrUser = (bool)CHB_ADMIN.IsChecked;
            if (AdminOrUser == true)
            {
                int ID = 1;
                string User = TB_User.Text;
                string password = TB_Password.Text;
                string AdminPass = TB_APassword.Text;
                string Rank = "Admin";
                User user = new(ID, User, password, AdminPass,Rank);
                database.AddUser(user);
                Close();
            }
            else
            {
                int ID = 1;
                string User = TB_User.Text;
                string password = TB_Password.Text;
                string AdminPass = TB_APassword.Text;
                string Rank = "User";
                User user = new(ID, User, password, AdminPass,Rank);
                database.AddUser(user);
                Close();
            }
        }

        private void BTN_CLOSE_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
