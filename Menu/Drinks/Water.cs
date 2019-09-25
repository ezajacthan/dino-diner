using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        protected Size size;
        protected bool Lemon= false;

        public Water() : base()
        {
            this.Price = .1;
            this.Calories = 0;
            this.Ingredients = new List<string>() { "Water" };
        }

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

        public void AddLemon()
        {
            this.Lemon = true;
            Ingredients.Add("Lemon");
        }
    }
}
