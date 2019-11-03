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
    /// Interaction logic for TRexCustomizer.xaml
    /// </summary>
    public partial class TRexCustomizer : Page
    {
        private DinoDiner.Menu.TRexKingBurger Trex;
        private CretaceousCombo combo;
        public TRexCustomizer(DinoDiner.Menu.TRexKingBurger t)
        {
            this.Trex = t;
            InitializeComponent();
        }
        public TRexCustomizer(DinoDiner.Menu.CretaceousCombo combo)
        {
            this.combo = combo;
            InitializeComponent();
        }

        private void HoldBunClicked(object sender, RoutedEventArgs args)
        {
            Trex?.HoldBun();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldBun();
                }
            }
        }

        private void HoldLettuceClicked(object sender, RoutedEventArgs args)
        {
            Trex?.HoldLettuce();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldLettuce();
                }
            }
        }

        private void HoldKetchupClicked(object sender, RoutedEventArgs args)
        {
            Trex?.HoldKetchup();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldKetchup();
                }
            }
        }

        private void HoldMayoClicked(object sender, RoutedEventArgs args)
        {
            Trex?.HoldMayo();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldMayo();
                }
            }
        }
        private void HoldMustardClicked(object sender, RoutedEventArgs args)
        {
            Trex?.HoldMustard();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldMustard();
                }
            }
        }

        private void HoldOnionClicked(object sender, RoutedEventArgs args)
        {
            Trex?.HoldOnion();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldOnion();
                }
            }
        }

        private void HoldPickleClicked(object sender, RoutedEventArgs args)
        {
            Trex?.HoldPickle();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldPickle();
                }
            }
        }

        private void HoldTomatoClicked(object sender, RoutedEventArgs args)
        {
            Trex?.HoldTomato();
            if (this.combo != null)
            {
                if (this.combo.Entree is TRexKingBurger tb)
                {
                    tb.HoldTomato();
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
