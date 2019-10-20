using System;
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Represents the T Rex King Burger menu item
    /// </summary>
    public class TRexKingBurger: Entree
    {
        //backing variables
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool pickle = true;
        private bool onion = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Steakburger Pattie");
                if (lettuce) ingredients.Add("Lettuce");
                if (onion) ingredients.Add("Onion");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (tomato) ingredients.Add("Tomato");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets the special instructions of the Trex burger
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> sp = new List<string>();
                if (!ketchup) sp.Add("Hold Ketchup");
                if (!mustard) sp.Add("Hold Mustard");
                if (!bun) sp.Add("Hold Bun");
                if (!pickle) sp.Add("Hold Pickle");
                if (!lettuce) sp.Add("Hold Lettuce");
                if (!mayo) sp.Add("Hold Mayo");
                if (!onion) sp.Add("Hold Onion");
                if (!tomato) sp.Add("Hold Tomato");
                return sp.ToArray();
            }
        }

        /// <summary>
        /// Constructs an object of the TRexKingBurger with default calories and price
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Sets the object such that there is no lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Sets the object such that there is no onion
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
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

        /// <summary>
        /// Sets the object such that there is no tomato
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
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
        /// Sets the object such that there is no mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Sets the object such that there is no mayo
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            NotifyOfPropertyChange("Special");
        }

        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}