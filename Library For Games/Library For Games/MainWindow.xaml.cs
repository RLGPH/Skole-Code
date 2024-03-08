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
        readonly Database database = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_Login_Click(object sender, RoutedEventArgs e)
        {
            string APassword = "no";
            string seclevel = "User";
            string password = TB_Password.Text;
            string user = TB_User.Text;
            bool Pass = database.Login(password, user, APassword, seclevel);
            if(Pass == true)
            {
                Main_Menu mainMenu = new(seclevel);
                mainMenu.Show();
                Close();
            }
            if (Pass == false)
            {
                MessageBox.Show("Using the Admin login menu theres a \"Backdoor\" because security is not top priority when testing");
            }
        }

        private void BTN_Admin_Login_Click(object sender, RoutedEventArgs e)
        {
            Admin_Login admin = new();
            admin.Show();
            Close();
        }

        private void BTN_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
