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
    /// Interaction logic for ComboSideCustomization.xaml
    /// </summary>
    public partial class ComboSideCustomization : Page
    {
        private CretaceousCombo combo;
        public ComboSideCustomization(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            SelectSide(new Fryceritops());
        }

        public void AddMacNCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        public void AddMezzSticks(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
        }

        public void AddTots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
        }

        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                this.combo.Side = side;
            }
        }

        public void SmallClicked(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        public void MediumClicked(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        public void LargeClicked(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if(DataContext is Order order)
            {
                this.combo.Side.Size = size;
            }
        }

        private void DoneClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo(combo));
        }
    }
}
