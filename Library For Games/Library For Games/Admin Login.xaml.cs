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
    /// Interaction logic for Admin_Login.xaml
    /// </summary>
    public partial class Admin_Login : Window
    {
        Database database;
        public Admin_Login()
        {
            InitializeComponent();
            database = new();
        }

        private void BTN_Admin_Login_Click(object sender, RoutedEventArgs e)
        {
            string Username = TB_Admin_User.Text;
            string Password1 = TB_Admin_Password_1.Text;
            string Password2 = TB_Password_2.Text;
            string seclevel = "Admin";
            bool Pass = database.Logintest(Password1, Username, Password2, seclevel);
            if (Pass)
            {
                Main_Menu mainMenu = new Main_Menu(seclevel);
                mainMenu.Show();
                Close();
            }
        }

        private void BTN_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
