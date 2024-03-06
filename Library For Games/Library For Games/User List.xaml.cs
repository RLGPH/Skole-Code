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
        readonly Database database = new();
        public User_List()
        {
            InitializeComponent();
            List<User> list = database.GetUser();

            DTG_Users.ItemsSource = list;
            
        }

        private void BTN_ADD_Click(object sender, RoutedEventArgs e)
        {
            User user = new(0, "", "", "", "");
            AddAndEditUser addAndEditUser = new(0,user);
            bool? resaults = addAndEditUser.ShowDialog();
            if (resaults == true) 
            {
                List<User> list = database.GetUser();

                DTG_Users.ItemsSource = null;
                DTG_Users.ItemsSource = list;
            }
        }

        private void BTN_CLOSE_Click(object sender, RoutedEventArgs e)
        {
            string seclevel = "Admin";
            Main_Menu mainMenu = new(seclevel);
            mainMenu.Show();
            Close();
        }

        private void TB_Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<User> users = database.GetUser();
            string search = TB_Search.Text.ToLower();

            var resaults = users.Where(u => u.Name.ToLower().StartsWith(search));
            DTG_Users.ItemsSource = null;
            DTG_Users.ItemsSource = resaults;
            if(search == null || search == "")
            {
                DTG_Users.ItemsSource = null;
                DTG_Users.ItemsSource = users; 
            }
        }

        private void DTG_Users_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DTG_Users.ItemsSource != null)
            {
                //changes selected item to combind object instead
                User users = (User)DTG_Users.SelectedItem;

                //gets the ID and displays it in the text box
                int ID = users.ID;
                TB_ID_SELECT.Text = ID.ToString();
            }
        }

        private void BTN_EDIT_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(TB_ID_SELECT.Text,out int ID))
            {
                DTG_Users.SelectedItem = ID;
                
                User user = (User)DTG_Users.SelectedItem;

                AddAndEditUser addAndEditUser = new(1,user);
                bool? resaults = addAndEditUser.ShowDialog();
                if(resaults == true)
                {
                    List<User> list = database.GetUser();

                    DTG_Users.ItemsSource = null;
                    DTG_Users.ItemsSource = list;
                }
            }
        }

        private void BTN_REMOVE_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TB_ID_SELECT.Text, out int ID) && ID >= 1)
            {
                MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete ID {ID}?", "Delete Confirmation", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    database.DeleteUser(ID);
                    List<User> list = database.GetUser();

                    DTG_Users.ItemsSource = null;
                    DTG_Users.ItemsSource = list;
                }
            }
            else
            {
                MessageBox.Show("No valid ID has been chosen or no ID has been chosen");
            }
        }
    }
}