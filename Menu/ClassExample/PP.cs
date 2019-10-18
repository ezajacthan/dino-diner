using System;
using System.Collections.Generic;
using System.Text;

namespace DDExample
{
    public class PP : Entree
    {
        private bool bun = true;
        private bool mayo = true;
        private List<string> ingredients;

        public PP()
        {
            Price = 5.50;
            Calories = 487;
        }

        public void HoldBun()
        {
            bun = false;
            ingredients.Remove("Whole Wheat Bun");
        }

        public void HoldMayo()
        {
            mayo = false;
            ingredients.Remove("Mayonnaise");
        }

        public override List<string> Ingredients
        {
            get { return new List<string>() { "Fish Patty", "Whole Wheat Bun", "Mayonnaise" }; }
        }

    }
}
