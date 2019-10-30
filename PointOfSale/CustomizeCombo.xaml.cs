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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        private CretaceousCombo combo;
        public CustomizeCombo(CretaceousCombo c)
        {
            combo = c;
            InitializeComponent();
        }

        private void DrinkClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }

        private void SideClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        private void SmallClicked(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Small;
        }

        private void MedClicked(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Medium;
        }

        private void LargeClicked(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Large;
        }
    }
}
