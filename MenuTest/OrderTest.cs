using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;

namespace MenuTest
{
    class OrderTest
    {
        [Fact]
        public void SubtotalShouldCalculateProperly()
        {
            Order o = new Order();
            o.Items = new ObservableCollection<IOrderItem>(new Brontowurst(), new Sodasaurus());
            Assert.Equal(6.86 , o.SubtotalCost);
        }

        [Fact]
        public void SubtotalShouldNotBeNegative()
        {
            Order o = new Order();

        }
    }
}
