using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Represents the Meteor Mac and Cheese menu item
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        //backing variable
        protected Size size;

        /// <summary>
        /// Constructs an object of the Fryceritops class
        /// </summary>
        public MeteorMacAndCheese() : base()
        {
            this.Price = 0.99;
            this.Calories = 420;
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
                        this.Calories = 520;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 490;
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

        public override List<string> Ingredients
        {
            get
            {
              return new List<string>() { "Cheese Product", "Macaroni Noodles", "Pork Sausage" };
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
                return "Small Meteor Mac and Cheese";
            }
            else if (this.Size == Size.Medium)
            {
                return "Medium Meteor Mac and Cheese";
            }
            else return "Large Meteor Mac and Cheese";
        }
    }
}
