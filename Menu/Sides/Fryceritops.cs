using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// represents the fryceritops menu item
    /// </summary>
    public class Fryceritops : Side
    {
        //backing variable
        protected Size size;

        /// <summary>
        /// Constructs an object of the Fryceritops class
        /// </summary>
        public Fryceritops() : base()
        {
            this.Price = 0.99;
            this.Calories = 222;
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
                        this.Calories = 480;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 365;
                        break;
                    default:
                        this.size = Size.Small;
                        break;
                }
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Special");
            }
            get
            {
                return this.size;
            }
        }

        public override List<string> Ingredients
        {
            get
            {
              return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// Creates the string representation for the object
        /// </summary>
        /// <returns>the string interpretation of the object</returns>
        public override string ToString()
        {
            if (this.Size == Size.Small)
            {
                return "Small Fryceritops";
            }
            else if (this.Size == Size.Medium)
            {
                return "Medium Fryceritops";
            }
            else return "Large Fryceritops";
        }
    }
}
