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
    /// Interaction logic for VelociwrapCustomizer.xaml
    /// </summary>
    public partial class VelociwrapCustomizer : Page
    {
        private DinoDiner.Menu.Entrees.VelociWrap wrap;
        public VelociwrapCustomizer(DinoDiner.Menu.Entrees.VelociWrap v)
        {
            this.wrap = v;
            InitializeComponent();
        }

        private void HoldCheeseClicked(object sender, RoutedEventArgs args)
        {
            wrap.HoldCheese();
        }

        private void HoldLettuceClicked(object sender, RoutedEventArgs args)
        {
            wrap.HoldLettuce();
        }

        private void HoldDressingClicked(object sender, RoutedEventArgs args)
        {
            wrap.HoldDressing();
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
