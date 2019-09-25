using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    class Sodasaurus : Drink
    {
        protected Size size;

        public enum SodasaurusFlavor
        {
            Cola,
            Orange,
            Vanilla,
            Chocolate,
            RootBeer,
            Cherry,
            Lime,
        } public SodasaurusFlavor flavor;


        public Sodasaurus() : base()
        {
            this.Price = 1.50;
            this.Calories = 112;
            this.Ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
        }

        public override Size Size
        {
            set
            {
                size = value;
                switch (this.size)
                {
                    case Size.Large:
                        this.Price = 2.5;
                        this.Calories = 208;
                        break;
                    case Size.Medium:
                        this.Price = 2.00;
                        this.Calories = 156;
                        break;
                    default:
                        this.size = Size.Small;
                        break;
                }
            }
            get
            {
                return this.size;
            }
        }
    }
}
