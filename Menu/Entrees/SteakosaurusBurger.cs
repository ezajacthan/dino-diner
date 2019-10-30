using System;
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the Steakosaurus Burger menu item
    /// </summary>
    public class SteakosaurusBurger:Entree
    {
        //backing variables
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// Gets the special instructions for the steakosaurus
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> sp = new List<string>();
               
                if (!ketchup)
                {
                    sp.Add("Hold Ketchup");
                }
                if (!mustard)
                {
                    sp.Add("Hold Mustard");
                }
                if (!bun)
                {
                    sp.Add("Hold Bun");
                }
                if (!pickle)
                {
                    sp.Add("Hold Pickle");
                }

                return sp.ToArray();
            }
        }

        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs an object of the SteakosaurusBurger with default price and calories
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Sets the object such that there is no bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Sets the object such that there is no pickle
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Sets the object such that there is no ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// sets the object such that there is no mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyOfPropertyChange("Special");
        }

        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}