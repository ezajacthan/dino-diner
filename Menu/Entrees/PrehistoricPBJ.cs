using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// represents a Prehistoric PBJ menu item
    /// </summary>
    public class PrehistoricPBJ :Entree
    {
        //backing variables
        private bool peanutButter = true;
        private bool jelly = true;

        
        /// <summary>
        /// Gets the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs an object of the PrehistoricPBJ with the default price and calories
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Sets the object such that there is no peanut butter
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Sets the object such that there is no jelly
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }

        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
