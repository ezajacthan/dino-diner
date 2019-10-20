using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        public ObservableCollection<IOrderItem> Items { get; set; }

        public double SubtotalCost
        {
            get
            {
                double subtotal = 0.0;
                foreach (IOrderItem item in this)
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
    }
}
