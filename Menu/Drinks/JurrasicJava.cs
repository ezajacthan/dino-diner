using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class to represent the jurrasic java menu item
    /// </summary>
    public class JurrasicJava : Drink
    {
        protected Size size;
        public bool RoomForCream =false;
        public bool decaf = false;

        /// <summary>
        /// no argument constructor
        /// </summary>
        public JurrasicJava() : base()
        {
            this.Price = .59;
            this.Calories = 2;
            this.Ice = false;
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (RoomForCream) special.Add("Room For Cream");
                if (Ice) special.Add("Add Ice");
                if (decaf) special.Add("Decaf");
                return special.ToArray();
            }
        }

        /// <summary>
        /// override for the size property
        /// </summary>
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
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
            }
            get
            {
                return this.size;
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };

            }
        }

        /// <summary>
        /// Leaves room for cream in the coffee
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
            Ingredients.Add("Cream");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Adds ice to the coffee
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            Ingredients.Add("Ice");
            NotifyOfPropertyChange("Special");
        }

        public void Decaf()
        {
            this.decaf = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Creates the string representation for the object
        /// </summary>
        /// <returns>the string interpretation of the object</returns>
        public override string ToString()
        {
            if (this.Size == Size.Small)
            {
                if(decaf)
                {
                    return "Small Decaf Jurassic Java";
                }
                else return "Small Jurassic Java";
            }
            else if (this.Size == Size.Medium)
            {
                if (decaf)
                {
                    return "Medium Decaf Jurassic Java";
                }
                else return "Medium Jurassic Java";
            }
            else
            {
                if (decaf)
                {
                    return "Large Decaf Jurassic Java";
                }
                else return "Large Jurassic Java";
            }
        }
    }
}
