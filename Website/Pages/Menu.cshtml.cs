using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    
    public class MenuModel : PageModel
    {
        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>() { "Entree", "Combo", "Side", "Drink"};

        [BindProperty]
        public float? minimumPrice { get; set; }
        [BindProperty]
        public float? maximumPrice { get; set; }

        [BindProperty]
        public List<string> ingredients { get; set; } = new List<string>();

        public List<Entree> entrees = new List<Entree>();

        public List<Drink> drinks = new List<Drink>();

        public List<Side> sides = new List<Side>();

        public List<CretaceousCombo> combos = new List<CretaceousCombo>();

        public Menu Menu { get; } = new Menu();

        public void OnGet()
        {
            //populate items in lists
            foreach (IMenuItem item in Menu.AvailableMenuItems)
            {
                if(item is CretaceousCombo c)
                {
                    combos.Add(c);
                }
                if (item is Drink d)
                {
                    drinks.Add(d);
                }
                if (item is Entree e)
                {
                    entrees.Add(e);
                }
                if (item is Side s)
                {
                    sides.Add(s);
                }
            }
        }

        public void OnPost()
        {
            //populate items in lists
            foreach (IMenuItem item in Menu.AvailableMenuItems)
            {
                if (item is CretaceousCombo c)
                {
                    combos.Add(c);
                }
                if (item is Drink d)
                {
                    drinks.Add(d);
                }
                if (item is Entree e)
                {
                    entrees.Add(e);
                }
                if (item is Side s)
                {
                    sides.Add(s);
                }
            }

            //check if we need to search
            if(search != null)
            {
                combos = Search(combos, search);
                drinks = Search(drinks, search);
                entrees = Search(entrees, search);
                sides = Search(sides, search);
            }

            //check if we need to filter by price
            if(minimumPrice != null)
            {
                combos = FilterByMinPrice(combos, minimumPrice);
                drinks = FilterByMinPrice(drinks, minimumPrice);
                entrees = FilterByMinPrice(entrees, minimumPrice);
                sides = FilterByMinPrice(sides, minimumPrice);
            }

            if (maximumPrice != null)
            {
                combos = FilterByMaxPrice(combos, maximumPrice);
                drinks = FilterByMaxPrice(drinks, maximumPrice);
                entrees = FilterByMaxPrice(entrees, maximumPrice);
                sides = FilterByMaxPrice(sides, maximumPrice);
            }

            //check if we need to filter by ingredient
            if(ingredients.Count != 0)
            {
                combos = FilterByIngredient(combos, ingredients);
                drinks = FilterByIngredient(drinks, ingredients);
                entrees = FilterByIngredient(entrees, ingredients);
                sides = FilterByIngredient(sides, ingredients);
            }
        }

        /// <summary>
        /// Removes all items in the given list that contain any ingredients from the given list of ingredients
        /// </summary>
        /// <param name="list">The list to search through</param>
        /// <param name="ingr">The list of ingredients by which to search</param>
        /// <returns>The pruned list that does not contain the given ingredients</returns>
        public List<CretaceousCombo> FilterByIngredient(List<CretaceousCombo> list, List<string>ingr)
        {
            List<CretaceousCombo> results = new List<CretaceousCombo>();
            bool foundFlag = false;

            foreach (CretaceousCombo item in list)
            {
                foreach (string s in item.Ingredients)
                {
                    if (ingr.Contains(s))
                    {
                        foundFlag = true;
                    }
                }
                if (!foundFlag) results.Add(item);
                foundFlag = false;
            }

            return results;
        }

        /// <summary>
        /// Removes all items in the given list that contain any ingredients from the given list of ingredients
        /// </summary>
        /// <param name="list">The list to search through</param>
        /// <param name="ingr">The list of ingredients by which to search</param>
        /// <returns>The pruned list that does not contain the given ingredients</returns>
        public List<Side> FilterByIngredient(List<Side> list, List<string> ingr)
        {
            List<Side> results = new List<Side>();
            bool foundFlag = false;

            foreach (Side item in list)
            {
                foreach (string s in item.Ingredients)
                {
                    if (ingr.Contains(s))
                    {
                        foundFlag = true;
                    }
                }
                if (!foundFlag) results.Add(item);
                foundFlag = false;
            }

            return results;
        }

        /// <summary>
        /// Removes all items in the given list that contain any ingredients from the given list of ingredients
        /// </summary>
        /// <param name="list">The list to search through</param>
        /// <param name="ingr">The list of ingredients by which to search</param>
        /// <returns>The pruned list that does not contain the given ingredients</returns>
        public List<Entree> FilterByIngredient(List<Entree> list, List<string> ingr)
        {
            List<Entree> results = new List<Entree>();
            bool foundFlag = false;

            foreach (Entree item in list)
            {
                foreach (string s in item.Ingredients)
                {
                    if (ingr.Contains(s))
                    {
                        foundFlag = true;
                    }
                }
                if (!foundFlag) results.Add(item);
                foundFlag = false;
            }

            return results;
        }

        /// <summary>
        /// Removes all items in the given list that contain any ingredients from the given list of ingredients
        /// </summary>
        /// <param name="list">The list to search through</param>
        /// <param name="ingr">The list of ingredients by which to search</param>
        /// <returns>The pruned list that does not contain the given ingredients</returns>
        public List<Drink> FilterByIngredient(List<Drink> list, List<string> ingr)
        {
            List<Drink> results = new List<Drink>();
            bool foundFlag = false;

            foreach (Drink item in list)
            {
                foreach (string s in item.Ingredients)
                {
                    if (ingr.Contains(s))
                    {
                        foundFlag = true;
                    }
                }
                if (!foundFlag) results.Add(item);
                foundFlag = false;
            }

            return results;
        }

        /// <summary>
        /// Searches and returns all items in the given list to see if their price is above the given minimum
        /// </summary>
        /// <param name="list">The list to be searched through</param>
        /// <param name="price">The minimum price the item must be</param>
        /// <returns>The list with all items with price above the minimum</returns>
        public List<CretaceousCombo> FilterByMinPrice(List<CretaceousCombo> list, float? price)
        {
            List<CretaceousCombo> results = new List<CretaceousCombo>();

            foreach (CretaceousCombo item in list)
            {
                if (price != null && item.Price >= price)
                {
                    results.Add(item);
                }
            }
            

            return results;
        }

        /// <summary>
        /// Searches and returns all items in the given list to see if their price is above the given minimum
        /// </summary>
        /// <param name="list">The list to be searched through</param>
        /// <param name="price">The minimum price the item must be</param>
        /// <returns>The list with all items with price above the minimum</returns>
        public List<Entree> FilterByMinPrice(List<Entree> list, float? price)
        {
            List<Entree> results = new List<Entree>();

            foreach (Entree item in list)
            {
                if (price != null && item.Price >= price)
                {
                    results.Add(item);
                }
            }


            return results;
        }

        /// <summary>
        /// Searches and returns all items in the given list to see if their price is above the given minimum
        /// </summary>
        /// <param name="list">The list to be searched through</param>
        /// <param name="price">The minimum price the item must be</param>
        /// <returns>The list with all items with price above the minimum</returns>
        public List<Side> FilterByMinPrice(List<Side> list, float? price)
        {
            List<Side> results = new List<Side>();

            foreach (Side item in list)
            {
                if (price != null && item.Price >= price)
                {
                    results.Add(item);
                }
            }


            return results;
        }

        /// <summary>
        /// Searches and returns all items in the given list to see if their price is above the given minimum
        /// </summary>
        /// <param name="list">The list to be searched through</param>
        /// <param name="price">The minimum price the item must be</param>
        /// <returns>The list with all items with price above the minimum</returns>
        public List<Drink> FilterByMinPrice(List<Drink> list, float? price)
        {
            List<Drink> results = new List<Drink>();

            foreach (Drink item in list)
            {
                if (price != null && item.Price >= price)
                {
                    results.Add(item);
                }
            }


            return results;
        }

        /// <summary>
        /// Searches and returns all items in the given list to see if their price is above the given minimum
        /// </summary>
        /// <param name="list">The list to be searched through</param>
        /// <param name="price">The minimum price the item must be</param>
        /// <returns>The list with all items with price above the minimum</returns>
        public List<CretaceousCombo> FilterByMaxPrice(List<CretaceousCombo> list, float? price)
        {
            List<CretaceousCombo> results = new List<CretaceousCombo>();

            foreach (CretaceousCombo item in list)
            {
                if (price != null && item.Price <= price)
                {
                    results.Add(item);
                }
            }


            return results;
        }

        /// <summary>
        /// Searches and returns all items in the given list to see if their price is above the given minimum
        /// </summary>
        /// <param name="list">The list to be searched through</param>
        /// <param name="price">The minimum price the item must be</param>
        /// <returns>The list with all items with price above the minimum</returns>
        public List<Entree> FilterByMaxPrice(List<Entree> list, float? price)
        {
            List<Entree> results = new List<Entree>();

            foreach (Entree item in list)
            {
                if (price != null && item.Price <= price)
                {
                    results.Add(item);
                }
            }


            return results;
        }

        /// <summary>
        /// Searches and returns all items in the given list to see if their price is above the given minimum
        /// </summary>
        /// <param name="list">The list to be searched through</param>
        /// <param name="price">The minimum price the item must be</param>
        /// <returns>The list with all items with price above the minimum</returns>
        public List<Side> FilterByMaxPrice(List<Side> list, float? price)
        {
            List<Side> results = new List<Side>();

            foreach (Side item in list)
            {
                if (price != null && item.Price <= price)
                {
                    results.Add(item);
                }
            }


            return results;
        }

        /// <summary>
        /// Searches and returns all items in the given list to see if their price is above the given minimum
        /// </summary>
        /// <param name="list">The list to be searched through</param>
        /// <param name="price">The minimum price the item must be</param>
        /// <returns>The list with all items with price above the minimum</returns>
        public List<Drink> FilterByMaxPrice(List<Drink> list, float? price)
        {
            List<Drink> results = new List<Drink>();

            foreach (Drink item in list)
            {
                if (price != null && item.Price <= price)
                {
                    results.Add(item);
                }
            }


            return results;
        }

        /// <summary>
        /// Searches a list of Cretaceous Combos and returns all combos with the given string in them
        /// </summary>
        /// <param name="list">the list to be searched</param>
        /// <param name="search">the string to search for</param>
        /// <returns>A list containing all combos that contain that string</returns>
        public List<CretaceousCombo> Search(List<CretaceousCombo> list, string search)
        {
            List<CretaceousCombo> results = new List<CretaceousCombo>();

            foreach(CretaceousCombo item in list)
            {
                if(item.ToString().Contains(search))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Searches a list of Drinks and returns all combos with the given string in them
        /// </summary>
        /// <param name="list">the list to be searched</param>
        /// <param name="search">the string to search for</param>
        /// <returns>A list containing all combos that contain that string</returns>
        public List<Drink> Search(List<Drink> list, string search)
        {
            List<Drink> results = new List<Drink>();

            foreach (Drink item in list)
            {
                if (item.ToString().Contains(search))
                {
                    results.Add(item);
                }
            }

            return results;
        }
        /// <summary>
        /// Searches a list of Entrees and returns all combos with the given string in them
        /// </summary>
        /// <param name="list">the list to be searched</param>
        /// <param name="search">the string to search for</param>
        /// <returns>A list containing all combos that contain that string</returns>
        public List<Entree> Search(List<Entree> list, string search)
        {
            List<Entree> results = new List<Entree>();

            foreach (Entree item in list)
            {
                if (item.ToString().Contains(search))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Searches a list of Cretaceous Combos and returns all combos with the given string in them
        /// </summary>
        /// <param name="list">the list to be searched</param>
        /// <param name="search">the string to search for</param>
        /// <returns>A list containing all combos that contain that string</returns>
        public List<Side> Search(List<Side> list, string search)
        {
            List<Side> results = new List<Side>();

            foreach (Side item in list)
            {
                if (item.ToString().Contains(search))
                {
                    results.Add(item);
                }
            }

            return results;
        }

    }//end of class
}