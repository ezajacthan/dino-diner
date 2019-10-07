using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Represents a Tyrannotea order for the diner
    /// </summary>
    public class Tyrannotea : Drink
    {
        protected Size size;
        public bool hasLemon = false;
        public bool isSweet = false;

        /// <summary>
        /// No argument constructor
        /// </summary>
        public Tyrannotea() : base()
        {
            this.Price = .99;
            this.Calories = 8;
            this.Ingredients = new List<string>() { "Water", "Tea" };
        }

        /// <summary>
        /// Override of the size property
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (this.size)
                {
                    case Size.Large:
                        this.Price = 1.99;
                        this.Calories = 32;
                        break;
                    case Size.Medium:
                        this.Price = 1.49;
                        this.Calories = 16;
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

        /// <summary>
        /// Adds lemon to the tea order
        /// </summary>
        public void AddLemon()
        {
            this.hasLemon = true;
            Ingredients.Add("Lemon");
        }

        /// <summary>
        /// Adds sugar to the tea order
        /// </summary>
        public void AddSugar()
        {
            this.isSweet = true;
            Ingredients.Add("Cane Sugar");
            this.Calories = 2 * this.Calories;
        }

        /// <summary>
        /// removes sugar from the tea order
        /// </summary>
        public void RemoveSugar()
        {
            this.isSweet = false;
            Ingredients.Remove("Cane Sugar");
            this.Calories = ((this.Calories) / 2);
        }

        /// <summary>
        /// Creates the string representation for the object
        /// </summary>
        /// <returns>the string interpretation of the object</returns>
        public override string ToString()
        {
            if (this.Size == Size.Small)
            {
                if (isSweet)
                {
                    return "Small Sweet Tyrannotea";
                }
                else return "Small Tyrannotea";
            }
            else if (this.Size == Size.Medium)
            {
                if (isSweet)
                {
                    return "Medium Sweet Tyrannotea";
                }
                else return "Medium Tyrannotea";
            }
            else
            {
                if (isSweet)
                {
                    return "Large Sweet Tyrannotea";
                }
                return "Large Tyrannotea";
            }
        }
    }
}
