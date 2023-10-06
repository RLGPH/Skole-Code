using Microsoft.VisualBasic;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Pizza_menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<DrinkItem> Drinks = new ObservableCollection<DrinkItem>();

        ObservableCollection<ExtraItem> Extra = new ObservableCollection<ExtraItem>();
        
        public ObservableCollection<CartItem> Cart = new ObservableCollection<CartItem>();

        public List<ToppingsItem> availableToppings = new List<ToppingsItem>();

        ObservableCollection<PizzaItem> Pizza = new ObservableCollection<PizzaItem>();
        
        public MainWindow()
        {
            InitializeComponent();
            //toppings items
            availableToppings.Add(new ToppingsItem("mozzarella cheese", 6.49));
            availableToppings.Add(new ToppingsItem("tomato source", 6.49));
            availableToppings.Add(new ToppingsItem("Mushrooms 5-6", 7.49));
            availableToppings.Add(new ToppingsItem("Pepperoni 10-15", 8.99));
            availableToppings.Add(new ToppingsItem("1 Green Peppers", 7.49));
            availableToppings.Add(new ToppingsItem("Black Olives 5-10", 7.29));
            availableToppings.Add(new ToppingsItem("1/2 Onion", 8.99));
            availableToppings.Add(new ToppingsItem("Sausage 10-20 sliceses", 9.49));
            availableToppings.Add(new ToppingsItem("Bacon 20-30 pieces", 10.99));
            availableToppings.Add(new ToppingsItem("Pineapple 10-15 pieces", 6.79));
            availableToppings.Add(new ToppingsItem("Spinach 5-10 pieces", 7.49));
            //toppings items
            //pizza items
            Pizza.Add(new PizzaItem(0, "Cheese pizza", 75.99, "cheese on bread and source", new List<ToppingsItem> { availableToppings[0], availableToppings[1] }));
            Pizza.Add(new PizzaItem(1, "Pepperoni", 85.99, "Spicy pepperoni and mozzarella", new List<ToppingsItem> { availableToppings[1], availableToppings[2] })); 
            Pizza.Add(new PizzaItem(2, "Vegetarian", 80.99, "Assorted veggies and mozzarella", new List<ToppingsItem> { availableToppings[1], availableToppings[2] })); 
            Pizza.Add(new PizzaItem(3, "Hawaiian", 90.99, "Ham, pineapple, and mozzarella", new List<ToppingsItem> { availableToppings[1], availableToppings[2] })); 
            Pizza.Add(new PizzaItem(4, "Meat Lover's", 95.99, "Pepperoni, sausage, and bacon", new List<ToppingsItem> { availableToppings[1], availableToppings[2] })); 
            Pizza.Add(new PizzaItem(5, "BBQ Chicken", 90.99, "Grilled chicken and BBQ sauce", new List<ToppingsItem> { availableToppings[1], availableToppings[2] })); 
            Pizza.Add(new PizzaItem(6, "Mushroom Supreme", 85.99, "Mushrooms, olives, and mozzarella", new List<ToppingsItem> { availableToppings[1], availableToppings[2] })); 
            Pizza.Add(new PizzaItem(7, "Four Cheese", 80.99, "Mozzarella, cheddar, provolone, and feta", new List<ToppingsItem> { availableToppings[1], availableToppings[2] })); 
            Pizza.Add(new PizzaItem(8, "Spinach and Feta", 85.99, "Fresh spinach and creamy feta", new List<ToppingsItem> { availableToppings[1], availableToppings[2] })); 
            Pizza.Add(new PizzaItem(9, "Supreme Deluxe", 95.99, "Pepperoni, sausage, peppers, and onions", new List<ToppingsItem> { availableToppings[1], availableToppings[2] }));
            //pizza items
            //drinks items
            Drinks.Add(new DrinkItem(0, "Lemon Water 1L", 10.99));
            Drinks.Add(new DrinkItem(1, "Bepsi 1L", 14.99));
            Drinks.Add(new DrinkItem(2, "Cola 1L",16.99 ));
            Drinks.Add(new DrinkItem(3, "Iced Coffee 1L", 16.99));
            Drinks.Add(new DrinkItem(4, "Mango Smoothie 1L", 19.99));
            Drinks.Add(new DrinkItem(5, "Peach Iced Tea 1L", 17.99));
            Drinks.Add(new DrinkItem(6, "Strawberry Lemonade 1L", 18.99));
            Drinks.Add(new DrinkItem(7, "Grape Soda 1L", 15.99));
            Drinks.Add(new DrinkItem(8, "Pineapple Juice 1L", 18.99));
            Drinks.Add(new DrinkItem(9, "Blueberry Lemonade 1L", 17.99));
            //drinks items
            //extra items
            Extra.Add(new ExtraItem(0, "Bread sticks", 10.99));
            Extra.Add(new ExtraItem(1, "Fries Small", 15.99));
            Extra.Add(new ExtraItem(2, "Fries big", 20.99));
            Extra.Add(new ExtraItem(3, "Garlic Knots", 12.99));
            Extra.Add(new ExtraItem(4, "Mozzarella Sticks", 14.99));
            Extra.Add(new ExtraItem(5, "Pizza Rolls", 13.99));
            Extra.Add(new ExtraItem(6, "Caesar Salad", 18.99));
            Extra.Add(new ExtraItem(7, "Caprese Salad", 19.99));
            Extra.Add(new ExtraItem(8, "Buffalo Wings", 16.99));
            Extra.Add(new ExtraItem(9, "Antipasto Platter", 22.99));
            //extra items

            dtg_Menu.ItemsSource = Pizza;
            dtg_BuyingList_Buy.ItemsSource = Cart;
        }
        //combobox used to select which list should shown in the menu list
        private void cmb_Menu_Selection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           ComboBoxItem? selectedCategory = cmb_Menu_Selection.SelectedItem as ComboBoxItem; 

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (selectedCategory.Content.ToString() == "Drinks")
            {
                //used to call the list to the datagrid
                dtg_Menu.ItemsSource = Drinks;
            }
            else if (selectedCategory.Content.ToString() == "Extra")
            {
                dtg_Menu.ItemsSource = Extra;
            }
            else if (selectedCategory.Content.ToString() == "Pizza")
            {
                dtg_Menu.ItemsSource = Pizza;
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
        //takes you in to the buy menu
        private void btn_Menu_Buy_Click(object sender, RoutedEventArgs e)
        {
            //basicly this takes the total price for it self out of the list
            double totalPrice = Cart.Sum(item => item.Price);

            //this transfers the list and the price to the checkout window and opens the window
            Checkout checkout = new Checkout(Cart, totalPrice);
            checkout.ShowDialog();

            //recalculates the totalprice after the checkout window close
            CalculateTotalPrice();
        }

        private void btn_ADD_to_order_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = dtg_Menu.SelectedItem;
            
            if (selectedItem is DrinkItem drink)
            {    
                var cartItem = new CartItem(drink.Id, drink.Name, drink.Price, "Drink");

                Cart.Add(cartItem);
            }
            else if (selectedItem is ExtraItem extra)
            {    
                var cartItem = new CartItem(extra.Id, extra.Name, extra.Price, "Extra");
                Cart.Add(cartItem);
            }
            else if (selectedItem is PizzaItem pizza)
            {      
                var cartItem = new CartItem(pizza.Id, pizza.Name, pizza.Price, "Pizza");
                Cart.Add(cartItem);
            }
            CalculateTotalPrice(); 
        }
        private void CalculateTotalPrice()
        {
            TotalPrice = Cart.Sum(item => item.Price);
        }
        
        private void btn_Remove_From_Order_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_BuyingList_Buy.SelectedItem is CartItem selectedItem)
            {
                //used to remove and recalculate the price of everything in the totalprice price taken from Cartitem 
                Cart.Remove(selectedItem);
                CalculateTotalPrice();
            }
        }
        private double totalPrice;
        public double TotalPrice
        {
            get { return totalPrice; }
            set
            {
                //sets totalprice as a value
                totalPrice = value;

                //shows what ´the total price is and what currency its in C2 is a way to format numbers in to a currency
                tb_Price.Text = totalPrice.ToString("C2");
            }
        }

        public List<ToppingsItem>? selectedPizzaToppings { get; set; }

        //give the selected data from a data grid to CustomPizza window and the toppings list
        private void btn_Custom_Click(object sender, RoutedEventArgs e)
        {

            if (dtg_Menu.SelectedItem is PizzaItem selectedPizza)
            {
                // Retrieve the selected pizza's toppings
                selectedPizzaToppings = selectedPizza.Toppings;
                
                // Transfer data from the main window to the custom pizza window
                Custom_Pizza customPizzaWindow = new Custom_Pizza(availableToppings, selectedPizza, selectedPizzaToppings, Cart);
                customPizzaWindow.ShowDialog();
            }
            CalculateTotalPrice();
        }
    }

    public class DrinkItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public DrinkItem(int Id, string Name, double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }
    }

    public class ExtraItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public ExtraItem(int Id, string Name, double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }
    }
    public class ToppingsItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity {  get; set; }
        public ToppingsItem(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    }

    public class PizzaItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public List<ToppingsItem> Toppings { get; set; }

        public PizzaItem(int Id, string Name, double Price, string description, List<ToppingsItem> toppings)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            Description = description;
            Toppings = toppings;
        }
    }
    public class CartItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public CartItem(int Id, string Name, double Price, string description)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Description = description;
        }
    }
    public class SelectedTopping
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ToppingsItem Topping { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
    }
}