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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        public Drink Drink { get; set; }
        public FlavorSelection(Drink d)
        {
            InitializeComponent();
            this.Drink = d;
        }
        private void DoneClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        private void CherryClicked(object sender, RoutedEventArgs args)
        {
            if(this.Drink is Sodasaurus soda)
            {
                if (this.Drink != null) soda.Flavor = SodasaurusFlavor.Cherry;
            }
            
        }
        private void ChocolateClicked(object sender, RoutedEventArgs args)
        {
            if (this.Drink is Sodasaurus soda)
            {
                if (this.Drink != null) soda.Flavor = SodasaurusFlavor.Chocolate;
            }
                
        }
        private void ColaClicked(object sender, RoutedEventArgs args)
        {
            if (this.Drink is Sodasaurus soda)
            {
                if (this.Drink != null) soda.Flavor = SodasaurusFlavor.Cola;
            }
                
        }
        private void LimeClicked(object sender, RoutedEventArgs args)
        {
            if (this.Drink is Sodasaurus soda)
            {
                if (this.Drink != null) soda.Flavor = SodasaurusFlavor.Lime;
            }
                
        }
        private void OrangeClicked(object sender, RoutedEventArgs args)
        {
            if (this.Drink is Sodasaurus soda)
            {
                if (this.Drink != null) soda.Flavor = SodasaurusFlavor.Orange;
            }
                
        }
        private void RootClicked(object sender, RoutedEventArgs args)
        {
            if (this.Drink is Sodasaurus soda)
            {
                if (this.Drink != null) soda.Flavor = SodasaurusFlavor.RootBeer;
            }
                
        }
        private void VanillaClicked(object sender, RoutedEventArgs args)
        {
            if (this.Drink is Sodasaurus soda)
            {
                if (this.Drink != null) soda.Flavor = SodasaurusFlavor.Vanilla;
            }
                
        }
    }

}
