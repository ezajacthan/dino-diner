using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents a water order for the diner
    /// </summary>
    public class Water : Drink
    {
        protected Size size;
        public bool Lemon= false;
        private List<string> ingredients = new List<string>() { "Water" };

        /// <summary>
        /// No argument constructor
        /// </summary>
        public Water() : base()
        {
            this.Price = .1;
            this.Calories = 0;
        }

        /// <summary>
        /// Override of the size property
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
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
                List<string> returnList = new List<string>();
                foreach (string s in ingredients)
                {
                    returnList.Add(s);
                }
                return returnList;
            }
        }

        /// <summary>
        /// Adds lemon to the water
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
            ingredients.Add("Lemon");
            NotifyOfPropertyChange("Special");
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
