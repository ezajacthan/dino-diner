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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }
        private void WaterClicked(object sender, RoutedEventArgs args)
        {
            IceButton.Content = "Hold Ice";
            LemonButton.IsEnabled = true;
            LemonButton.Content = "Lemon";
            SpecialtyButton.Content = "";
            SpecialtyButton.IsEnabled = false;
        }

        private void JavaClicked(object sender, RoutedEventArgs args)
        {
            IceButton.Content = "AddIce";
            IceButton.IsEnabled = true;
            LemonButton.Content = "Sweet";
            LemonButton.IsEnabled = true;
            SpecialtyButton.Content = "Decaf";
            SpecialtyButton.IsEnabled = true;
        }

        private void TeaClicked(object sender, RoutedEventArgs args)
        {
            IceButton.Content = "";
            IceButton.IsEnabled = false;
            LemonButton.IsEnabled = true;
            LemonButton.Content = "Lemon";
            SpecialtyButton.Content = "Sweet";
            SpecialtyButton.IsEnabled = true;
        }

        private void SodaClicked(object sender, RoutedEventArgs args)
        {
            IceButton.Content = "Hold Ice";
            IceButton.IsEnabled = true;
            LemonButton.IsEnabled = false;
            LemonButton.Content = "";
            SpecialtyButton.Content = "Flavor";
            SpecialtyButton.IsEnabled = true;
        }
    }
}
