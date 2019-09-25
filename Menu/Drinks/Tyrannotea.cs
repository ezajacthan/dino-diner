using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    class Tyrannotea : Drink
    {
        protected Size size;
        protected bool hasLemon = false;
        protected bool isSweet = false;

        public Tyrannotea() : base()
        {
            this.Price = .99;
            this.Calories = 8;
            this.Ingredients = new List<string>() { "Water", "Tea" };
        }

        public override Size Size
        {
            set
            {
                size = value;
                switch (this.size)
                {
                    case Size.Large:
                        this.Price = 1.99;
                        this.Calories = 32;
                        break;
                    case Size.Medium:
                        this.Price = 1.49;
                        this.Calories = 16;
                        break;
                    default:
                        this.size = Size.Small;
                        break;
                }
            }
            get
            {
                return this.size;
            }
        }

        public void AddLemon()
        {
            this.hasLemon = true;
            Ingredients.Add("Lemon");
        }

        public void AddSugar()
        {
            this.isSweet = true;
            Ingredients.Add("Cane Sugar");
            this.Calories = 2 * this.Calories;
        }
    }
}
