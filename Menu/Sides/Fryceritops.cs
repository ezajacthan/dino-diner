using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops :Side
    {
        public Fryceritops() : base()
        {
            this.Price = 0.99;
            this.Calories = 222;
            this.Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        }

        public override Size Size
        {
            set
            {
                Size = value;
            }
            get
            {
                switch (this.Size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                }
                return this.Size;
            }
        }
    }
}
