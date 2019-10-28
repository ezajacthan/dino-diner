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
    public class Order : INotifyPropertyChanged
    {
        //backing variables
        private double salesTaxRate = 0.07;
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// List of items in the order
        /// </summary>
        public IOrderItem[] Items
        {
            get { return items.ToArray(); }
        }

        /// <summary>
        /// Gets the subtotal of the order
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal = 0;
                foreach (IOrderItem item in Items)
                {
                    subtotal += item.Price;
                }
                if (subtotal < 0) return 0.00;
                else return Math.Round(subtotal, 2);

            }
        }



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

        public Order()
        {
        }
           
        private void NotifyOfPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        /// <summary>
        /// Event handler for property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Event handler for when 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyOfPropertyChanged();
        }

        /// <summary>
        /// Adds an item to the order
        /// </summary>
        /// <param name="item">The order item to be added to the order</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyOfPropertyChanged();
        }

        /// <summary>
        /// Removes an item from the order
        /// </summary>
        /// <param name="item"></param>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyOfPropertyChanged();
            }
            return removed;
        }
    }
}
