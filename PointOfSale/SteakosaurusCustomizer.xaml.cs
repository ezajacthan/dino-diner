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
    /// Interaction logic for SteakosaurusCustomizer.xaml
    /// </summary>
    public partial class SteakosaurusCustomizer : Page
    {
        private DinoDiner.Menu.SteakosaurusBurger steak;
        private CretaceousCombo combo;
        public SteakosaurusCustomizer(DinoDiner.Menu.SteakosaurusBurger b)
        {
            this.steak = b;
            InitializeComponent();
        }
        public SteakosaurusCustomizer(DinoDiner.Menu.CretaceousCombo combo)
        {
            this.combo = combo;
            InitializeComponent();
        }

        private void HoldBunClicked(object sender, RoutedEventArgs args)
        {
            steak?.HoldBun();
            if (this.combo != null)
            {
                if (this.combo.Entree is SteakosaurusBurger sb)
                {
                    sb.HoldBun();
                }
            }
        }

        private void HoldKetchupClicked(object sender, RoutedEventArgs args)
        {
            steak?.HoldKetchup();
            if (this.combo != null)
            {
                if (this.combo.Entree is SteakosaurusBurger sb)
                {
                    sb.HoldKetchup();
                }
            }
        }

        private void HoldMustardClicked(object sender, RoutedEventArgs args)
        {
            steak?.HoldMustard();
            if (this.combo != null)
            {
                if (this.combo.Entree is SteakosaurusBurger sb)
                {
                    sb.HoldMustard();
                }
            }
        }

        private void HoldPickleClicked(object sender, RoutedEventArgs args)
        {
            steak?.HoldPickle();
            if (this.combo != null)
            {
                if (this.combo.Entree is SteakosaurusBurger sb)
                {
                    sb.HoldPickle();
                }
            }
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
