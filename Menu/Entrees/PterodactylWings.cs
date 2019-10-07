using System;
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// represents a pterodactyl Wings menu item
    /// </summary>
    public class PterodactylWings:Entree
    {
       
        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken" };
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs an object of the PterodactylWings with default price and calories
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

    }
}