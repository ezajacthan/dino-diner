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
    /// Interaction logic for SteakosaurusCustomizer.xaml
    /// </summary>
    public partial class SteakosaurusCustomizer : Page
    {
        private DinoDiner.Menu.SteakosaurusBurger steak;
        public SteakosaurusCustomizer(DinoDiner.Menu.SteakosaurusBurger b)
        {
            this.steak = b;
            InitializeComponent();
        }

        private void HoldBunClicked(object sender, RoutedEventArgs args)
        {
            steak.HoldBun();
        }

        private void HoldKetchupClicked(object sender, RoutedEventArgs args)
        {
            steak.HoldKetchup();
        }

        private void HoldMustardClicked(object sender, RoutedEventArgs args)
        {
            steak.HoldMustard();
        }

        private void HoldPickleClicked(object sender, RoutedEventArgs args)
        {
            steak.HoldPickle();
        }

        private void DoneClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void BackClicked(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack) NavigationService.GoBack();
            else NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
