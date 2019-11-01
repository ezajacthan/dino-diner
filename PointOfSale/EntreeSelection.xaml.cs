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
            Brontowurst bronto = new Brontowurst();
            SelectEntree(bronto);
            NavigationService.Navigate(new BrontowurstCustomizer(bronto));
        }

        private void DinoNugsClicked(object sender, RoutedEventArgs e)
        {
            DinoNuggets nugs = new DinoNuggets();
            SelectEntree(nugs);
            NavigationService.Navigate(new DinoNuggetsCustomizer(nugs));
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
            SteakosaurusBurger steak = new SteakosaurusBurger();
            SelectEntree(steak);
            NavigationService.Navigate(new SteakosaurusCustomizer(steak));
        }

        private void TRexClicked(object sender, RoutedEventArgs e)
        {
            TRexKingBurger rex = new TRexKingBurger();
            SelectEntree(rex);
            NavigationService.Navigate(new TRexCustomizer(rex));
        }

        private void VelociwrapClicked(object sender, RoutedEventArgs e)
        {
            VelociWrap wrap = new VelociWrap();
            SelectEntree(wrap);
            NavigationService.Navigate(new VelociwrapCustomizer(wrap));
        }

        private void DoneClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
