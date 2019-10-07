using System;
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Represents a velociwrap menu item
    /// </summary>
    public class VelociWrap : Entree
    {
        //backing variables
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

       
        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla" };
                ingredients.Add("Chicken Breast");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs an object of the VelociWrap class with default price and calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Sets the object such that there is no lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Sets the object such that there is no dressing
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Sets the object such that there is no cheese
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }

        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}