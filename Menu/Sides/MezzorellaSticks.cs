using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// represents the mezzorella sticks menu item
    /// </summary>
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
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
               return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
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
                return "Small Mezzorella Sticks";
            }
            else if (this.Size == Size.Medium)
            {
                return "Medium Mezzorella Sticks";
            }
            else return "Large Mezzorella Sticks";
        }
    }
}
