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
    /// Interaction logic for BrontowurstCustomizer.xaml
    /// </summary>
    public partial class BrontowurstCustomizer : Page
    {
        private DinoDiner.Menu.Brontowurst bronto;
        private DinoDiner.Menu.CretaceousCombo combo;
        public BrontowurstCustomizer(Brontowurst b)
        {
            this.bronto = b;
            InitializeComponent();
        }

        public BrontowurstCustomizer(CretaceousCombo c)
        {
            this.combo = c;
            InitializeComponent();
        }

        private void HoldPeppersClicked(object sender, RoutedEventArgs args)
        {
            bronto?.HoldPeppers();
            if (this.combo != null)
            {
                if (this.combo.Entree is Brontowurst wurst)
                {
                    wurst.HoldPeppers();
                }
            }
        }

        private void HoldOnionClicked(object sender, RoutedEventArgs args)
        {
            bronto?.HoldOnion();
            if(this.combo != null)
            {
                if (this.combo.Entree is Brontowurst wurst)
                {
                    wurst.HoldOnion();
                }
            }
        }

        private void HoldBunClicked(object sender, RoutedEventArgs args)
        {
            bronto?.HoldBun();
            if (this.combo != null)
            {
                if (this.combo.Entree is Brontowurst wurst)
                {
                    wurst.HoldBun();
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
