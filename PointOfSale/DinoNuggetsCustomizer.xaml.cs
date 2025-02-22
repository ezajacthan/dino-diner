﻿using System;
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
    /// Interaction logic for DinoNuggetsCustomizer.xaml
    /// </summary>
    public partial class DinoNuggetsCustomizer : Page
    {
        private DinoDiner.Menu.DinoNuggets nugs;
        private CretaceousCombo combo;
        public DinoNuggetsCustomizer(DinoDiner.Menu.DinoNuggets d)
        {
            this.nugs = d;
            InitializeComponent();
        }

        public DinoNuggetsCustomizer(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        private void AddNugClicked(object sender, RoutedEventArgs args)
        {
            nugs?.AddNugget();
            if (this.combo != null)
            {
                if (this.combo.Entree is DinoNuggets dn)
                {
                    dn.AddNugget();
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
