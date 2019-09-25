using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    class JurrasicJava : Drink
    {
        protected Size size;
        protected bool RoomForCream =false;
        protected bool Decaf = false;


        public JurrasicJava() : base()
        {
            this.Price = .59;
            this.Calories = 2;
            this.Ingredients = new List<string>() { "Water", "Coffee"};
            this.Ice = false;
        }

        public override Size Size
        {
            set
            {
                size = value;
                switch (this.size)
                {
                    case Size.Large:
                        this.Price = 1.49;
                        this.Calories = 8;
                        break;
                    case Size.Medium:
                        this.Price = .99;
                        this.Calories = 4;
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

        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
            Ingredients.Add("Cream");
        }

        public void AddIce()
        {
            this.Ice = true;
            Ingredients.Add("Ice");
        }
    }
}
