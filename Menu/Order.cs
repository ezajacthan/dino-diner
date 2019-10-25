using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents an order in the dino diner project
    /// </summary>
    public class Order :INotifyPropertyChanged
    {
        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            Items.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged (object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));

        }

        /// <summary>
        /// List of items in the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// Gets the subtotal of the order
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal=0;
                foreach (IOrderItem item in Items)
                {
                    subtotal += item.Price;
                }
                if (subtotal < 0) return 0.00;
                else return Math.Round(subtotal,2);

            }
        }

        private double salesTaxRate = 0.07;

        /// <summary>
        /// Gets/sets teh sales tax rate
        /// </summary>
        public double SalesTaxRate
        {
            get { return salesTaxRate; }
            protected set
            {
                salesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            }
        }

        /// <summary>
        /// Gets the total tax amount of the order
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return Math.Round(SalesTaxRate * SubtotalCost, 2);
            }
        }

        /// <summary>
        /// Gets the total cost of the order
        /// </summary>
        public double TotalCost
        {
            get { return Math.Round(this.SubtotalCost + SalesTaxCost, 2); }
        }

        /// <summary>
        /// Event handler for property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            Items.Add(item);
        }
    }
}
