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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboDrinkCustomization.xaml
    /// </summary>
    public partial class ComboDrinkCustomization : Page
    {
        private CretaceousCombo combo;
        public ComboDrinkCustomization(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        private void SelectDrink(Drink d)
        {
            if (DataContext is Order order)
            {
                this.combo.Drink = d;
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
            DoneButton.IsEnabled = true;
            SelectDrink(new Water());
        }

        private void JavaClicked(object sender, RoutedEventArgs args)
        {
            IceButton.Content = "Add Ice";
            IceButton.IsEnabled = true;
            LemonButton.Content = "Room For Cream";
            LemonButton.IsEnabled = true;
            SpecialtyButton.Content = "Decaf";
            DoneButton.IsEnabled = true;
            SpecialtyButton.IsEnabled = true;
            SelectDrink(new JurrasicJava());
        }

        private void TeaClicked(object sender, RoutedEventArgs args)
        {
            IceButton.Content = "";
            IceButton.IsEnabled = false;
            LemonButton.IsEnabled = true;
            LemonButton.Content = "Add Lemon";
            SpecialtyButton.Content = "Sweet";
            SpecialtyButton.IsEnabled = true;
            DoneButton.IsEnabled = true;
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
            DoneButton.IsEnabled = true;
            SelectDrink(new Sodasaurus());
        }

        private void SpecialtyButtonClicked(object sender, RoutedEventArgs args)
        {
            if ((string)SpecialtyButton.Content == "Flavor")
            {
                NavigationService.Navigate(new FlavorSelection(this.combo.Drink));
            }
            else if ((string)SpecialtyButton.Content == "Sweet")
            {
                if (this.combo.Drink is Tyrannotea tea)
                {
                    if (this.combo.Drink != null) tea.AddSugar();
                }
            }
            else if ((string)SpecialtyButton.Content == "Decaf")
            {
                if (this.combo.Drink is JurrasicJava java)
                {
                    if (this.combo.Drink != null) java.Decaf();
                }
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
             if (DataContext is Order order)
             {
               this.combo.Drink.Size = size;
             }
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

        private void DoneClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void LemonClicked(object sender, RoutedEventArgs args)
        {
            if ((string)LemonButton.Content == "Add Lemon")
            {
                if (this.combo.Drink is Tyrannotea tea)
                {
                    if (this.combo.Drink != null) tea.AddLemon();
                }
                if (this.combo.Drink is Water water)
                {
                    if (this.combo.Drink != null) water.AddLemon();
                }
            }
            else if ((string)LemonButton.Content == "Room For Cream")
            {
                if (this.combo.Drink is JurrasicJava java)
                {
                    if (this.combo.Drink != null) java.LeaveRoomForCream();
                }
            }
        }

        private void IceClicked(object sender, RoutedEventArgs args)
        {
            if ((string)IceButton.Content == "Hold Ice")
            {
                if (this.combo.Drink is Sodasaurus soda)
                {
                    if (this.combo.Drink != null) soda.HoldIce();
                }
                if (this.combo.Drink is Water water)
                {
                    if (this.combo.Drink != null) water.HoldIce();
                }
            }
            else if ((string)IceButton.Content == "Add Ice")
            {
                if (this.combo.Drink is JurrasicJava java)
                {
                    if (this.combo.Drink != null) java.AddIce();
                }
            }
        }
    }
}
