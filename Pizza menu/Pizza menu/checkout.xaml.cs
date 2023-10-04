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

namespace Pizza_menu
{
    /// <summary>
    /// Interaction logic for checkout.xaml
    /// </summary>
    public partial class Checkout : Window
    {
        //gets the cartitems aka what you are buying
        public ObservableCollection<CartItem> Cart { get; set; }
        //gets the cartitems aka what you are buying

        public Checkout(ObservableCollection<CartItem> cart, double totalPrice)//get both the cartitems and the price of whats in the cart
        {
            InitializeComponent();
            Cart = cart;

            //shows cartitems in the data grid
            dtg_BuyingList_Buy.ItemsSource = Cart;

            //shows what ´the total price is and what currency its in C2 is a way to format numbers in to a currency
            tb_PriceCheckout.Text = totalPrice.ToString("C2");
        }

        //just closes the window without removeing whats in the cart and the price
        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            //closes the window
            Close();
        }

        //used to say you are "buying" the items and then resets your cart after 
        private void btn_CheckoutBuy_Click(object sender, RoutedEventArgs e)
        {
            //clears the list called cart which refers to cartitem
            Cart.Clear();

            //closes the window
            Close();
        }

        
    }
}
