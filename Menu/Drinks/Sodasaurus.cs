using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class to represent a Sodasaurus menu item
    /// </summary>
    public class Sodasaurus : Drink//, IOrderItem, INotifyPropertyChanged
    {
        protected Size size;

        /// <summary>
        /// Gets the special instructions for this menu item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Holds the flavor of the sodasaurus
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

        /// <summary>
        /// No argument constructor
        /// </summary>
        public Sodasaurus() : base()
        {
            this.Price = 1.50;
            this.Calories = 112;
        }

        /// <summary>
        /// Override of the size property
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (this.size)
                {
                    case Size.Large:
                        this.Price = 2.5;
                        this.Calories = 208;
                        break;
                    case Size.Medium:
                        this.Price = 2.00;
                        this.Calories = 156;
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

        public override List<string> Ingredients
        {
            get
            {
               return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }

        /// <summary>
        /// Creates the string representation for the object
        /// </summary>
        /// <returns>the string interpretation of the object</returns>
        public override string ToString()
        {
            switch (this.Flavor)
            {
                case SodasaurusFlavor.Cherry:
                    if (this.Size == Size.Small)
                    {
                        return "Small Cherry Sodasaurus";
                    }
                    else if (this.Size == Size.Medium)
                    {
                        return "Medium Cherry Sodasaurus";
                    }
                    else return "Large Cherry Sodasaurus";
                case SodasaurusFlavor.Chocolate:
                    if (this.Size == Size.Small)
                    {
                        return "Small Chocolate Sodasaurus";
                    }
                    else if (this.Size == Size.Medium)
                    {
                        return "Medium Chocolate Sodasaurus";
                    }
                    else return "Large Chocolate Sodasaurus";
                case SodasaurusFlavor.Cola:
                    if (this.Size == Size.Small)
                    {
                        return "Small Cola Sodasaurus";
                    }
                    else if (this.Size == Size.Medium)
                    {
                        return "Medium Cola Sodasaurus";
                    }
                    else return "Large Cola Sodasaurus";
                case SodasaurusFlavor.Lime:
                    if (this.Size == Size.Small)
                    {
                        return "Small Lime Sodasaurus";
                    }
                    else if (this.Size == Size.Medium)
                    {
                        return "Medium Lime Sodasaurus";
                    }
                    else return "Large Lime Sodasaurus";
                case SodasaurusFlavor.Orange:
                    if (this.Size == Size.Small)
                    {
                        return "Small Orange Sodasaurus";
                    }
                    else if (this.Size == Size.Medium)
                    {
                        return "Medium Orange Sodasaurus";
                    }
                    else return "Large Orange Sodasaurus";
                case SodasaurusFlavor.RootBeer:
                    if (this.Size == Size.Small)
                    {
                        return "Small RootBeer Sodasaurus";
                    }
                    else if (this.Size == Size.Medium)
                    {
                        return "Medium RootBeer Sodasaurus";
                    }
                    else return "Large RootBeer Sodasaurus";
                default:
                    if (this.Size == Size.Small)
                    {
                        return "Small Vanilla Sodasaurus";
                    }
                    else if (this.Size == Size.Medium)
                    {
                        return "Medium Vanilla Sodasaurus";
                    }
                    else return "Large Vanilla Sodasaurus";
            }
        }
    }
}
