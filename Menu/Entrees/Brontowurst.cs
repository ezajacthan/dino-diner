using System;
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Represents the Brontowurst menu item
    /// </summary>
    public class Brontowurst:Entree
    {
        //backing variables
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

       
        /// <summary>
        /// Gets the list of ingredients 
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                if (bun) ingredients.Add("Whole Wheat Bun");
                return ingredients;
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> sp = new List<string>();
                if (!peppers) sp.Add("Hold Peppers");
                if (!onions) sp.Add("Hold Onions");
                if (!bun) sp.Add("Hold Bun");
                return sp.ToArray();
            }
        }

        /// <summary>
        /// Constructs a new object of the Brontowurst with the default price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Sets the object such that there are no peppers 
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Sets the object such that there are no onions
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Sets the object such that there is no bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChange("Special");
        }

        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}