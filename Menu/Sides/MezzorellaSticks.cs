using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
    {
        //backing variable
        protected Size size;

        /// <summary>
        /// Constructs an object of the Fryceritops class
        /// </summary>
        public MezzorellaSticks() : base()
        {
            this.Price = 0.99;
            this.Calories = 540;
            this.Ingredients = new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
        }

        /// <summary>
        /// Defines gets and sets for the size
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (this.size)
                {
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 720;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
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
