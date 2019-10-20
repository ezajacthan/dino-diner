﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class CretaceousCombo: INotifyPropertyChanged
    {
        //backing variables
        private Entree entree;
        private Drink drink;
        private Side side;

        public Entree Entree
        {
            get
            {
                return this.entree;
            }
            set
            {
                this.entree = value;
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Special");
            }
        }
        public Drink Drink
        {
            get
            {
                return this.drink;
            }
            set
            {
                this.drink = value;
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");

            }
        }
        public Side Side
        {
            get
            {
                return this.side;
            }
            set
            {
                this.side = value;
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
            }
        }

        private Size size= Size.Small;
        public Size Size
        {
            get { return size; }

            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the price, description and special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Helper function for event handler
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public double Price
        {
            get { return (Entree.Price + Drink.Price + Side.Price - 0.25); }
        }

        public override string ToString()
        {
            return $"{Entree} Combo";
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> comboIngredients = new List<string>();
                comboIngredients.AddRange(Entree.Ingredients);
                comboIngredients.AddRange(Drink.Ingredients);
                comboIngredients.AddRange(Side.Ingredients);

                return comboIngredients;
            }
        }

        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        private CretaceousCombo() { }

        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                Ingredients.AddRange(Entree.Special);
                Ingredients.Add(Side.ToString());
                Ingredients.AddRange(Side.Special);
                Ingredients.Add(Drink.ToString());
                Ingredients.AddRange(Drink.Special);

                return special.ToArray();                    
            }
        }
    }
}
