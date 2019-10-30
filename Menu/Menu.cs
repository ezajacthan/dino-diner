using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents the menu of our diner
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// property to return all menu items
        /// </summary>
        List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();

                items.Add(new Brontowurst());
                items.Add(new DinoNuggets());
                items.Add(new PrehistoricPBJ());
                items.Add(new PterodactylWings());
                items.Add(new SteakosaurusBurger());
                items.Add(new TRexKingBurger());
                items.Add(new VelociWrap());

                items.Add(new JurrasicJava());
                items.Add(new Sodasaurus());
                items.Add(new Tyrannotea());
                items.Add(new Water());

                items.Add(new Fryceritops());
                items.Add(new MeteorMacAndCheese());
                items.Add(new MezzorellaSticks());
                items.Add(new Triceritots());

                return items;
            }
        }

        /// <summary>
        /// property to get all entrees
        /// </summary>
        List<Entree> AvailiableEntrees
        {
            get
            {
                List<Entree> items = new List<Entree>();

                items.Add(new Brontowurst());
                items.Add(new DinoNuggets());
                items.Add(new PrehistoricPBJ());
                items.Add(new PterodactylWings());
                items.Add(new SteakosaurusBurger());
                items.Add(new TRexKingBurger());
                items.Add(new VelociWrap());

                return items;
            }
        }

        /// <summary>
        /// property to get all sides
        /// </summary>
        List<Side> AvailiableSides
        {
            get
            {
                List<Side> items = new List<Side>();

                items.Add(new Fryceritops());
                items.Add(new MeteorMacAndCheese());
                items.Add(new MezzorellaSticks());
                items.Add(new Triceritots());

                return items;
            }
        }

        /// <summary>
        /// property to get all drinks
        /// </summary>
        List<Drink> AvailiableDrinks
        {
            get
            {
                List<Drink> items = new List<Drink>();

                items.Add(new JurrasicJava());
                items.Add(new Sodasaurus());
                items.Add(new Tyrannotea());
                items.Add(new Water());

                return items;
            }
        }

        /// <summary>
        /// Overrides the ToString to return the full menu contents
        /// </summary>
        /// <returns> a string of all the menu items</returns>
        public override string ToString()
        {
            string output = "";
            foreach (IMenuItem i in AvailableMenuItems)
            {
                output += i.ToString();
                output += '\n';
            }

            return output;
        }
    }
}
