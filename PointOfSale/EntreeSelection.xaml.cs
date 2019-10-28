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
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        //backing property
        public Entree Entree { get; set; }

        public EntreeSelection()
        {
            InitializeComponent();
        }
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.Entree = entree;
        }
        
        private void SelectEntree(Entree e)
        {
            if (DataContext is Order order)
            {
                order.Add(e);
                this.Entree = e;
            }
        }

        private void BrontowurstClicked(object sender, RoutedEventArgs e)
        {
            SelectEntree(new Brontowurst());
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void DinoNugsClicked(object sender, RoutedEventArgs e)
        {
            SelectEntree(new DinoNuggets());
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void PBJClicked(object sender, RoutedEventArgs e)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            SelectEntree(pbj);
            NavigationService.Navigate(new PrehistoricPBJCustomizer(pbj));
        }

        private void WingsClicked(object sender, RoutedEventArgs e)
        {
            SelectEntree(new PterodactylWings());
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void SteakosaurusClicked(object sender, RoutedEventArgs e)
        {
            SelectEntree(new SteakosaurusBurger());
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void TRexClicked(object sender, RoutedEventArgs e)
        {
            SelectEntree(new TRexKingBurger());
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void VelociwrapClicked(object sender, RoutedEventArgs e)
        {
            SelectEntree(new VelociWrap());
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
