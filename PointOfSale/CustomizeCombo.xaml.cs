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
            NavigationService.Navigate(new ComboDrinkCustomization(combo));
        }

        private void SideClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSideCustomization(combo));
        }

        private void EntreeClicked(object sender, RoutedEventArgs args)
        {
           if(combo.Entree is Brontowurst b)
            {
                NavigationService.Navigate(new BrontowurstCustomizer(combo));
            }
            if (combo.Entree is DinoNuggets d)
            {
                NavigationService.Navigate(new DinoNuggetsCustomizer(combo));
            }
            if (combo.Entree is PrehistoricPBJ pbj)
            {
                NavigationService.Navigate(new PrehistoricPBJCustomizer(combo));
            }
            if (combo.Entree is SteakosaurusBurger s)
            {
                NavigationService.Navigate(new SteakosaurusCustomizer(combo));
            }
            if (combo.Entree is TRexKingBurger t)
            {
                NavigationService.Navigate(new TRexCustomizer(combo));
            }
            if (combo.Entree is VelociWrap v)
            {
                NavigationService.Navigate(new VelociwrapCustomizer(combo));
            }
            if (combo.Entree is PterodactylWings wings)
            {

            }
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
