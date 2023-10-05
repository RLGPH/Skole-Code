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
    // <summary>
    // Interaction logic for Custom_Pizza.xaml
    // </summary>
    /*public class CombindeToppings
    {
        public ObservableCollection<SelectedTopping> SelectedToppings { get; set; }
        public CombindeToppings() 
        {
            var Combindetoppings = SelectedToppings + selectedPizzaToppings;
        }
    }*/    
    public partial class Custom_Pizza : Window
     {

        //used to get the pizza list and the selcted pizza
        public PizzaItem SelectedPizza { get; set; }
        public ObservableCollection<PizzaItem> SelectedPizzas { get; set; }
        //used to get the pizza list and the selcted pizza

        //used for selected toppings
        public ObservableCollection<SelectedTopping> SelectedToppings { get; set; }

        //used to add the custom pizza to the cartitems
        public ObservableCollection<CartItem> CartItems { get; set; }

        public List<ToppingsItem> SelectedPizzaToppings { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Custom_Pizza(List<ToppingsItem> availableToppings, PizzaItem selectedPizza, List<ToppingsItem> selectedPizzaToppings, ObservableCollection<CartItem> cartItems)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            SelectedPizza = selectedPizza;
            SelectedToppings = new ObservableCollection<SelectedTopping>();
            CartItems = cartItems;
            this.SelectedPizzaToppings = selectedPizzaToppings ?? availableToppings;

            foreach (var selectedTopping in selectedPizzaToppings)
            {
                SelectedToppings.Add(new SelectedTopping
                {
                    Topping = selectedTopping,
                    Quantity = 1,
                    TotalPrice = selectedTopping.Price
                });
            }

            //tells where everything has to be displayed
            dtg_Toppings.ItemsSource = availableToppings;
            tb_Selected_pizza.Text = selectedPizza.Name;
            dtg_PizzaWToppings.ItemsSource = SelectedToppings;
            

            //C2 will format the Pizzas price to if your computer is danish say DKK with a 2 decimal point
            //Meaning C2 means System currency and the 2 decimals
            tb_price_custom.Text = selectedPizza.Price.ToString("C2");
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_Toppings.SelectedItem is ToppingsItem selectedTopping)
            {
                // Check if the topping is already in the selected toppings collection
                var existingTopping = SelectedToppings.FirstOrDefault(t => t.Topping.Name == selectedTopping.Name);

                if (existingTopping != null)
                {
                    // If the topping exists, increment its quantity
                    existingTopping.Quantity++;

                    //calculates price base of the quantity and the pricer per toppings order
                    existingTopping.TotalPrice = existingTopping.Quantity * existingTopping.Topping.Price;
                }
                else
                {
                    var newTopping = new SelectedTopping
                    {
                        Topping = selectedTopping,
                        Quantity = 1,
                        TotalPrice = selectedTopping.Price
                    };
                    // If the topping does not exist, add it to the collection with a quantity of 1
                    SelectedToppings.Add(newTopping);
                }

                // Calculate the updated price by summing the prices of all selected toppings
                double updatedPrice = SelectedPizza.Price + SelectedToppings.Sum(t => t.Topping.Price * t.Quantity);

                // Update the TextBox with the updated price
                tb_price_custom.Text = updatedPrice.ToString("C2");
                dtg_PizzaWToppings.ItemsSource = null;
                dtg_PizzaWToppings.ItemsSource = SelectedToppings;
            }
        }

        private void btn_Remove_Topping_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_PizzaWToppings.SelectedItem is SelectedTopping selectedTopping)
            {
                // Check if the topping exists in the collection
                var existingTopping = SelectedToppings.FirstOrDefault(t => t.Topping.Name == selectedTopping.Topping.Name);

                if (existingTopping != null)
                {
                    // If the topping exists, decrement its quantity
                    existingTopping.Quantity--;

                    // If the quantity becomes zero, remove the topping from the collection
                    if (existingTopping.Quantity <= 0)
                    {
                        SelectedToppings.Remove(existingTopping);
                    }
                }
                // Calculate the updated price by summing the prices of all selected toppings
                double updatedPrice = SelectedPizza.Price + SelectedToppings.Sum(t => t.Topping.Price * t.Quantity);

                // Update the TextBox with the updated price
                tb_price_custom.Text = updatedPrice.ToString("C2");
                dtg_PizzaWToppings.ItemsSource = null;
                dtg_PizzaWToppings.ItemsSource = SelectedToppings;
            }
        }
        //go back without saveing
        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        //go back while saveing the data to cartitems
        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string description = $"Custom Pizza with {string.Join(", ", SelectedToppings.Select(t => $"{t.Quantity}x {t.Topping.Name}"))}";

            double customPizzaPrice = (SelectedPizza.Price + SelectedToppings.Sum(t => t.Topping.Price * t.Quantity));
            SelectedPizza.Name = tb_Selected_pizza.Text;  
            SelectedPizza.Toppings = SelectedToppings.Select(t => t.Topping).ToList();

            var customPizzaCartItem = new CartItem(SelectedPizza.Id, SelectedPizza.Name, customPizzaPrice, description);
            
            CartItems.Add(customPizzaCartItem);

            Close();
        }
    }
}