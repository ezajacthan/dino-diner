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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        private void BrontowurstClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(new Brontowurst())));
        }

        private void DinoClicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(new DinoNuggets())));
        }

        private void PBJClicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(new PrehistoricPBJ())));
        }

        private void WingsClicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(new PterodactylWings())));
        }

        private void SteakClicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(new SteakosaurusBurger())));
        }
        private void TRexClicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(new TRexKingBurger())));
        }

        private void WrapClicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(new VelociWrap())));
        }
    }
}
