using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        public Entree Entree { get; set; }
        public Drink Drink { get; set; }
        public Side Side { get; set; }

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
