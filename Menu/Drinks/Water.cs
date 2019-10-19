using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Represents a water order for the diner
    /// </summary>
    public class Water : Drink
    {
        protected Size size;
        public bool Lemon= false;

        /// <summary>
        /// No argument constructor
        /// </summary>
        public Water() : base()
        {
            this.Price = .1;
            this.Calories = 0;
            //this.Ingredients = new List<string>() { "Water" };
        }

        /// <summary>
        /// Override of the size property
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
            }
            get
            {
                return this.size;
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> sp = new List<string>();
                if (Lemon) sp.Add("Add Lemon");
                if (!Ice) sp.Add("Hold Ice");
                return sp.ToArray();
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water" };
            }
        }

        /// <summary>
        /// Adds lemon to the water
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
            Ingredients.Add("Lemon");
        }

        /// <summary>
        /// Creates the string representation for the object
        /// </summary>
        /// <returns>the string interpretation of the object</returns>
        public override string ToString()
        {
            if (this.Size == Size.Small)
            {
                return "Small Water";
            }
            else if (this.Size == Size.Medium)
            {
                return "Medium Water";
            }
            else return "Large Water";
        }
    }
}
