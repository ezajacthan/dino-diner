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
    /// Interaction logic for VelociwrapCustomizer.xaml
    /// </summary>
    public partial class VelociwrapCustomizer : Page
    {
        private DinoDiner.Menu.VelociWrap wrap;
        private CretaceousCombo combo;
        public VelociwrapCustomizer(DinoDiner.Menu.VelociWrap v)
        {
            this.wrap = v;
            InitializeComponent();
        }
        public VelociwrapCustomizer(DinoDiner.Menu.CretaceousCombo combo)
        {
            this.combo = combo;
            InitializeComponent();
        }


        private void HoldCheeseClicked(object sender, RoutedEventArgs args)
        {
            wrap?.HoldCheese();
            if (this.combo != null)
            {
                if (this.combo.Entree is VelociWrap v)
                {
                    v.HoldCheese();
                }
            }
        }

        private void HoldLettuceClicked(object sender, RoutedEventArgs args)
        {
            wrap?.HoldLettuce();
            if (this.combo != null)
            {
                if (this.combo.Entree is VelociWrap v)
                {
                    v.HoldLettuce();
                }
            }
        }

        private void HoldDressingClicked(object sender, RoutedEventArgs args)
        {
            wrap?.HoldDressing();
            if (this.combo != null)
            {
                if (this.combo.Entree is VelociWrap v)
                {
                    v.HoldDressing();
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
