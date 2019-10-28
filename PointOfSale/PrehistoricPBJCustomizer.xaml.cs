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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PrehistoricPBJCustomizer.xaml
    /// </summary>
    public partial class PrehistoricPBJCustomizer : Page
    {
        private PrehistoricPBJ pbj;
        public PrehistoricPBJCustomizer(PrehistoricPBJ pbj)
        {
            this.pbj = pbj;
            InitializeComponent();
        }

        private void HoldPeanutButterClicked(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
        }
        private void HoldJellyClicked(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }
        private void DoneClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }


    }
}
