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
        readonly Database database;

#pragma warning disable IDE0052 // Remove unread private members
        private readonly int id;
#pragma warning restore IDE0052 // Remove unread private members
        public AddAndEditUser(int ID, User user)
        {
            InitializeComponent();
            database = new();

            id = ID;
            if(ID == 1) 
            {
                TB_User.Text = user.Name;
                TB_Password.Text = user.Password;

                string URank = user.UserRank;
                if (URank == "Admin")
                {
                    CHB_ADMIN.IsChecked = true;
                    TB_APassword.Text = user.APassword;
                }
                else
                {
                    SP_TB_AdminPassWord.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                SP_TB_AdminPassWord.Visibility = Visibility.Collapsed;
            }
            
        }

        private void BTN_Save_ADD_Click(object sender, RoutedEventArgs e)
        {
#pragma warning disable CS8629 // Nullable value type may be null.
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

                DialogResult = true;
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

                DialogResult = true;
                Close();
            }
        }

        private void BTN_CLOSE_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CHB_ADMIN_Click(object sender, RoutedEventArgs e)
        {
            bool AdminYesNo = (bool)CHB_ADMIN.IsChecked;
            if (AdminYesNo == true)
            {
                SP_TB_AdminPassWord.Visibility = Visibility.Visible;
                TB_APassword.Text = null;
            }
            else
            {
                SP_TB_AdminPassWord.Visibility = Visibility.Collapsed;
                TB_APassword.Text = null;
            }
        }
    }
}
