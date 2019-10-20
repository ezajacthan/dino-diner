using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        private ObservableCollection<IOrderItem> items;

        //public ObservableCollection<IOrderItem> Items { get => items; set => items = value; }

        /*public double SubtotalCost
        {
            get
            {
                double subtotal = 0.0;
                Order order = this;
                foreach (IOrderItem item in order)
                {
                    subtotal += item.Price;
                }
                if (subtotal < 0) return 0;
                else return subtotal;
            }
        }

        public double SalesTaxRate { get; protected set; }

        public double SalestTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        public double TotalCost
        {
            get { return this.SubtotalCost + SalestTaxCost; }
        }
    */
    }
}
