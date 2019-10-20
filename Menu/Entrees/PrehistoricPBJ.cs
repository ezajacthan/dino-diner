using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// represents a Prehistoric PBJ menu item
    /// </summary>
    public class PrehistoricPBJ : Entree ,IOrderItem, INotifyPropertyChanged
    {
        //backing variables
        private bool peanutButter = true;
        private bool jelly = true;
        
        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if(!peanutButter)
                {
                    special.Add("Hold Peanut Butter");
                }
                if(!jelly)
                {
                    special.Add("Hold Jelly");
                }
                return special.ToArray();
            }
        }
        
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
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Sets the object such that there is no jelly
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
