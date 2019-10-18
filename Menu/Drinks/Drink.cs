using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{

    public abstract class Drink : IMenuItem, IOrderItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        public bool Ice { get; set; } = true;

        /// <summary>
        /// The description of the drink
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// The special instructions of the drink
        /// </summary>
        public abstract string[] Special { get; }

        public void HoldIce()
        {
            Ice = false;
        }

    }
}

