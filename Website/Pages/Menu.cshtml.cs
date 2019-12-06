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

        public IEnumerable<Entree> entrees = new List<Entree>();

        public IEnumerable<Drink> drinks = new List<Drink>();

        public IEnumerable<Side> sides = new List<Side>();

        public IEnumerable<CretaceousCombo> combos = new List<CretaceousCombo>();

        public Menu Menu { get; } = new Menu();

        public void OnGet()
        {
            List<CretaceousCombo> comboList = new List<CretaceousCombo>();
            List<Drink> drinkList = new List<Drink>();
            List<Side> sideList = new List<Side>();
            List<Entree> entreeList = new List<Entree>();

            //populate items in lists
            foreach (IMenuItem item in Menu.AvailableMenuItems)
            {
                

                if(item is CretaceousCombo c)
                {
                    comboList.Add(c);
                }
                combos = comboList;

                if (item is Drink d)
                {
                    drinkList.Add(d);
                }
                drinks = drinkList;

                if (item is Entree e)
                {
                    entreeList.Add(e);
                }
                entrees = entreeList;

                if (item is Side s)
                {
                    sideList.Add(s);
                }
                sides = sideList;
            }
        }

        public void OnPost()
        {
            List<CretaceousCombo> comboList = new List<CretaceousCombo>();
            List<Drink> drinkList = new List<Drink>();
            List<Side> sideList = new List<Side>();
            List<Entree> entreeList = new List<Entree>();

            //populate items in lists
            foreach (IMenuItem item in Menu.AvailableMenuItems)
            {


                if (item is CretaceousCombo c)
                {
                    comboList.Add(c);
                }
                combos = comboList;

                if (item is Drink d)
                {
                    drinkList.Add(d);
                }
                drinks = drinkList;

                if (item is Entree e)
                {
                    entreeList.Add(e);
                }
                entrees = entreeList;

                if (item is Side s)
                {
                    sideList.Add(s);
                }
                sides = sideList;
            }

            //check if we need to search
            if (search != null)
            {
                //combos = Search(combos, search);
                combos = combos.Where(c => c.ToString().Contains(search));
                drinks = drinks.Where(d => d.ToString().Contains(search));
                entrees = entrees.Where(e => e.ToString().Contains(search));
                sides = sides.Where(s => s.ToString().Contains(search));
            }

            //check if we need to filter by price
            if(minimumPrice != null)
            {
                combos = combos.Where(c => c.Price >= minimumPrice);
                sides = sides.Where(s => s.Price >= minimumPrice);
                entrees = entrees.Where(e => e.Price >= minimumPrice);
                drinks = drinks.Where(d => d.Price >= minimumPrice);
            }

            if (maximumPrice != null)
            {
                combos = combos.Where(c => c.Price <= maximumPrice);
                sides = sides.Where(s => s.Price <= maximumPrice);
                entrees = entrees.Where(e => e.Price <= maximumPrice);
                drinks = drinks.Where(d => d.Price <= maximumPrice);
            }

            //check if we need to filter by ingredient
            if(ingredients.Count != 0)
            {
                //combos = combos.Where(c => c.Ingredients.Where(str => ingredients.Contains(str)));
                //sides = sides.Where(s => s.Price <= maximumPrice);
                //entrees = entrees.Where(e => e.Price <= maximumPrice);
                //drinks = drinks.Where(d => d.Price <= maximumPrice);
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

       

    }//end of class
}