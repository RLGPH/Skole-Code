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
    /// Interaction logic for Logout_Y_N.xaml
    /// </summary>
    public partial class Logout_Y_N : Window
    {
        public Logout_Y_N()
        {
            InitializeComponent();
        }

        private void BTN_Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BTN_Logout_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
