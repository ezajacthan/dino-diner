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
    /// Interaction logic for PrehistoricPBJCustomizer.xaml
    /// </summary>
    public partial class PrehistoricPBJCustomizer : Page
    {
        private PrehistoricPBJ pbj;
        private CretaceousCombo combo;
        public PrehistoricPBJCustomizer(PrehistoricPBJ pbj)
        {
            this.pbj = pbj;
            InitializeComponent();
        }

        public PrehistoricPBJCustomizer(CretaceousCombo combo)
        {
            this.combo = combo;
            InitializeComponent();
        }

        private void HoldPeanutButterClicked(object sender, RoutedEventArgs args)
        {
            pbj?.HoldPeanutButter();
            if (this.combo != null)
            {
                if (this.combo.Entree is PrehistoricPBJ pb)
                {
                    pb.HoldPeanutButter();
                }
            }
        }
        private void HoldJellyClicked(object sender, RoutedEventArgs args)
        {
            pbj?.HoldJelly();
            if (this.combo != null)
            {
                if (this.combo.Entree is PrehistoricPBJ pb)
                {
                    pb.HoldJelly();
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
