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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public Drink Drink { get; set; }

        public DrinkSelection()
        {
            InitializeComponent();
        }

        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.Drink = drink;
        }

        private void SelectDrink(Drink d)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(d);
                this.Drink = d;
            }
        }

        private void WaterClicked(object sender, RoutedEventArgs args)
        {
            IceButton.Content = "Hold Ice";
            IceButton.IsEnabled = true;
            LemonButton.IsEnabled = true;
            LemonButton.Content = "Add Lemon";
            SpecialtyButton.Content = "";
            SpecialtyButton.IsEnabled = false;
            SelectDrink(new Water());
        }

        private void JavaClicked(object sender, RoutedEventArgs args)
        {
            IceButton.Content = "Add Ice";
            IceButton.IsEnabled = true;
            LemonButton.Content = "Room for Cream";
            LemonButton.IsEnabled = true;
            SpecialtyButton.Content = "Decaf";
            SpecialtyButton.IsEnabled = true;
            SelectDrink(new JurrasicJava());
        }

        private void TeaClicked(object sender, RoutedEventArgs args)
        {
            IceButton.Content = "";
            IceButton.IsEnabled = false;
            LemonButton.IsEnabled = true;
            LemonButton.Content = "Lemon";
            SpecialtyButton.Content = "Sweet";
            SpecialtyButton.IsEnabled = true;
            SelectDrink(new Tyrannotea());
        }

        private void SodaClicked(object sender, RoutedEventArgs args)
        {
            IceButton.Content = "Hold Ice";
            IceButton.IsEnabled = true;
            LemonButton.IsEnabled = false;
            LemonButton.Content = "";
            SpecialtyButton.Content = "Flavor";
            SpecialtyButton.IsEnabled = true;
            SelectDrink(new Sodasaurus());
        }
        
        private void SpecialtyButtonClicked(object sender, RoutedEventArgs args)
        {
            if((string)SpecialtyButton.Content == "Flavor")
            {
                NavigationService.Navigate(new FlavorSelection());
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (this.Drink != null) this.Drink.Size = size;
        }

        private void SmallClicked(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }
        private void MedClicked(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }
        private void LargeClicked(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }
    }
}
